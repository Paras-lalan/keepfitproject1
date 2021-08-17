namespace keepfit2._1._2
{
    partial class feessearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feessearch));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mem_id = new System.Windows.Forms.ComboBox();
            this.mem_nm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search1 = new System.Windows.Forms.Button();
            this.export1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mem_nm1 = new System.Windows.Forms.ComboBox();
            this.mem_id1 = new System.Windows.Forms.ComboBox();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.purch = new System.Windows.Forms.RadioButton();
            this.exp = new System.Windows.Forms.RadioButton();
            this.search2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 285);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.export1);
            this.tabPage1.Controls.Add(this.search1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.mem_nm);
            this.tabPage1.Controls.Add(this.mem_id);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(830, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ID";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.search2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dt2);
            this.tabPage2.Controls.Add(this.dt1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.mem_nm1);
            this.tabPage2.Controls.Add(this.mem_id1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(830, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Date";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mem_id
            // 
            this.mem_id.FormattingEnabled = true;
            this.mem_id.Location = new System.Drawing.Point(9, 27);
            this.mem_id.Name = "mem_id";
            this.mem_id.Size = new System.Drawing.Size(71, 23);
            this.mem_id.TabIndex = 0;
            // 
            // mem_nm
            // 
            this.mem_nm.FormattingEnabled = true;
            this.mem_nm.Location = new System.Drawing.Point(86, 27);
            this.mem_nm.Name = "mem_nm";
            this.mem_nm.Size = new System.Drawing.Size(219, 23);
            this.mem_nm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(312, 27);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(75, 23);
            this.search1.TabIndex = 4;
            this.search1.Text = "Search";
            this.search1.UseVisualStyleBackColor = true;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // export1
            // 
            this.export1.Location = new System.Drawing.Point(394, 27);
            this.export1.Name = "export1";
            this.export1.Size = new System.Drawing.Size(75, 23);
            this.export1.TabIndex = 5;
            this.export1.Text = "Export";
            this.export1.UseVisualStyleBackColor = true;
            this.export1.Click += new System.EventHandler(this.export1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(815, 195);
            this.dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // mem_nm1
            // 
            this.mem_nm1.FormattingEnabled = true;
            this.mem_nm1.Location = new System.Drawing.Point(68, 24);
            this.mem_nm1.Name = "mem_nm1";
            this.mem_nm1.Size = new System.Drawing.Size(185, 23);
            this.mem_nm1.TabIndex = 5;
            // 
            // mem_id1
            // 
            this.mem_id1.FormattingEnabled = true;
            this.mem_id1.Location = new System.Drawing.Point(6, 24);
            this.mem_id1.Name = "mem_id1";
            this.mem_id1.Size = new System.Drawing.Size(56, 23);
            this.mem_id1.TabIndex = 4;
            // 
            // dt1
            // 
            this.dt1.Location = new System.Drawing.Point(259, 25);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(143, 22);
            this.dt1.TabIndex = 8;
            // 
            // dt2
            // 
            this.dt2.Location = new System.Drawing.Point(409, 25);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(141, 22);
            this.dt2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exp);
            this.groupBox1.Controls.Add(this.purch);
            this.groupBox1.Location = new System.Drawing.Point(556, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 38);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // purch
            // 
            this.purch.AutoSize = true;
            this.purch.Location = new System.Drawing.Point(6, 12);
            this.purch.Name = "purch";
            this.purch.Size = new System.Drawing.Size(63, 19);
            this.purch.TabIndex = 0;
            this.purch.TabStop = true;
            this.purch.Text = "Purch";
            this.purch.UseVisualStyleBackColor = true;
            // 
            // exp
            // 
            this.exp.AutoSize = true;
            this.exp.Location = new System.Drawing.Point(75, 12);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(49, 19);
            this.exp.TabIndex = 1;
            this.exp.TabStop = true;
            this.exp.Text = "Exp";
            this.exp.UseVisualStyleBackColor = true;
            // 
            // search2
            // 
            this.search2.Location = new System.Drawing.Point(687, 24);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(61, 23);
            this.search2.TabIndex = 11;
            this.search2.Text = "Search";
            this.search2.UseVisualStyleBackColor = true;
            this.search2.Click += new System.EventHandler(this.search2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(755, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Export";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(818, 198);
            this.dataGridView2.TabIndex = 13;
            // 
            // feessearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 309);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "feessearch";
            this.Text = "feessearch";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button export1;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mem_nm;
        private System.Windows.Forms.ComboBox mem_id;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton exp;
        private System.Windows.Forms.RadioButton purch;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mem_nm1;
        private System.Windows.Forms.ComboBox mem_id1;
    }
}