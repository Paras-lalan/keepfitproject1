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
    public partial class changepassword : Form
    {
        public changepassword()
        {
            InitializeComponent();
        }
        datapath d = new datapath();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (un.Text == null || un.Text == string.Empty)
                {
                    MessageBox.Show("Enter your User Id");
                    un.Focus();
                }
                else if (op.Text == null || op.Text == string.Empty)
                {
                    MessageBox.Show("Enter your old password");
                    op.Focus();
                }
                else if (np.Text == null || np.Text == string.Empty)
                {
                    MessageBox.Show("Enter your new password");
                    np.Focus();
                }
                else if (np.Text != null)
                {
                    try
                    {

                        SqlConnection sc = new SqlConnection(d.mainpath);
                        SqlCommand cmd = new SqlCommand("update Login set Password='" + this.np.Text + "' where Username='" + this.un.Text + "'", sc);
                        sc.Open();
                        cmd.ExecuteNonQuery();
                        cmd.ExecuteReader();
                        MessageBox.Show("Password Change Successfully");
                        np.Enabled = false;
                        np.Clear();
                        op.Clear();
                        un.Clear();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void op_Leave(object sender, EventArgs e)
        {
            try
            {
                if (op.Text == null || op.Text == string.Empty)
                {
                    MessageBox.Show("Enter Old Password ");
                    op.Focus();
                }
                else if (!(un.Text == string.Empty))
                {
                    if (!(op.Text == string.Empty))
                    {
                        String str = d.mainpath;
                        String query = "select * from Login where Username = '" + this.un.Text + "'and Password = '" + this.op.Text + "'";
                        SqlConnection con = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader dbr;
                        con.Open();
                        dbr = cmd.ExecuteReader();
                        int count = 0;
                        if (dbr.HasRows)
                        {
                            np.Enabled = true;
                            np.Focus();

                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");
                        }
                        else
                        {
                            MessageBox.Show(" username or password incorrect", "login page");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" password empty", "login page");
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void np_Leave(object sender, EventArgs e)
        {
            try
            {
                if (np.Text == null || np.Text == string.Empty)
                {
                    MessageBox.Show("Enter your New Password");
                    np.Focus();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
 }

