using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keepfit2._1._2
{
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
            autofilltext();
        }
        datapath d = new datapath();
        public DateTime cdt = DateTime.Now.Date;
        public void autofilltext()
        {
            SqlConnection con = new SqlConnection(d.mainpath);
            SqlCommand sda = new SqlCommand("select name from member", con);
            con.Open();
            SqlDataReader dr = sda.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                mycollection.Add(dr.GetString(0));
            }

            textBox2.AutoCompleteCustomSource = mycollection;
            con.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                String query = "Select name from member where memberid='" + this.textBox1.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    dr.Read();
                    textBox2.Text = dr["name"].ToString();
                    dr.Close();
                }
                sc.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                String query = "Select memberid from member where name='" + this.textBox2.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    dr.Read();
                    textBox1.Text = dr["memberid"].ToString();
                    dr.Close();
                }
                sc.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void show()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlDataAdapter sda = new SqlDataAdapter("select attendance.date as Date,attendance.memberid as MemberID,attendance.name as Name, fees.cate as Cate,fees.period as Period,fees.fromdate as FromDate,fees.todate as ToDate from attendance inner join fees on attendance.memberid = fees.memberid WHERE attendance.date = '" + cdt + "' ORDER BY DISTINCT fees.memberid DESC", sc);
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlCommand cmd = new SqlCommand("insert into attendance (date,memberid,name) Values ('"+cdt+"','"+this.textBox1.Text+"','"+this.textBox2.Text+"')", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendance Mark");
                sc.Close();
                textBox1.Clear();
                textBox2.Clear();
                show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
