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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            birth();
            fe();
            pte();
        }
        datapath d = new datapath();

        public void birth()
        {
            //int D = Convert.ToInt32(DateTime.Today.Day);
            //int M = DateTime.Today.Month;
            DataTable dt = new DataTable();
            string Query = "Select memberid,name,dob,mobile From member WHERE (DATEPART(DAY,dob) = @Day) AND (DATEPART(MONTH,dob)=@Month)";
            SqlConnection sc = new SqlConnection(d.mainpath);
            SqlCommand cmd = new SqlCommand(Query, sc);
            cmd.Parameters.AddWithValue("@Day", DateTime.Today.Day);
            cmd.Parameters.AddWithValue("@Month", DateTime.Today.Month);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sc.Open();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sc.Close();
        }

        public void fe()
        {
            try
            {
                string mquery = "select distinct fees.memberid,member.name,member.mobile,fees.cate,fees.period,fees.fromdate,fees.todate,fees.amt from fees inner join member ON fees.memberid = member.memberid where fees.todate >= DATEADD(DD,15,GETDATE()) or (fees.todate >= DATEADD(DD,14,GETDATE()))  OR (fees.todate >= DATEADD(DD,13,GETDATE())) OR (fees.todate >= DATEADD(DD,12,GETDATE())) OR (fees.todate >= DATEADD(DD,11,GETDATE())) OR (fees.todate >= DATEADD(DD,10,GETDATE())) OR (fees.todate >= DATEADD(DD,9,GETDATE())) OR (fees.todate >= DATEADD(DD,8,GETDATE())) OR (fees.todate >= DATEADD(DD,7,GETDATE())) OR (fees.todate >= DATEADD(DD,6,GETDATE())) OR (fees.todate >= DATEADD(DD,5,GETDATE())) OR (fees.todate >= DATEADD(DD,4,GETDATE())) OR (fees.todate >= DATEADD(DD,3,GETDATE())) OR (fees.todate >= DATEADD(DD,2,GETDATE())) OR(fees.todate >= DATEADD(DD,1,GETDATE())) order by fees.memberid DESC";
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlDataAdapter sda = new SqlDataAdapter(mquery, sc);
                DataTable dt = new DataTable();
                sc.Open();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
                sc.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void pte()
        {
            try
            {
                string mquery = "select distinct fees.memberid,member.name,member.mobile,fees.trainerid as trainer,fees.periodid as period,fees.tfromdate,fees.ttodate,fees.tamount from fees inner join member ON fees.memberid = member.memberid where fees.ttodate >= DATEADD(DD,15,GETDATE())  or (fees.todate >= DATEADD(DD,14,GETDATE()))  OR (fees.todate >= DATEADD(DD,13,GETDATE())) OR (fees.todate >= DATEADD(DD,12,GETDATE())) OR (fees.todate >= DATEADD(DD,11,GETDATE())) OR (fees.todate >= DATEADD(DD,10,GETDATE())) OR (fees.todate >= DATEADD(DD,9,GETDATE())) OR (fees.todate >= DATEADD(DD,8,GETDATE())) OR (fees.todate >= DATEADD(DD,7,GETDATE())) OR (fees.todate >= DATEADD(DD,6,GETDATE())) OR (fees.todate >= DATEADD(DD,5,GETDATE())) OR (fees.todate >= DATEADD(DD,4,GETDATE())) OR (fees.todate >= DATEADD(DD,3,GETDATE())) OR (fees.todate >= DATEADD(DD,2,GETDATE())) OR(fees.todate >= DATEADD(DD,1,GETDATE())) order by fees.memberid DESC";
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlDataAdapter sda = new SqlDataAdapter(mquery, sc);
                DataTable dt = new DataTable();
                sc.Open();
                sda.Fill(dt);
                dataGridView3.DataSource = dt;
                sc.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                StreamWriter wr = new StreamWriter(@"D:\\Fees.xls");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Bind Grid Data to Datatable
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in dataGridView3.Columns)
                {
                    dt.Columns.Add(col.HeaderText, col.ValueType);
                }
                int count = 0;
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (count < dataGridView3.Rows.Count - 1)
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
                StreamWriter wr = new StreamWriter(@"D:\\PT.xls");
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
                MessageBox.Show("PT Data Exported Successfully");
                MessageBox.Show("Check in D drive");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
