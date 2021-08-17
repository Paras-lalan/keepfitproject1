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
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
            receipt();
            memberdetail();
        }
        datapath d = new datapath();
        string c,p,t,pp;

        public void discount()
        {
            int A, B, C, D,E,F;
            A = Convert.ToInt32(totalamount.Text);
            B = Convert.ToInt32(dis.Text);
            C = A * B / 100;
            disamt.Text = c.ToString();
            D = Convert.ToInt32(pt_amt.Text);
            E = A - C;
            F = D + E;
            final_amt.Text = F.ToString();
        }

        public void balance()
        {
            int A, B, C;
            A = Convert.ToInt32(final_amt.Text);
            B = Convert.ToInt32(amtpaid.Text);
            C = A - B;
            bal.Text = C.ToString();
        }
        public void receipt()
        {
            string Id;
            SqlDataAdapter sda = new SqlDataAdapter("select max(receiptno)+1 from fees", d.mainpath);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Id = dt.Rows[0][0].ToString();
            recpt.Text = Id;
        }

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
            sc.Close();
        }

        public void categ()
        {
            SqlConnection sc = new SqlConnection(d.mainpath);
            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select cat_nm from category", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cat.DataSource = dt;
            cat.DisplayMember = "cat_nm";
            cat.ValueMember = "cat_nm";
            cat.SelectedIndex = -1;
        }

        public void perio()
        {
            SqlConnection sc = new SqlConnection(d.mainpath);
            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select period from period", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            period.DataSource = dt;
            period.DisplayMember = "period";
            period.ValueMember = "period";
            period.SelectedIndex = -1;
        }

        public void trainerdetail()
        {
            SqlConnection sc = new SqlConnection(d.mainpath);
            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select trainername from trainer", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            train_nm.DataSource = dt;
            train_nm.DisplayMember = "trainername";
            train_nm.ValueMember = "trainername";
            train_nm.SelectedIndex = -1;
        }

        public void pperio()
        {
            SqlConnection sc = new SqlConnection(d.mainpath);
            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select period from period", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            pperiod.DataSource = dt;
            pperiod.DisplayMember = "period";
            pperiod.ValueMember = "period";
            pperiod.SelectedIndex = -1;
        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                train_nm.SelectedIndex = -1;
                train_nm.Enabled = false;
                pperiod.SelectedIndex = -1;
                pperiod.Enabled = false;
                ptfd.Enabled = false;
                pttd.Enabled = false;
                ptamt.Enabled = false;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void yes_CheckedChanged(object sender, EventArgs e)
        {
            train_nm.Enabled = true;
            trainerdetail();
            pperiod.Enabled = true;
            pperio();
            ptfd.Enabled = true;
            pttd.Enabled = true;
            ptamt.Enabled = true;
        }

        private void cash_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                bank_nm.SelectedIndex = -1;
                branch.Clear();
                chqno.Clear();
                trans_id.Clear();

                bank_nm.Enabled = false;
                branch.Enabled = false;
                chqno.Enabled = false;
                chqdt.Enabled = false;
                trans_id.Enabled = false;
                dis.Focus();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void cheque_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                bank_nm.Enabled = true;
                branch.Enabled = true;
                chqno.Enabled = true;
                chqdt.Enabled = true;
                trans_id.Enabled = false;
                trans_id.Clear();
                bank_nm.Focus();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void online_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                bank_nm.SelectedIndex = -1;
                branch.Clear();
                chqno.Clear();
                
                bank_nm.Enabled = false;
                branch.Enabled = false;
                chqno.Enabled = false;
                chqdt.Enabled = false;
                trans_id.Enabled = true;
                trans_id.Focus();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void recpt_Leave(object sender, EventArgs e)
        {
            try
            {
                String query = "select fees.date, fees.receiptno, fees.memberid,member.name,fees.cate,fees.period,fees.fromdate,fees.todate,fees.amt,fees.pt,fees.trainerid,fees.periodid,fees.tfromdate,fees.ttodate,fees.tamount,fees.paymentmode,fees.bank,fees.branch,fees.chqno,fees.cdate,fees.transactionid,fees.totalamt,fees.discount,fees.discountamt,fees.ptamt,fees.finalamt,fees.amountpaid,fees.balance from fees  INNER JOIN member on fees.memberid  = member.memberid WHERE receiptno='" + this.recpt.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    fdate.Text = dr["date"].ToString();
                    mem_id.Text = dr["memberid"].ToString();
                    mem_nm.Text = dr["name"].ToString();
                    cat.Text = dr["cate"].ToString();
                    period.Text = dr["period"].ToString();
                    pfd.Text = dr["fromdate"].ToString();
                    ptd.Text = dr["todate"].ToString();
                    pamt.Text = dr["amt"].ToString();
                    string ptv = dr["pt"].ToString();
                    if (ptv == "No")
                    {
                        no.Checked = true;
                        train_nm.Enabled = false;
                        pperiod.Enabled = false;
                        ptfd.Enabled = false;
                        pttd.Enabled = false;
                        ptamt.Enabled = false;
                    }
                    else if (ptv == "Yes")
                    {
                        yes.Checked = true;
                        train_nm.Enabled = true;
                        pperiod.Enabled = true;
                        ptfd.Enabled = true;
                        pttd.Enabled = true;
                        ptamt.Enabled = true;
                        train_nm.Text = dr["trainerid"].ToString();
                        pperiod.Text = dr["periodid"].ToString();
                        ptfd.Text = dr["tfromdate"].ToString();
                        pttd.Text = dr["ttodate"].ToString();
                        ptamt.Text = dr["tamount"].ToString();
                    }
                    string payment = dr["paymentmode"].ToString();
                    if (payment == "Cash")
                    {
                        cash.Checked = true;
                        bank_nm.Enabled = false;
                        branch.Enabled = false;
                        chqno.Enabled = false;
                        chqdt.Enabled = false;
                        trans_id.Enabled = false;
                    }
                    else if (payment == "Cheque")
                    {
                        cheque.Checked = true;
                        bank_nm.Enabled = true;
                        branch.Enabled = true;
                        chqno.Enabled = true;
                        chqdt.Enabled = true;
                        trans_id.Enabled = false;
                        bank_nm.Text = dr["bank"].ToString();
                        branch.Text = dr["branch"].ToString();
                        chqno.Text = dr["chqno"].ToString();
                        chqdt.Text = dr["cdate"].ToString();
                    }
                    else if (payment == "Online")
                    {
                        online.Checked = true;
                        bank_nm.Enabled = false;
                        branch.Enabled = false;
                        chqno.Enabled = false;
                        chqdt.Enabled = false;
                        trans_id.Enabled = true;
                        trans_id.Text = dr["transactionid"].ToString();
                    }
                    totalamount.Text = dr["totalamt"].ToString();
                    dis.Text = dr["discount"].ToString();
                    disamt.Text = dr["discountamt"].ToString();
                    pt_amt.Text = dr["ptamt"].ToString();
                    final_amt.Text = dr["finalamt"].ToString();
                    amtpaid.Text = dr["amountpaid"].ToString();
                    bal.Text = dr["balance"].ToString();
                    dr.Close();
                }
                sc.Close();
                this.save_btn.Text = "Update";
                change_btn.Enabled = true;
                remove_btn.Enabled = true;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void mem_id_Leave(object sender, EventArgs e)
        {
            try
            {
                String query = "Select name from member where memberid='" + this.mem_id.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    mem_nm.Text = dr["name"].ToString();
                    dr.Close();
                }
                sc.Close();
                categ();
                perio();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void mem_nm_Leave(object sender, EventArgs e)
        {
            try
            {
                String query = "Select memberid from member where name='" + this.mem_nm.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    mem_id.Text = dr["memberid"].ToString();
                    dr.Close();
                }
                sc.Close();
                categ();
                perio();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void clearfees()
        {
            try
            {
                recpt.Clear();
                mem_id.SelectedIndex = -1;
                mem_id.Text = "";
                mem_nm.SelectedIndex = -1;
                mem_nm.Text = "";
                cat.SelectedIndex = -1;
                cat.Text = "";
                period.SelectedIndex = -1;
                period.Text = "";
                pamt.Clear();
                train_nm.SelectedIndex = -1;
                train_nm.Text = "";
                pperiod.SelectedIndex = -1;
                pperiod.Text = "";
                ptamt.Clear();
                bank_nm.SelectedIndex = -1;
                bank_nm.Text = "";
                branch.Clear();
                chqno.Clear();
                trans_id.Clear();
                totalamount.Clear();
                dis.Clear();
                disamt.Clear();
                pt_amt.Clear();
                final_amt.Clear();
                amtpaid.Clear();
                bal.Clear();
                train_nm.Enabled = false;
                pperiod.Enabled = false;
                ptfd.Enabled = false;
                pttd.Enabled = false;
                ptamt.Enabled = false;
                bank_nm.Enabled = false;
                branch.Enabled = false;
                chqdt.Enabled = false;
                chqno.Enabled = false;
                trans_id.Enabled = false;
                no.Checked = true;
                cash.Checked = true;
                recpt.Enabled = true;
                receipt();
                save_btn.Text = "Save";
                change_btn.Enabled = false;
                remove_btn.Enabled = false;
                recpt.Focus();
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
                if (no.Checked == true)
                {
                    if (cash.Checked == true)
                    {
                        SqlConnection sc = new SqlConnection(d.mainpath);
                        SqlCommand cmd = new SqlCommand("Insert into fees (date,receiptno,memberid,cate,period,fromdate,todate,amt,pt,paymentmode,totalamt,discount,discountamt,ptamt,finalamt,amountpaid,balance) Values ('"+this.fdate.Text+"','"+this.recpt.Text+"','"+this.mem_id+"','"+this.cat.Text+"','"+this.period.Text+"','"+this.pfd.Text+"','"+this.ptd.Text+"','"+this.pamt.Text+"','No','Cash','"+this.totalamount.Text+"','"+this.dis.Text+"','"+this.disamt.Text+"','"+pt_amt.Text+"','"+this.final_amt.Text+"','"+this.amtpaid.Text+"','"+this.bal.Text+"')", sc);
                        sc.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Save Sucessfully");
                        sc.Close();
                        clearfees();
                    }
                    else if (cheque.Checked == true)
                    {
                        if (bank_nm.Text == null || bank_nm.Text == string.Empty)
                        {
                            MessageBox.Show("Select Bank");
                            bank_nm.Focus();
                        }
                        else if (branch.Text == null || branch.Text == string.Empty)
                        {
                            MessageBox.Show("Branch");
                            branch.Focus();
                        }
                        else if (chqno.Text == null || chqno.Text == string.Empty)
                        {
                            MessageBox.Show("Cheque No");
                            chqno.Focus();
                        }
                        else
                        {
                            SqlConnection sc = new SqlConnection(d.mainpath);
                            SqlCommand cmd = new SqlCommand("Insert into fees (date,receiptno,memberid,cate,period,fromdate,todate,amt,pt,paymentmode,bank,branch,chqno,cdate,totalamt,discount,discountamt,ptamt,finalamt,amountpaid,balance) Values ('" + this.fdate.Text + "','" + this.recpt.Text + "','" + this.mem_id + "','" + this.cat.Text + "','" + this.period.Text + "','" + this.pfd.Text + "','" + this.ptd.Text + "','" + this.pamt.Text + "','No','Cheque','" + this.bank_nm.Text + "','" + this.branch.Text + "','" + this.chqno.Text + "','" + this.chqdt.Text + "','" + this.totalamount.Text + "','" + this.dis.Text + "','" + this.disamt.Text + "','" + pt_amt.Text + "','" + this.final_amt.Text + "','" + this.amtpaid.Text + "','" + this.bal.Text + "')", sc);
                            sc.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Save Sucessfully");
                            sc.Close();
                            clearfees();
                        }
                    }
                    else if (online.Checked == true)
                    {
                        if (trans_id.Text == null || trans_id.Text == string.Empty)
                        {
                            MessageBox.Show("Transaction ID Please");
                            trans_id.Focus();
                        }
                        else
                        {
                            SqlConnection sc = new SqlConnection(d.mainpath);
                            SqlCommand cmd = new SqlCommand("Insert into fees (date,receiptno,memberid,cate,period,fromdate,todate,amt,pt,paymentmode,transactionid,totalamt,discount,discountamt,ptamt,finalamt,amountpaid,balance) Values ('" + this.fdate.Text + "','" + this.recpt.Text + "','" + this.mem_id + "','" + this.cat.Text + "','" + this.period.Text + "','" + this.pfd.Text + "','" + this.ptd.Text + "','" + this.pamt.Text + "','No','Online','" + this.trans_id.Text + "','" + this.totalamount.Text + "','" + this.dis.Text + "','" + this.disamt.Text + "','" + pt_amt.Text + "','" + this.final_amt.Text + "','" + this.amtpaid.Text + "','" + this.bal.Text + "')", sc);
                            sc.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Save Sucessfully");
                            sc.Close();
                            clearfees();
                        }
                    }
                }
                else if (yes.Checked == true)
                {
                    if (train_nm.Text == null || train_nm.Text == string.Empty)
                    {
                        MessageBox.Show("Trainer Name");
                        train_nm.Focus();
                    }
                    else if (pperiod.Text == null || pperiod.Text == string.Empty)
                    {
                        MessageBox.Show("Period");
                        pperiod.Focus();
                    }
                    else if (ptamt.Text == null || ptamt.Text == string.Empty)
                    {
                        MessageBox.Show("PT Amount");
                        ptamt.Focus();
                    }
                    else
                    {
                        if (cash.Checked == true)
                        {
                            SqlConnection sc = new SqlConnection(d.mainpath);
                            SqlCommand cmd = new SqlCommand("Insert into fees (date,receiptno,memberid,cate,period,fromdate,todate,amt,pt,trainerid,periodid,tfromdate,ttodate,tamount,trainerid,periodid,tfromdate,ttodate,tamount,paymentmode,totalamt,discount,discountamt,ptamt,finalamt,amountpaid,balance) Values ('" + this.fdate.Text + "','" + this.recpt.Text + "','" + this.mem_id + "','" + this.cat.Text + "','" + this.period.Text + "','" + this.pfd.Text + "','" + this.ptd.Text + "','" + this.pamt.Text + "','Yes','"+this.train_nm.Text+"','"+this.pperiod.Text+"','"+this.ptfd.Text+"','"+this.pttd.Text+"','"+this.ptamt.Text+"','Cash','" + this.totalamount.Text + "','" + this.dis.Text + "','" + this.disamt.Text + "','" + pt_amt.Text + "','" + this.final_amt.Text + "','" + this.amtpaid.Text + "','" + this.bal.Text + "')", sc);
                            sc.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Save Sucessfully");
                            sc.Close();
                            clearfees();
                        }
                        else if (cheque.Checked == true)
                        {
                            if (bank_nm.Text == null || bank_nm.Text == string.Empty)
                            {
                                MessageBox.Show("Select Bank");
                                bank_nm.Focus();
                            }
                            else if (branch.Text == null || branch.Text == string.Empty)
                            {
                                MessageBox.Show("Branch");
                                branch.Focus();
                            }
                            else if (chqno.Text == null || chqno.Text == string.Empty)
                            {
                                MessageBox.Show("Cheque No");
                                chqno.Focus();
                            }
                            else
                            {
                                SqlConnection sc = new SqlConnection(d.mainpath);
                                SqlCommand cmd = new SqlCommand("Insert into fees (date,receiptno,memberid,cate,period,fromdate,todate,amt,pt,trainerid,periodid,tfromdate,ttodate,tamount,paymentmode,bank,branch,chqno,cdate,totalamt,discount,discountamt,ptamt,finalamt,amountpaid,balance) Values ('" + this.fdate.Text + "','" + this.recpt.Text + "','" + this.mem_id + "','" + this.cat.Text + "','" + this.period.Text + "','" + this.pfd.Text + "','" + this.ptd.Text + "','" + this.pamt.Text + "','Yes','" + this.train_nm.Text + "','" + this.pperiod.Text + "','" + this.ptfd.Text + "','" + this.pttd.Text + "','" + this.ptamt.Text + "','Cheque','" + this.bank_nm.Text + "','" + this.branch.Text + "','" + this.chqno.Text + "','" + this.chqdt.Text + "','" + this.totalamount.Text + "','" + this.dis.Text + "','" + this.disamt.Text + "','" + pt_amt.Text + "','" + this.final_amt.Text + "','" + this.amtpaid.Text + "','" + this.bal.Text + "')", sc);
                                sc.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Save Sucessfully");
                                sc.Close();
                                clearfees();
                            }
                        }
                        else if (online.Checked == true)
                        {
                            if (trans_id.Text == null || trans_id.Text == string.Empty)
                            {
                                MessageBox.Show("Transaction ID Please");
                                trans_id.Focus();
                            }
                            else
                            {
                                SqlConnection sc = new SqlConnection(d.mainpath);
                                SqlCommand cmd = new SqlCommand("Insert into fees (date,receiptno,memberid,cate,period,fromdate,todate,amt,pt,trainerid,periodid,tfromdate,ttodate,tamount,paymentmode,transactionid,totalamt,discount,discountamt,ptamt,finalamt,amountpaid,balance) Values ('" + this.fdate.Text + "','" + this.recpt.Text + "','" + this.mem_id + "','" + this.cat.Text + "','" + this.period.Text + "','" + this.pfd.Text + "','" + this.ptd.Text + "','" + this.pamt.Text + "','Yes','" + this.train_nm.Text + "','" + this.pperiod.Text + "','" + this.ptfd.Text + "','" + this.pttd.Text + "','" + this.ptamt.Text + "','Online','" + this.trans_id.Text + "','" + this.totalamount.Text + "','" + this.dis.Text + "','" + this.disamt.Text + "','" + pt_amt.Text + "','" + this.final_amt.Text + "','" + this.amtpaid.Text + "','" + this.bal.Text + "')", sc);
                                sc.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Save Sucessfully");
                                sc.Close();
                                clearfees();
                            }
                        }
                    }
                }
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
                if (no.Checked == true)
                {
                    if (cash.Checked == true)
                    {
                        SqlConnection sc = new SqlConnection(d.mainpath);
                        SqlCommand cmd = new SqlCommand("update fees set date='" + this.fdate.Text + "',memberid='" + this.mem_id + "',cate='" + this.cat.Text + "',period='" + this.period.Text + "',fromdate='" + this.pfd.Text + "',todate='" + this.ptd.Text + "',amt='" + this.pamt.Text + "',pt = 'No', paymentmode = 'Cash', totalamt = '" + this.totalamount.Text + "', discount = '" + this.dis.Text + "', discountamt = '" + this.disamt.Text + "', ptamt = '" + pt_amt.Text + "', finalamt = '" + this.final_amt.Text + "', amountpaid = '" + this.amtpaid.Text + "', balance = '" + this.bal.Text + "' where receiptno='" + this.recpt.Text + "'", sc);
                        sc.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Update Sucessfully");
                        sc.Close();
                        clearfees();
                    }
                    else if (cheque.Checked == true)
                    {
                        if (bank_nm.Text == null || bank_nm.Text == string.Empty)
                        {
                            MessageBox.Show("Select Bank");
                            bank_nm.Focus();
                        }
                        else if (branch.Text == null || branch.Text == string.Empty)
                        {
                            MessageBox.Show("Branch");
                            branch.Focus();
                        }
                        else if (chqno.Text == null || chqno.Text == string.Empty)
                        {
                            MessageBox.Show("Cheque No");
                            chqno.Focus();
                        }
                        else
                        {
                            SqlConnection sc = new SqlConnection(d.mainpath);
                            SqlCommand cmd = new SqlCommand("update fees set date='" + this.fdate.Text + "',memberid='" + this.mem_id + "',cate='" + this.cat.Text + "',period='" + this.period.Text + "',fromdate='" + this.pfd.Text + "',todate='" + this.ptd.Text + "',amt='" + this.pamt.Text + "',pt = 'No', paymentmode = 'Cheque', bank = '" + this.bank_nm.Text + "', branch = '" + this.branch.Text + "', chqno = '" + this.chqno.Text + "', cdate = '" + this.chqdt.Text + "', totalamt = '" + this.totalamount.Text + "', discount = '" + this.dis.Text + "', discountamt = '" + this.disamt.Text + "', ptamt = '" + pt_amt.Text + "', finalamt = '" + this.final_amt.Text + "', amountpaid = '" + this.amtpaid.Text + "', balance = '" + this.bal.Text + "' where receiptno ='" + this.recpt.Text + "'", sc);
                            sc.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Update Sucessfully");
                            sc.Close();
                            clearfees();
                        }
                    }
                    else if (online.Checked == true)
                    {
                        if (trans_id.Text == null || trans_id.Text == string.Empty)
                        {
                            MessageBox.Show("Transaction ID Please");
                            trans_id.Focus();
                        }
                        else
                        {
                            SqlConnection sc = new SqlConnection(d.mainpath);
                            SqlCommand cmd = new SqlCommand("update fees set date='" + this.fdate.Text + "',memberid='" + this.mem_id + "',cate='" + this.cat.Text + "',period='" + this.period.Text + "',fromdate='" + this.pfd.Text + "',todate='" + this.ptd.Text + "',amt='" + this.pamt.Text + "',pt = 'No', paymentmode = 'Online', transactionid = '"+this.trans_id.Text+"',totalamt = '" + this.totalamount.Text + "', discount = '" + this.dis.Text + "', discountamt = '" + this.disamt.Text + "', ptamt = '" + pt_amt.Text + "', finalamt = '" + this.final_amt.Text + "', amountpaid = '" + this.amtpaid.Text + "', balance = '" + this.bal.Text + "' where receiptno='" + this.recpt.Text + "'", sc);
                            sc.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Update Sucessfully");
                            sc.Close();
                            clearfees();
                        }
                    }
                }
                else if (yes.Checked == true)
                {
                    if (train_nm.Text == null || train_nm.Text == string.Empty)
                    {
                        MessageBox.Show("Trainer Name");
                        train_nm.Focus();
                    }
                    else if (pperiod.Text == null || pperiod.Text == string.Empty)
                    {
                        MessageBox.Show("Period");
                        pperiod.Focus();
                    }
                    else if (ptamt.Text == null || ptamt.Text == string.Empty)
                    {
                        MessageBox.Show("PT Amount");
                        ptamt.Focus();
                    }
                    else
                    {
                        if (cash.Checked == true)
                        {
                            SqlConnection sc = new SqlConnection(d.mainpath);
                            SqlCommand cmd = new SqlCommand("update fees set date='" + this.fdate.Text + "',memberid='" + this.mem_id + "',cate='" + this.cat.Text + "',period='" + this.period.Text + "',fromdate='" + this.pfd.Text + "',todate='" + this.ptd.Text + "',amt='" + this.pamt.Text + "',pt = 'Yes', trainerid = '"+this.train_nm.Text+"', periodid = '"+this.pperiod.Text+"', tfromdate = '"+this.ptfd.Text+"', ttodate = '"+this.pttd.Text+"', tamount = '"+this.ptamt.Text+"', paymentmode = 'Cash', totalamt = '" + this.totalamount.Text + "', discount = '" + this.dis.Text + "', discountamt = '" + this.disamt.Text + "', ptamt = '" + pt_amt.Text + "', finalamt = '" + this.final_amt.Text + "', amountpaid = '" + this.amtpaid.Text + "', balance = '" + this.bal.Text + "'  where receiptno ='" + this.recpt.Text + "'", sc);
                            sc.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Update Sucessfully");
                            sc.Close();
                            clearfees();
                        }
                        else if (cheque.Checked == true)
                        {
                            if (bank_nm.Text == null || bank_nm.Text == string.Empty)
                            {
                                MessageBox.Show("Select Bank");
                                bank_nm.Focus();
                            }
                            else if (branch.Text == null || branch.Text == string.Empty)
                            {
                                MessageBox.Show("Branch");
                                branch.Focus();
                            }
                            else if (chqno.Text == null || chqno.Text == string.Empty)
                            {
                                MessageBox.Show("Cheque No");
                                chqno.Focus();
                            }
                            else
                            {
                                SqlConnection sc = new SqlConnection(d.mainpath);
                                SqlCommand cmd = new SqlCommand("update fees set  date='" + this.fdate.Text + "',memberid='" + this.mem_id + "',cate='" + this.cat.Text + "',period='" + this.period.Text + "',fromdate='" + this.pfd.Text + "',todate='" + this.ptd.Text + "',amt='" + this.pamt.Text + "',pt = 'Yes', trainerid = '"+this.train_nm.Text+"', periodid = '"+this.pperiod.Text+"', tfromdate = '"+this.ptfd.Text+"', ttodate = '"+this.pttd.Text+"', tamount = '"+this.ptamt.Text+"', paymentmode = 'Cheque', bank = '" + this.bank_nm.Text + "', branch = '" + this.branch.Text + "', chqno = '" + this.chqno.Text + "', cdate = '" + this.chqdt.Text + "', totalamt = '" + this.totalamount.Text + "', discount = '" + this.dis.Text + "', discountamt = '" + this.disamt.Text + "', ptamt = '" + pt_amt.Text + "', finalamt = '" + this.final_amt.Text + "', amountpaid = '" + this.amtpaid.Text + "', balance = '" + this.bal.Text + "' where receiptno='" + this.recpt.Text + "'", sc);
                                sc.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Update Sucessfully");
                                sc.Close();
                                clearfees();
                            }
                        }
                        else if (online.Checked == true)
                        {
                            if (trans_id.Text == null || trans_id.Text == string.Empty)
                            {
                                MessageBox.Show("Transaction ID Please");
                                trans_id.Focus();
                            }
                            else
                            {
                                SqlConnection sc = new SqlConnection(d.mainpath);
                                SqlCommand cmd = new SqlCommand("update fees set  date='" + this.fdate.Text + "',memberid='" + this.mem_id + "',cate='" + this.cat.Text + "',period='" + this.period.Text + "',fromdate='" + this.pfd.Text + "',todate='" + this.ptd.Text + "',amt='" + this.pamt.Text + "',pt = 'Yes', trainerid = '"+this.train_nm.Text+"', periodid = '"+this.pperiod.Text+"', tfromdate = '"+this.ptfd.Text+"', ttodate = '"+this.pttd.Text+"', tamount = '"+this.ptamt.Text+"', paymentmode = 'Online', transactionid = '"+this.trans_id.Text+"',totalamt = '" + this.totalamount.Text + "', discount = '" + this.dis.Text + "', discountamt = '" + this.disamt.Text + "', ptamt = '" + pt_amt.Text + "', finalamt = '" + this.final_amt.Text + "', amountpaid = '" + this.amtpaid.Text + "', balance = '" + this.bal.Text + "' where receiptno='" + this.recpt.Text + "'", sc);
                                sc.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Update Sucessfully");
                                sc.Close();
                                clearfees();
                            }
                        }
                    }
                }
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
                recpt.Enabled = false;
                mem_id.Focus();
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
                SqlCommand cmd = new SqlCommand("Delete from fees where receiptno = '" + this.recpt.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data deleted sucessfully");
                clearfees();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void avoiddata()
        {
            clearfees();
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

        public void amount()
        {
            try
            {
                String query = "Select pac_amt from package where pac_cat='" + c + "' AND pac_month='"+p+"'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    pamt.Text = dr["pac_amt"].ToString();
                    totalamount.Text = dr["pac_amt"].ToString();
                    dr.Close();
                }
                sc.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void cat_Leave(object sender, EventArgs e)
        {
            try
            {
                String query = "Select cat_cd from category where cat_nm='" + this.cat.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    c = dr["cat_cd"].ToString();
                    dr.Close();
                }
                sc.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void period_Leave(object sender, EventArgs e)
        {
            try
            {
                String query = "Select p_id from period where period='" + this.period.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    p = dr["p_id"].ToString();
                    dr.Close();
                }
                sc.Close();
                amount();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void train_nm_Leave(object sender, EventArgs e)
        {
            try
            {
                String query = "Select trainerid from trainer where trainername='" + this.train_nm.Text + "'";
                SqlConnection sc = new SqlConnection(d.mainpath);
                sc.Open();
                SqlCommand Cmd = new SqlCommand(query, sc);
                SqlDataReader dr;
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    t = dr["trainerid"].ToString();
                    dr.Close();
                }
                sc.Close();
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
