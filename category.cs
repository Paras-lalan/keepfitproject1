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
    public partial class category : Form
    {
        public category()
        {
            InitializeComponent();
            autoincrement();
            autofilltext();
        }
        datapath d = new datapath();

        public void autofilltext()
        {
            SqlConnection con = new SqlConnection(d.mainpath);
            SqlCommand sda = new SqlCommand("select cat_nm from category", con);
            con.Open();
            SqlDataReader dr = sda.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                mycollection.Add(dr.GetString(0));
            }

            cat_nm.AutoCompleteCustomSource = mycollection;
            con.Close();
        }
        public void autoincrement()
        {
            string Id;
            SqlDataAdapter sda = new SqlDataAdapter("select max(cat_cd)+1 from category", d.mainpath);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Id = dt.Rows[0][0].ToString();
            cat_cd.Text = Id;
        }

        public void clearcat()
        {
            cat_cd.Clear();
            cat_nm.Clear();
            cat_cd.Enabled = true;
            autoincrement();
            cat_cd.Focus();
        }

        private void cat_cd_Leave(object sender, EventArgs e)
        {
            try
            {
                cat_cd.Enabled = false;
                String query = "Select cat_nm from category where cat_cd='" + this.cat_cd.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    cat_nm.Text = dr["cat_nm"].ToString();
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

        private void cat_nm_Leave(object sender, EventArgs e)
        {
            try
            {
                cat_cd.Enabled = false;
                String query = "Select cat_cd from category where cat_nm='" + this.cat_nm.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    cat_cd.Text = dr["cat_cd"].ToString();
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
                SqlCommand cmd = new SqlCommand("Insert into category (cat_cd,cat_nm) Values ('" + this.cat_cd.Text + "','" + this.cat_nm.Text + "')", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Record Save Sucessfully");
                sc.Close();
                clearcat();
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
                SqlCommand cmd = new SqlCommand("Update category set cat_nm='" + this.cat_nm.Text + "' where cat_cd='" + this.cat_cd.Text + "'", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Record Update Sucessfully");
                sc.Close();
                clearcat();
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
                SqlCommand cmd = new SqlCommand("Delete from category where cat_cd = '" + this.cat_cd.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data deleted sucessfully");
                clearcat();
                save_btn.Text = "Save";
                change_btn.Enabled = false;
                remove_btn.Enabled = false;
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
                clearcat();
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
                cat_cd.Enabled = false;
                cat_nm.Focus();
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
    }
}
