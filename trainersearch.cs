using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keepfit2._1._2
{
    public partial class trainersearch : Form
    {
        public trainersearch()
        {
            InitializeComponent();
            tdisp();
        }
        datapath d = new datapath();

        public void autofilltext()
        {
            SqlConnection con = new SqlConnection(d.mainpath);
            SqlCommand sda = new SqlCommand("Select * from trainer", con);
            con.Open();
            SqlDataReader dr = sda.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                mycollection.Add(dr.GetString(0));
            }

            textBox1.AutoCompleteCustomSource = mycollection;
            con.Close();
        }
        public void tdisp()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlDataAdapter sda = new SqlDataAdapter("Select * from trainer", sc);
                sc.Open();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sc.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private DataTable PopulateDataGridView()
        {
            string query = "SELECT * FROM trainer";
            query += " WHERE trainername LIKE '%' + @ContactName + '%'";
            query += " OR @ContactName = ''";
            string constr = d.mainpath;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ContactName", textBox1.Text.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Bind Grid Data to Datatable
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    dt.Columns.Add(col.HeaderText, col.ValueType);
                }
                int count = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (count < dataGridView1.Rows.Count - 1)
                    {
                        dt.Rows.Add();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                        }
                    }
                    count++;
                }
                // Bind table data to Stream Writer to export data to respective folder
                StreamWriter wr = new StreamWriter(@"D:\\Trainer.xls");
                // Write Columns to excel file
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    wr.Write(dt.Columns[i].ToString().ToUpper() + "\t");
                }
                wr.WriteLine();
                //write rows to excel file
                for (int i = 0; i < (dt.Rows.Count); i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (dt.Rows[i][j] != null)
                        {
                            wr.Write(Convert.ToString(dt.Rows[i][j]) + "\t");
                        }
                        else
                        {
                            wr.Write("\t");
                        }
                    }
                    wr.WriteLine();
                }
                wr.Close();
                MessageBox.Show("Trainer Data Exported Successfully");
                MessageBox.Show("Check in D drive");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = this.PopulateDataGridView();
        }
    }
}
