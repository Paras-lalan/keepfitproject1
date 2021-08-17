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
    public partial class feessearch : Form
    {
        public feessearch()
        {
            InitializeComponent();
            memberdetail();
        }
        datapath d = new datapath();

        public void memberdetail()
        {
            SqlConnection sc = new SqlConnection(d.mainpath);
            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select memberid,name from member", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            mem_id.DataSource = dt;
            mem_id.DisplayMember = "memberid";
            mem_id.ValueMember = "memberid";
            mem_id.SelectedIndex = -1;
            mem_nm.DataSource = dt;
            mem_nm.DisplayMember = "name";
            mem_nm.ValueMember = "name";
            mem_nm.SelectedIndex = -1;

            mem_id1.DataSource = dt;
            mem_id1.DisplayMember = "memberid";
            mem_id1.ValueMember = "memberid";
            mem_id1.SelectedIndex = -1;
            mem_nm1.DataSource = dt;
            mem_nm1.DisplayMember = "name";
            mem_nm1.ValueMember = "name";
            mem_nm1.SelectedIndex = -1;
            sc.Close();
        }

        private void search1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlDataAdapter sda = new SqlDataAdapter("Select * from fees where memberid = '" + this.mem_id.Text + "' OR name = '" + this.mem_nm.Text + "'", sc);
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

        private void export1_Click(object sender, EventArgs e)
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
                StreamWriter wr = new StreamWriter(@"D:\\memberfees.xls");
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
                MessageBox.Show("Fees Data Exported Successfully");
                MessageBox.Show("Check in D drive");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void search2_Click(object sender, EventArgs e)
        {
            try
            {
                if (purch.Checked == true)
                {
                    if (mem_id1.Text != null || mem_id1.Text != string.Empty && mem_nm1.Text != null || mem_nm1.Text != string.Empty)
                    {
                        DataTable dt = new DataTable();
                        SqlConnection sc = new SqlConnection(d.mainpath);
                        SqlDataAdapter sda = new SqlDataAdapter("Select * from fees where memberid = '" + this.mem_id1.Text + "' OR name = '" + this.mem_nm1.Text + "' AND fromdate between '" + this.dt1.Text + "' AND '" + this.dt2.Text + "'", sc);
                        sc.Open();
                        sda.Fill(dt);
                        dataGridView2.DataSource = dt;
                        sc.Close();
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        SqlConnection sc = new SqlConnection(d.mainpath);
                        SqlDataAdapter sda = new SqlDataAdapter("Select * from fees where fromdate between '" + this.dt1.Text + "' AND '" + this.dt2.Text + "'", sc);
                        sc.Open();
                        sda.Fill(dt);
                        dataGridView2.DataSource = dt;
                        sc.Close();
                    }
                }
                else if (exp.Checked == true)
                {
                    if (mem_id1.Text != null || mem_id1.Text != string.Empty && mem_nm1.Text != null || mem_nm1.Text != string.Empty)
                    {
                        DataTable dt = new DataTable();
                        SqlConnection sc = new SqlConnection(d.mainpath);
                        SqlDataAdapter sda = new SqlDataAdapter("Select * from fees where memberid = '" + this.mem_id1.Text + "' OR name = '" + this.mem_nm1.Text + "' AND todate between '" + this.dt1.Text + "' AND '" + this.dt2.Text + "'", sc);
                        sc.Open();
                        sda.Fill(dt);
                        dataGridView2.DataSource = dt;
                        sc.Close();
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        SqlConnection sc = new SqlConnection(d.mainpath);
                        SqlDataAdapter sda = new SqlDataAdapter("Select * from fees where todate between '" + this.dt1.Text + "' AND '" + this.dt2.Text + "'", sc);
                        sc.Open();
                        sda.Fill(dt);
                        dataGridView2.DataSource = dt;
                        sc.Close();
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Bind Grid Data to Datatable
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in dataGridView2.Columns)
                {
                    dt.Columns.Add(col.HeaderText, col.ValueType);
                }
                int count = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (count < dataGridView2.Rows.Count - 1)
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
                StreamWriter wr = new StreamWriter(@"D:\\FeesDatewise.xls");
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
                MessageBox.Show("dateFees Data Exported Successfully");
                MessageBox.Show("Check in D drive");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
