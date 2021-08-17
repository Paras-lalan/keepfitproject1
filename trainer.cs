using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keepfit2._1._2
{
    public partial class trainer : Form
    {
        public trainer()
        {
            InitializeComponent();
            autoincrement();
            gend();
        }
        datapath d = new datapath();

        public void autoincrement()
        {
            string Id;
            SqlDataAdapter sda = new SqlDataAdapter("select max(trainerid)+1 from trainer", d.mainpath);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Id = dt.Rows[0][0].ToString();
            train_id.Text = Id;
        }

        public void gend()
        {
            SqlConnection sc = new SqlConnection(d.mainpath);
            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select gender from genderdtl", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            train_gender.DataSource = dt;
            train_gender.DisplayMember = "gender";
            train_gender.ValueMember = "gender";
            train_gender.SelectedIndex = -1;
        }
        public void cleartrainer()
        {
            train_id.Clear();
            train_nm.Clear();
            train_gender.SelectedIndex = -1;
            train_gender.Text = "";
            train_pan.Clear();
            train_aadhar.Clear();
            train_l1.Clear();
            train_l2.Clear();
            train_l3.Clear();
            train_city.Clear();
            train_pin.Clear();
            train_mob.Clear();
            train_email.Clear();
            train_sal.Clear();
            train_id.Enabled = true;
            autoincrement();
            train_id.Focus();
        }

        private void train_id_Leave(object sender, EventArgs e)
        {
            try
            {
                String query = "Select trainername,trainerdob,gender,pan,aadhar,line1,line2,line3,city,pincode,mob,emailid,salary from trainer where trainerid='" + this.train_id.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    dr.Read();
                    train_nm.Text = dr["trainername"].ToString();
                    train_dob.Text = dr["trainerdob"].ToString();
                    train_gender.Text = dr["gender"].ToString();
                    train_pan.Text = dr["pan"].ToString();
                    train_aadhar.Text = dr["aadhar"].ToString();
                    train_l1.Text = dr["line1"].ToString();
                    train_l2.Text = dr["line2"].ToString();
                    train_l3.Text = dr["line3"].ToString();
                    train_city.Text = dr["city"].ToString();
                    train_pin.Text = dr["pincode"].ToString();
                    train_mob.Text = dr["mob"].ToString();
                    train_email.Text = dr["emailid"].ToString();
                    train_sal.Text = dr["salary"].ToString();
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

        private void train_mob_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = Get_Numrestrict.numcheck(e.KeyChar);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void train_mob_Leave(object sender, EventArgs e)
        {
            try
            {
                if (train_mob.Text != null && train_mob.Text.Length != 10)
                {
                    MessageBox.Show("Mobile no should be 10 digit");
                    train_mob.Focus();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void train_email_Leave(object sender, EventArgs e)
        {
            try
            {
                if (train_email.Text != null && train_email.Text != string.Empty)
                {
                    string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                     @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                     @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                    Regex re = new Regex(strRegex);
                    if (!re.IsMatch(train_email.Text))
                    {
                        MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //SendKeys.Send("+{TAB}");
                        train_email.Focus();
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void train_sal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = Get_Numrestrict.numcheck(e.KeyChar);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void train_pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = Get_Numrestrict.numcheck(e.KeyChar);
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
                SqlCommand cmd = new SqlCommand("Insert into trainer (trainerid,trainername,trainerdob,gender,pan,aadhar,line1,line2,line3,city,pincode,mob,emailid,salary) Values ('" + this.train_id.Text + "','" + this.train_nm.Text + "','" + this.train_dob.Text + "','" + this.train_gender.Text + "','" + this.train_pan.Text + "','" + this.train_aadhar.Text + "','" + this.train_l1.Text + "','" + this.train_l2.Text + "','" + this.train_l3.Text + "','" + this.train_city.Text + "','" + this.train_pin.Text + "','" + this.train_mob.Text + "','" + this.train_email.Text + "','" + this.train_sal.Text + "')", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trainer Record Save Sucessfully");
                sc.Close();
                cleartrainer();
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
                SqlCommand cmd = new SqlCommand("Update trainer set trainername='" + this.train_nm.Text + "',trainerdob='" + this.train_dob.Text + "',gender='" + this.train_gender.Text + "',pan='" + this.train_pan.Text + "',aadhar='" + this.train_aadhar.Text + "',line1='" + this.train_l1.Text + "',line2='" + this.train_l2.Text + "',line3='" + this.train_l3.Text + "',city='" + this.train_city.Text + "',pincode='" + this.train_pin.Text + "',mob='" + this.train_mob.Text + "',emailid='" + this.train_email.Text + "',salary='" + this.train_sal.Text + "' where train_id='" + this.train_id.Text + "'", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trainer Record Update Sucessfully");
                sc.Close();
                cleartrainer();
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
                cleartrainer();
                train_id.Enabled = true;
                save_btn.Text = "Save";
                change_btn.Enabled = false;
                remove_btn.Enabled = false;
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
                SqlCommand cmd = new SqlCommand("Delete from trainer where trainerid = '" + this.train_id.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data deleted sucessfully");
                cleartrainer();
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
                train_id.Enabled = false;
                train_nm.Focus();
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
                    if (train_id.Text == string.Empty || train_id.Text == null)
                    {
                        MessageBox.Show("Trainer Id Please");
                        train_id.Focus();
                    }
                    else if (train_nm.Text == null || train_nm.Text == string.Empty)
                    {
                        MessageBox.Show("Trainer Name");
                        train_nm.Focus();
                    }
                    else
                    {
                        updatedata();
                    }
                }
                else
                {
                    if (train_id.Text == string.Empty || train_id.Text == null)
                    {
                        MessageBox.Show("Trainer Id Please");
                        train_id.Focus();
                    }
                    else if (train_nm.Text == null || train_nm.Text == string.Empty)
                    {
                        MessageBox.Show("Trainer Name");
                        train_nm.Focus();
                    }
                    else
                    {
                        savedata();
                    }
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
