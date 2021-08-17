namespace keepfit2._1._2
{
    partial class member
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(member));
            this.label1 = new System.Windows.Forms.Label();
            this.mem_id = new System.Windows.Forms.TextBox();
            this.mem_i = new System.Windows.Forms.RadioButton();
            this.mem_c = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mem_bg1 = new System.Windows.Forms.ComboBox();
            this.mem_w1 = new System.Windows.Forms.TextBox();
            this.mem_h1 = new System.Windows.Forms.TextBox();
            this.mem_g1 = new System.Windows.Forms.ComboBox();
            this.mem_dob1 = new System.Windows.Forms.DateTimePicker();
            this.mem_name1 = new System.Windows.Forms.TextBox();
            this.mem_bg = new System.Windows.Forms.ComboBox();
            this.mem_w = new System.Windows.Forms.TextBox();
            this.mem_h = new System.Windows.Forms.TextBox();
            this.mem_g = new System.Windows.Forms.ComboBox();
            this.mem_dob = new System.Windows.Forms.DateTimePicker();
            this.mem_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mem_l1 = new System.Windows.Forms.TextBox();
            this.mem_l2 = new System.Windows.Forms.TextBox();
            this.mem_l3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mem_city = new System.Windows.Forms.TextBox();
            this.mem_pin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mem_mob = new System.Windows.Forms.TextBox();
            this.mem_sms = new System.Windows.Forms.CheckBox();
            this.mem_email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.avoid_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.change_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID";
            // 
            // mem_id
            // 
            this.mem_id.Location = new System.Drawing.Point(89, 14);
            this.mem_id.Name = "mem_id";
            this.mem_id.Size = new System.Drawing.Size(100, 22);
            this.mem_id.TabIndex = 1;
            this.mem_id.Leave += new System.EventHandler(this.mem_id_Leave);
            // 
            // mem_i
            // 
            this.mem_i.AutoSize = true;
            this.mem_i.Location = new System.Drawing.Point(278, 16);
            this.mem_i.Name = "mem_i";
            this.mem_i.Size = new System.Drawing.Size(91, 19);
            this.mem_i.TabIndex = 2;
            this.mem_i.TabStop = true;
            this.mem_i.Text = "Individual ";
            this.mem_i.UseVisualStyleBackColor = true;
            this.mem_i.CheckedChanged += new System.EventHandler(this.mem_i_CheckedChanged);
            // 
            // mem_c
            // 
            this.mem_c.AutoSize = true;
            this.mem_c.Location = new System.Drawing.Point(375, 16);
            this.mem_c.Name = "mem_c";
            this.mem_c.Size = new System.Drawing.Size(68, 19);
            this.mem_c.TabIndex = 3;
            this.mem_c.TabStop = true;
            this.mem_c.Text = "Couple";
            this.mem_c.UseVisualStyleBackColor = true;
            this.mem_c.CheckedChanged += new System.EventHandler(this.mem_c_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.mem_id);
            this.groupBox2.Controls.Add(this.mem_c);
            this.groupBox2.Controls.Add(this.mem_i);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 45);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mem_bg1);
            this.groupBox1.Controls.Add(this.mem_w1);
            this.groupBox1.Controls.Add(this.mem_h1);
            this.groupBox1.Controls.Add(this.mem_g1);
            this.groupBox1.Controls.Add(this.mem_dob1);
            this.groupBox1.Controls.Add(this.mem_name1);
            this.groupBox1.Controls.Add(this.mem_bg);
            this.groupBox1.Controls.Add(this.mem_w);
            this.groupBox1.Controls.Add(this.mem_h);
            this.groupBox1.Controls.Add(this.mem_g);
            this.groupBox1.Controls.Add(this.mem_dob);
            this.groupBox1.Controls.Add(this.mem_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // mem_bg1
            // 
            this.mem_bg1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mem_bg1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mem_bg1.Enabled = false;
            this.mem_bg1.FormattingEnabled = true;
            this.mem_bg1.Location = new System.Drawing.Point(501, 61);
            this.mem_bg1.Name = "mem_bg1";
            this.mem_bg1.Size = new System.Drawing.Size(84, 23);
            this.mem_bg1.TabIndex = 38;
            // 
            // mem_w1
            // 
            this.mem_w1.Enabled = false;
            this.mem_w1.Location = new System.Drawing.Point(454, 61);
            this.mem_w1.Name = "mem_w1";
            this.mem_w1.Size = new System.Drawing.Size(41, 22);
            this.mem_w1.TabIndex = 37;
            // 
            // mem_h1
            // 
            this.mem_h1.Enabled = false;
            this.mem_h1.Location = new System.Drawing.Point(409, 61);
            this.mem_h1.Name = "mem_h1";
            this.mem_h1.Size = new System.Drawing.Size(38, 22);
            this.mem_h1.TabIndex = 36;
            // 
            // mem_g1
            // 
            this.mem_g1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mem_g1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mem_g1.Enabled = false;
            this.mem_g1.FormattingEnabled = true;
            this.mem_g1.Location = new System.Drawing.Point(330, 61);
            this.mem_g1.Name = "mem_g1";
            this.mem_g1.Size = new System.Drawing.Size(72, 23);
            this.mem_g1.TabIndex = 35;
            // 
            // mem_dob1
            // 
            this.mem_dob1.Enabled = false;
            this.mem_dob1.Location = new System.Drawing.Point(183, 61);
            this.mem_dob1.Name = "mem_dob1";
            this.mem_dob1.Size = new System.Drawing.Size(140, 22);
            this.mem_dob1.TabIndex = 34;
            // 
            // mem_name1
            // 
            this.mem_name1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mem_name1.Enabled = false;
            this.mem_name1.Location = new System.Drawing.Point(3, 61);
            this.mem_name1.Name = "mem_name1";
            this.mem_name1.Size = new System.Drawing.Size(173, 22);
            this.mem_name1.TabIndex = 33;
            // 
            // mem_bg
            // 
            this.mem_bg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mem_bg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mem_bg.FormattingEnabled = true;
            this.mem_bg.Location = new System.Drawing.Point(501, 33);
            this.mem_bg.Name = "mem_bg";
            this.mem_bg.Size = new System.Drawing.Size(84, 23);
            this.mem_bg.TabIndex = 32;
            // 
            // mem_w
            // 
            this.mem_w.Location = new System.Drawing.Point(454, 33);
            this.mem_w.Name = "mem_w";
            this.mem_w.Size = new System.Drawing.Size(41, 22);
            this.mem_w.TabIndex = 31;
            // 
            // mem_h
            // 
            this.mem_h.Location = new System.Drawing.Point(409, 33);
            this.mem_h.Name = "mem_h";
            this.mem_h.Size = new System.Drawing.Size(38, 22);
            this.mem_h.TabIndex = 30;
            // 
            // mem_g
            // 
            this.mem_g.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mem_g.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mem_g.FormattingEnabled = true;
            this.mem_g.Location = new System.Drawing.Point(330, 33);
            this.mem_g.Name = "mem_g";
            this.mem_g.Size = new System.Drawing.Size(72, 23);
            this.mem_g.TabIndex = 29;
            // 
            // mem_dob
            // 
            this.mem_dob.Location = new System.Drawing.Point(183, 33);
            this.mem_dob.Name = "mem_dob";
            this.mem_dob.Size = new System.Drawing.Size(140, 22);
            this.mem_dob.TabIndex = 28;
            // 
            // mem_name
            // 
            this.mem_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mem_name.Location = new System.Drawing.Point(3, 33);
            this.mem_name.Name = "mem_name";
            this.mem_name.Size = new System.Drawing.Size(173, 22);
            this.mem_name.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Blood Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "DOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Gender";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.mem_email);
            this.groupBox3.Controls.Add(this.mem_sms);
            this.groupBox3.Controls.Add(this.mem_mob);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.mem_pin);
            this.groupBox3.Controls.Add(this.mem_city);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.mem_l3);
            this.groupBox3.Controls.Add(this.mem_l2);
            this.groupBox3.Controls.Add(this.mem_l1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 103);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Address";
            // 
            // mem_l1
            // 
            this.mem_l1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mem_l1.Location = new System.Drawing.Point(67, 18);
            this.mem_l1.Name = "mem_l1";
            this.mem_l1.Size = new System.Drawing.Size(253, 22);
            this.mem_l1.TabIndex = 6;
            // 
            // mem_l2
            // 
            this.mem_l2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mem_l2.Location = new System.Drawing.Point(67, 46);
            this.mem_l2.Name = "mem_l2";
            this.mem_l2.Size = new System.Drawing.Size(253, 22);
            this.mem_l2.TabIndex = 7;
            // 
            // mem_l3
            // 
            this.mem_l3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mem_l3.Location = new System.Drawing.Point(67, 74);
            this.mem_l3.Name = "mem_l3";
            this.mem_l3.Size = new System.Drawing.Size(253, 22);
            this.mem_l3.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "City / Pin";
            // 
            // mem_city
            // 
            this.mem_city.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mem_city.Location = new System.Drawing.Point(393, 18);
            this.mem_city.Name = "mem_city";
            this.mem_city.Size = new System.Drawing.Size(86, 22);
            this.mem_city.TabIndex = 10;
            // 
            // mem_pin
            // 
            this.mem_pin.Location = new System.Drawing.Point(485, 18);
            this.mem_pin.Name = "mem_pin";
            this.mem_pin.Size = new System.Drawing.Size(86, 22);
            this.mem_pin.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Mobile";
            // 
            // mem_mob
            // 
            this.mem_mob.Location = new System.Drawing.Point(393, 46);
            this.mem_mob.Name = "mem_mob";
            this.mem_mob.Size = new System.Drawing.Size(86, 22);
            this.mem_mob.TabIndex = 13;
            this.mem_mob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mem_mob_KeyPress);
            this.mem_mob.Leave += new System.EventHandler(this.mem_mob_Leave);
            // 
            // mem_sms
            // 
            this.mem_sms.AutoSize = true;
            this.mem_sms.Location = new System.Drawing.Point(485, 48);
            this.mem_sms.Name = "mem_sms";
            this.mem_sms.Size = new System.Drawing.Size(88, 19);
            this.mem_sms.TabIndex = 18;
            this.mem_sms.Text = "Send SMS";
            this.mem_sms.UseVisualStyleBackColor = true;
            this.mem_sms.CheckedChanged += new System.EventHandler(this.mem_sms_CheckedChanged);
            // 
            // mem_email
            // 
            this.mem_email.Location = new System.Drawing.Point(393, 74);
            this.mem_email.Name = "mem_email";
            this.mem_email.Size = new System.Drawing.Size(178, 22);
            this.mem_email.TabIndex = 19;
            this.mem_email.Leave += new System.EventHandler(this.mem_email_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.avoid_btn);
            this.groupBox4.Controls.Add(this.remove_btn);
            this.groupBox4.Controls.Add(this.change_btn);
            this.groupBox4.Controls.Add(this.save_btn);
            this.groupBox4.Location = new System.Drawing.Point(12, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(591, 52);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            // 
            // avoid_btn
            // 
            this.avoid_btn.Location = new System.Drawing.Point(382, 21);
            this.avoid_btn.Name = "avoid_btn";
            this.avoid_btn.Size = new System.Drawing.Size(75, 23);
            this.avoid_btn.TabIndex = 3;
            this.avoid_btn.Text = "Avoid";
            this.avoid_btn.UseVisualStyleBackColor = true;
            this.avoid_btn.Click += new System.EventHandler(this.avoid_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Enabled = false;
            this.remove_btn.Location = new System.Drawing.Point(300, 21);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 23);
            this.remove_btn.TabIndex = 2;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // change_btn
            // 
            this.change_btn.Enabled = false;
            this.change_btn.Location = new System.Drawing.Point(218, 21);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(75, 23);
            this.change_btn.TabIndex = 1;
            this.change_btn.Text = "Change";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(137, 21);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 330);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "member";
            this.Text = "Member";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mem_id;
        private System.Windows.Forms.RadioButton mem_i;
        private System.Windows.Forms.RadioButton mem_c;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox mem_bg1;
        private System.Windows.Forms.TextBox mem_w1;
        private System.Windows.Forms.TextBox mem_h1;
        private System.Windows.Forms.ComboBox mem_g1;
        private System.Windows.Forms.DateTimePicker mem_dob1;
        private System.Windows.Forms.TextBox mem_name1;
        private System.Windows.Forms.ComboBox mem_bg;
        private System.Windows.Forms.TextBox mem_w;
        private System.Windows.Forms.TextBox mem_h;
        private System.Windows.Forms.ComboBox mem_g;
        private System.Windows.Forms.DateTimePicker mem_dob;
        private System.Windows.Forms.TextBox mem_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mem_l3;
        private System.Windows.Forms.TextBox mem_l2;
        private System.Windows.Forms.TextBox mem_l1;
        private System.Windows.Forms.TextBox mem_pin;
        private System.Windows.Forms.TextBox mem_city;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mem_mob;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mem_email;
        private System.Windows.Forms.CheckBox mem_sms;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button avoid_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Button save_btn;
    }
}