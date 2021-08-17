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
    public partial class package : Form
    {
        public package()
        {
            InitializeComponent();
            autoincrement();
            cat();
            mon();
            showdata();
        }
        datapath d = new datapath();
        string cato, mono;
        public void autoincrement()
        {
            string Id;
            SqlDataAdapter sda = new SqlDataAdapter("select max(pac_id)+1 from package", d.mainpath);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Id = dt.Rows[0][0].ToString();
            pac_id.Text = Id;
        }

        public void cat()
        {
            SqlConnection sc = new SqlConnection(d.mainpath);
            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select cat_nm from category", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            pac_cat.DataSource = dt;
            pac_cat.DisplayMember = "cat_nm";
            pac_cat.ValueMember = "cat_nm";
            pac_cat.SelectedIndex = -1;
        }

        public void mon()
        {
            SqlConnection sc = new SqlConnection(d.mainpath);
            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select period from period", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            pac_month.DataSource = dt;
            pac_month.DisplayMember = "period";
            pac_month.ValueMember = "period";
            pac_month.SelectedIndex = -1;
        }

        public void clearpackage()
        {
            try
            {
                pac_id.Clear();
                pac_cat.SelectedIndex = -1;
                pac_cat.Text = "";
                pac_month.SelectedIndex = -1;
                pac_month.Text = "";
                pac_amt.Clear();
                pac_id.Enabled = true;
                autoincrement();
                pac_id.Focus();
                save_btn.Text = "Save";
                change_btn.Enabled = false;
                remove_btn.Enabled = false;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void getcatid()
        {
            try
            {
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand cmd = new SqlCommand("select cat_cd from category where cat_nm = '"+this.pac_cat.Text+"'",sc);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    cato = dr["cat_cd"].ToString();
                    dr.Close();
                }
                sc.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void getmonthid()
        {
            try
            {
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand cmd = new SqlCommand("select p_id from period where period = '" + this.pac_month.Text + "'", sc);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    mono = dr["p_id"].ToString();
                    dr.Close();
                }
                sc.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void showdata()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlDataAdapter sda = new SqlDataAdapter("select package.pac_id,category.cat_nm as pac_cat, period.period as pac_month,package.pac_amt from ((package inner join category on package.pac_cat = category.cat_cd) inner join period on period.p_id = package.pac_month)", sc);
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

        private void pac_id_Leave(object sender, EventArgs e)
        {
            try
            {
                String query = "select category.cat_nm as pac_cat, period.period as pac_month,package.pac_amt from ((package inner join category on package.pac_cat = category.cat_cd) inner join period on period.p_id = package.pac_month) where package.pac_id = '"+this.pac_id.Text+"'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    dr.Read();
                    pac_cat.Text = dr["pac_cat"].ToString();
                    pac_month.Text = dr["pac_month"].ToString();
                    pac_amt.Text = dr["pac_amt"].ToString();
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
                SqlCommand cmd = new SqlCommand("Insert into package (pac_id,pac_cat,pac_month,pac_amt) Values ('"+this.pac_id.Text+"','"+cato+"','"+mono+"','"+this.pac_amt.Text+"')", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Record Save Sucessfully");
                sc.Close();
                clearpackage();
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
                SqlCommand cmd = new SqlCommand("update package set pac_cat='"+cato+"',pac_month='"+mono+"',pac_amt='"+this.pac_amt.Text+"' where pac_id='" + this.pac_id.Text + "'", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Record Update Sucessfully");
                sc.Close();
                clearpackage();
                save_btn.Text = "Save";
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
                pac_id.Enabled = false;
                pac_cat.Focus();
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
                SqlCommand cmd = new SqlCommand("Delete from package where pac_id = '" + this.pac_id.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data deleted sucessfully");
                clearpackage();
                save_btn.Text = "Save";
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
                clearpackage();
                save_btn.Text = "Save";
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

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                removedata();
            }
            catch (Exception es)
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
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void pac_cat_Leave(object sender, EventArgs e)
        {
            getcatid();
        }

        private void pac_month_Leave(object sender, EventArgs e)
        {
            getmonthid();
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
    }
}
