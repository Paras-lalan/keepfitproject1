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
    public partial class member : Form
    {
        public member()
        {
            InitializeComponent();
            autoincrement();
        }
        datapath d = new datapath();
        string sms,catt;

        public void autoincrement()
        {
            string Id;
            SqlDataAdapter sda = new SqlDataAdapter("select max(memberid)+1 from member", d.mainpath);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Id = dt.Rows[0][0].ToString();
            mem_id.Text = Id;
        }

        public void gend()
        {
            SqlConnection sc = new SqlConnection(d.mainpath);
            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select gender from genderdtl", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            mem_g.DataSource = dt;
            mem_g.DisplayMember = "gender";
            mem_g.ValueMember = "gender";
            mem_g.SelectedIndex = -1;
        }

        public void gend1()
        {
            SqlConnection sc = new SqlConnection(d.mainpath);
            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select gender from genderdtl", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            mem_g1.DataSource = dt;
            mem_g1.DisplayMember = "gender";
            mem_g1.ValueMember = "gender";
            mem_g1.SelectedIndex = -1;
        }

        public void bloodg()
        {
            SqlConnection sc = new SqlConnection(d.mainpath);
            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select bg from bgdtl", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            mem_bg.DataSource = dt;
            mem_bg.DisplayMember = "bg";
            mem_bg.ValueMember = "bg";
            mem_bg.SelectedIndex = -1;
        }

        public void bloodg1()
        {
            SqlConnection sc = new SqlConnection(d.mainpath);
            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select bg from bgdtl", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            mem_bg1.DataSource = dt;
            mem_bg1.DisplayMember = "bg";
            mem_bg1.ValueMember = "bg";
            mem_bg1.SelectedIndex = -1;
        }

        public void memonetrue()
        {
            mem_name1.Enabled = true;
            mem_dob1.Enabled = true;
            mem_g1.Enabled = true;
            mem_h1.Enabled = true;
            mem_w1.Enabled = true;
            mem_bg1.Enabled = true;
        }

        public void memonefalse()
        {
            mem_name1.Clear();
            mem_g1.SelectedIndex = -1;
            mem_g1.Text = "";
            mem_h1.Clear();
            mem_w1.Clear();
            mem_bg1.SelectedIndex = -1;
            mem_bg1.Text = "";
            mem_name1.Enabled = false;
            mem_dob1.Enabled = false;
            mem_g1.Enabled = false;
            mem_h1.Enabled = false;
            mem_w1.Enabled = false;
            mem_bg1.Enabled = false;
        }
        public void checkbox_con()
        {
            try
            {
                if (mem_sms.Checked == true)
                {
                    sms = "Y";
                }
                else
                {
                    sms = "N";
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void clearmember()
        {
            mem_id.Clear();
            mem_name.Clear();
            mem_g.SelectedIndex = -1;
            mem_g.Text = "";
            mem_h.Clear();
            mem_w.Clear();
            mem_bg.SelectedIndex = -1;
            mem_bg.Text = "";
            //1st
            mem_name1.Clear();
            mem_g1.SelectedIndex = -1;
            mem_g1.Text = "";
            mem_h1.Clear();
            mem_w1.Clear();
            mem_bg1.SelectedIndex = -1;
            mem_bg1.Text = "";
            //contact
            mem_l1.Clear();
            mem_l2.Clear();
            mem_l3.Clear();
            mem_city.Clear();
            mem_pin.Clear();
            mem_mob.Clear();
            mem_sms.Checked = false;
            mem_email.Clear();
            memonefalse();
            autoincrement();
            mem_id.Enabled = true;
            mem_id.Focus();
        }

        private void mem_id_Leave(object sender, EventArgs e)
        {
            try
            {
                String query = "Select cat,name,dob,gender,hight,weight,bg,name1,dob1,gender1,hight1,weight1,bg1,line1,line2,line3,city,pincode,mobile,email,sendsms from member where memberid='" + this.mem_id.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    dr.Read();
                    string category = dr["cat"].ToString();
                    if (category == "I")
                    {
                        mem_id.Enabled = false;
                        mem_i.Checked = true;
                        mem_name.Text = dr["name"].ToString();
                        mem_dob.Text = dr["dob"].ToString();
                        mem_g.Text = dr["gender"].ToString();
                        mem_h.Text = dr["hight"].ToString();
                        mem_w.Text = dr["weight"].ToString();
                        mem_bg.Text = dr["bg"].ToString();
                        mem_l1.Text = dr["line1"].ToString();
                        mem_l2.Text = dr["line2"].ToString();
                        mem_l3.Text = dr["line3"].ToString();
                        mem_city.Text = dr["city"].ToString();
                        mem_pin.Text = dr["pincode"].ToString();
                        mem_mob.Text = dr["mobile"].ToString();
                        mem_email.Text = dr["email"].ToString();
                        string sms = dr["sendsms"].ToString();
                        if (sms == "Y")
                        {
                            mem_sms.Checked = true;
                        }
                        else
                        {
                            mem_sms.Checked = false;
                        }
                        dr.Close();
                        this.save_btn.Text = "Update";
                        change_btn.Enabled = true;
                        remove_btn.Enabled = true;
                    }
                    else
                    {
                        mem_id.Enabled = false;
                        mem_c.Checked = true;
                        mem_name.Text = dr["name"].ToString();
                        mem_dob.Text = dr["dob"].ToString();
                        mem_g.Text = dr["gender"].ToString();
                        mem_h.Text = dr["hight"].ToString();
                        mem_w.Text = dr["weight"].ToString();
                        mem_bg.Text = dr["bg"].ToString();
                        mem_name1.Enabled = true;
                        mem_dob1.Enabled = true;
                        mem_g1.Enabled = true;
                        mem_h1.Enabled = true;
                        mem_w1.Enabled = true;
                        mem_bg1.Enabled = true;
                        mem_name1.Text = dr["name1"].ToString();
                        mem_dob1.Text = dr["dob1"].ToString();
                        mem_g1.Text = dr["gender1"].ToString();
                        mem_h1.Text = dr["hight1"].ToString();
                        mem_w1.Text = dr["weight1"].ToString();
                        mem_bg1.Text = dr["bg1"].ToString();
                        mem_l1.Text = dr["line1"].ToString();
                        mem_l2.Text = dr["line2"].ToString();
                        mem_l3.Text = dr["line3"].ToString();
                        mem_city.Text = dr["city"].ToString();
                        mem_pin.Text = dr["pincode"].ToString();
                        mem_mob.Text = dr["mobile"].ToString();
                        mem_email.Text = dr["email"].ToString();
                        string sms = dr["sendsms"].ToString();
                        if (sms == "Y")
                        {
                            mem_sms.Checked = true;
                        }
                        else
                        {
                            mem_sms.Checked = false;
                        }
                        dr.Close();
                        this.save_btn.Text = "Update";
                        change_btn.Enabled = true;
                        remove_btn.Enabled = true;
                    }
                }
                sc.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void mem_c_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (mem_c.Checked == true)
                {
                    catt = "C";
                }
                memonetrue();
                gend();
                gend1();
                bloodg();
                bloodg1();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void mem_mob_Leave(object sender, EventArgs e)
        {
            try
            {
                if (mem_mob.Text != null && mem_mob.Text.Length != 10)
                {
                    MessageBox.Show("Mobile no should be 10 digit");
                    mem_mob.Focus();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void mem_mob_KeyPress(object sender, KeyPressEventArgs e)
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

        private void mem_email_Leave(object sender, EventArgs e)
        {
            try
            {
                if (mem_email.Text != null && mem_email.Text != string.Empty)
                {
                    string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                     @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                     @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                    Regex re = new Regex(strRegex);
                    if (!re.IsMatch(mem_email.Text))
                    {
                        MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //SendKeys.Send("+{TAB}");
                        mem_email.Focus();
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void mem_sms_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                checkbox_con();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void mem_i_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (mem_i.Checked == true)
                {
                    catt = "I";
                }
                memonefalse();
                gend();
                bloodg();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void savedatai()
        {
            try
            {
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlCommand cmd = new SqlCommand("Insert into member (memberid,cat,name,dob,gender,hight,weight,bg,line1,line2,line3,city,pincode,mobile,email,sendsms) Values ('" + this.mem_id.Text + "','"+catt+"','" + this.mem_name.Text + "','" + this.mem_dob.Text + "','" + this.mem_g.Text + "','" + this.mem_h.Text + "','" + this.mem_w.Text + "','" + this.mem_bg.Text + "','" + this.mem_l1.Text + "','" + this.mem_l2.Text + "','" + this.mem_l3.Text + "','" + this.mem_city.Text + "','" + this.mem_pin.Text + "','" + this.mem_mob.Text + "','" + this.mem_email.Text + "','" + sms + "')", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Record Save Sucessfully");
                sc.Close();
                clearmember();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void savedatac()
        {
            try
            {
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlCommand cmd = new SqlCommand("Insert into member (memberid,cat,name,dob,gender,hight,weight,bg,name1,dob1,gender1,hight1,weight1,bg1,line1,line2,line3,city,pincode,mobile,email,sendsms) Values ('" + this.mem_id.Text + "','" + catt + "','" + this.mem_name.Text + "','" + this.mem_dob.Text + "','" + this.mem_g.Text + "','" + this.mem_h.Text + "','" + this.mem_w.Text + "','" + this.mem_bg.Text + "','" + this.mem_name1.Text + "','" + this.mem_dob1.Text + "','" + this.mem_g1.Text + "','" + this.mem_h1.Text + "','" + this.mem_w1.Text + "','" + this.mem_bg1.Text + "','" + this.mem_l1.Text + "','" + this.mem_l2.Text + "','" + this.mem_l3.Text + "','" + this.mem_city.Text + "','" + this.mem_pin.Text + "','" + this.mem_mob.Text + "','" + this.mem_email.Text + "','" + sms + "')", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Record Save Sucessfully");
                sc.Close();
                clearmember();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void updatedatai()
        {
            try
            {
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlCommand cmd = new SqlCommand("update member set cat='"+catt+"',name='" + this.mem_name.Text + "',dob='" + this.mem_dob.Text + "',gender='" + this.mem_g.Text + "',hight='" + this.mem_h.Text + "',weight='" + this.mem_w.Text + "',bg='" + this.mem_bg.Text + "',line1='" + this.mem_l1.Text + "',line2='" + this.mem_l2.Text + "',line3='" + this.mem_l3.Text + "',city='" + this.mem_city.Text + "',pincode='" + this.mem_pin.Text + "',mobile='" + this.mem_mob.Text + "',email='" + this.mem_email.Text + "',sendsms='" + sms + "' where memberid='" + this.mem_id.Text + "'", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Record Update Sucessfully");
                sc.Close();
                clearmember();
                save_btn.Text = "Save";
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void updatedatac()
        {
            try
            {
                SqlConnection sc = new SqlConnection(d.mainpath);
                SqlCommand cmd = new SqlCommand("update member set cat='" + catt + "',name='" + this.mem_name.Text + "',dob='" + this.mem_dob.Text + "',gender='" + this.mem_g.Text + "',hight='" + this.mem_h.Text + "',weight='" + this.mem_w.Text + "',bg='" + this.mem_bg.Text + "',name1='" + this.mem_name1.Text + "',dob1='" + this.mem_dob1.Text + "',gender1='" + this.mem_g1.Text + "',hight1='" + this.mem_h1.Text + "',weight1='" + this.mem_w1.Text + "',bg1='" + this.mem_bg1.Text + "',line1='" + this.mem_l1.Text + "',line2='" + this.mem_l2.Text + "',line3='" + this.mem_l3.Text + "',city='" + this.mem_city.Text + "',pincode='" + this.mem_pin.Text + "',mobile='" + this.mem_mob.Text + "',email='" + this.mem_email.Text + "',sendsms='" + sms + "' where memberid='" + this.mem_id.Text + "'", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Record Update Sucessfully");
                sc.Close();
                clearmember();
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
                SqlCommand cmd = new SqlCommand("Delete from member where memberid = '" + this.mem_id.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data deleted sucessfully");
                clearmember();
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
                clearmember();
                mem_id.Enabled = true;
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
                    if (mem_i.Checked == true)
                    {
                        if (mem_id.Text == null || mem_id.Text == string.Empty)
                        {
                            MessageBox.Show("Member Id is blank");
                        }
                        else if (mem_name.Text == null || mem_name.Text == string.Empty)
                        {
                            MessageBox.Show("Member Name");
                            mem_name.Focus();
                        }
                        else if (mem_dob.Text == null || mem_dob.Text == string.Empty)
                        {
                            MessageBox.Show("Member DOB");
                            mem_dob.Focus();
                        }
                        else if (mem_mob.Text == null || mem_mob.Text == string.Empty)
                        {
                            MessageBox.Show("Member Mobile");
                            mem_mob.Focus();
                        }
                        else
                        {
                            updatedatai();
                        }
                    }
                    else if (mem_c.Checked == true)
                    {
                        if (mem_id.Text == null || mem_id.Text == string.Empty)
                        {
                            MessageBox.Show("Member Id is blank");
                        }
                        else if (mem_name.Text == null || mem_name.Text == string.Empty)
                        {
                            MessageBox.Show("Member Name");
                            mem_name.Focus();
                        }
                        else if (mem_dob.Text == null || mem_dob.Text == string.Empty)
                        {
                            MessageBox.Show("Member DOB");
                            mem_dob.Focus();
                        }
                        else if (mem_mob.Text == null || mem_mob.Text == string.Empty)
                        {
                            MessageBox.Show("Member Mobile");
                            mem_mob.Focus();
                        }
                        else if(mem_name1.Text==null || mem_name1.Text==string.Empty)
                        {
                            MessageBox.Show("Second Member Name");
                            mem_name1.Focus();
                        }
                        else if (mem_dob1.Text == null || mem_dob1.Text == string.Empty)
                        {
                            MessageBox.Show("Second Member DOB");
                            mem_dob1.Focus();
                        }
                        else
                        {
                            updatedatac();
                        }
                    }
                }
                else
                {
                    if (mem_i.Checked == true)
                    {
                        if (mem_id.Text == null || mem_id.Text == string.Empty)
                        {
                            MessageBox.Show("Member Id is blank");
                        }
                        else if (mem_name.Text == null || mem_name.Text == string.Empty)
                        {
                            MessageBox.Show("Member Name");
                            mem_name.Focus();
                        }
                        else if (mem_dob.Text == null || mem_dob.Text == string.Empty)
                        {
                            MessageBox.Show("Member DOB");
                            mem_dob.Focus();
                        }
                        else if (mem_mob.Text == null || mem_mob.Text == string.Empty)
                        {
                            MessageBox.Show("Member Mobile");
                            mem_mob.Focus();
                        }
                        else
                        {
                            savedatai();
                        }
                    }
                    else if (mem_c.Checked == true)
                    {
                        if (mem_id.Text == null || mem_id.Text == string.Empty)
                        {
                            MessageBox.Show("Member Id is blank");
                        }
                        else if (mem_name.Text == null || mem_name.Text == string.Empty)
                        {
                            MessageBox.Show("Member Name");
                            mem_name.Focus();
                        }
                        else if (mem_dob.Text == null || mem_dob.Text == string.Empty)
                        {
                            MessageBox.Show("Member DOB");
                            mem_dob.Focus();
                        }
                        else if (mem_mob.Text == null || mem_mob.Text == string.Empty)
                        {
                            MessageBox.Show("Member Mobile");
                            mem_mob.Focus();
                        }
                        else if (mem_name1.Text == null || mem_name1.Text == string.Empty)
                        {
                            MessageBox.Show("Second Member Name");
                            mem_name1.Focus();
                        }
                        else if (mem_dob1.Text == null || mem_dob1.Text == string.Empty)
                        {
                            MessageBox.Show("Second Member DOB");
                            mem_dob1.Focus();
                        }
                        else
                        {
                            savedatac();
                        }
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
                mem_id.Enabled = false;
                mem_name.Focus();
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
