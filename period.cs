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
    public partial class period : Form
    {
        public period()
        {
            InitializeComponent();
            autoincrement();
            autofilltext();
        }
        datapath d = new datapath();

        public void autoincrement()
        {
            string Id;
            SqlDataAdapter sda = new SqlDataAdapter("select max(p_id)+1 from period", d.mainpath);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Id = dt.Rows[0][0].ToString();
            p_id.Text = Id;
        }
        public void autofilltext()
        {
            SqlConnection con = new SqlConnection(d.mainpath);
            SqlCommand sda = new SqlCommand("select period from period", con);
            con.Open();
            SqlDataReader dr = sda.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                mycollection.Add(dr.GetString(0));
            }

            p_name.AutoCompleteCustomSource = mycollection;
            con.Close();
        }

        public void cleardata()
        {
            try
            {
                p_id.Clear();
                p_name.Clear();
                p_id.Enabled = true;
                autoincrement();
                p_id.Focus();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void p_id_Leave(object sender, EventArgs e)
        {
            try
            {
                p_id.Enabled = false;
                String query = "Select period from period where p_id='" + this.p_id.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    p_name.Text = dr["period"].ToString();
                    dr.Close();
                    this.save_btn.Text = "Update";
                    change_btn.Enabled = true;
                    remove_btn.Enabled = true;
                }
                sc.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void p_name_Leave(object sender, EventArgs e)
        {
            try
            {
                p_id.Enabled = false;
                String query = "Select p_id from period where period='" + this.p_name.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    p_id.Text = dr["p_id"].ToString();
                    dr.Close();
                    this.save_btn.Text = "Update";
                    change_btn.Enabled = true;
                    remove_btn.Enabled = true;
                }
                sc.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void savedata()
        {
            try
            {
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlCommand cmd = new SqlCommand("Insert into period (p_id,p_name) Values ('" + this.p_id.Text + "','" + this.p_name.Text + "')", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Period Record Save Sucessfully");
                sc.Close();
                cleardata();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void updatedata()
        {
            try
            {
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlCommand cmd = new SqlCommand("Update period set p_name='" + this.p_name.Text + "' where p_id='" + this.p_id.Text + "'", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Period Record Update Sucessfully");
                sc.Close();
                cleardata();
                save_btn.Text = "Save";
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        public void removedata()
        {
            try
            {
                SqlConnection con = new SqlConnection(d.mainpath);
                SqlCommand cmd = new SqlCommand("Delete from period where p_id = '" + this.p_id.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data deleted sucessfully");
                cleardata();
                save_btn.Text = "Save";
                change_btn.Enabled = false;
                remove_btn.Enabled = false;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void changedata()
        {
            try
            {
                p_id.Enabled = false;
                p_name.Focus();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void avoiddata()
        {
            try
            {
                cleardata();
                change_btn.Enabled = false;
                remove_btn.Enabled = false;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (save_btn.Text == "Update")
                {
                    updatedata();
                }
                else
                {
                    savedata();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            try
            {
                changedata();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                removedata();
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void avoid_btn_Click(object sender, EventArgs e)
        {
            try
            {
                avoiddata();
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
