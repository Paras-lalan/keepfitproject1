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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        datapath d = new datapath();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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
                if (!(textBox1.Text == string.Empty))
                {
                    if (!(textBox2.Text == string.Empty))
                    {
                        SqlConnection con = new SqlConnection(d.mainpath);
                        SqlDataAdapter sda = new SqlDataAdapter("Select Role from Login where Username = '" + textBox1.Text + "'and Password = '" + this.textBox2.Text + "'", con);
                        DataTable dt = new System.Data.DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            this.Hide();
                            Keepfit2 main = new Keepfit2();
                            main.Show();
                        }
                        else if (dt.Rows.Count > 1)
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
                else
                {
                    MessageBox.Show(" username empty", "login page");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
