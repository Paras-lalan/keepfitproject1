namespace keepfit2._1._2
{
    partial class changepassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changepassword));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.np = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.op = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.un = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.np);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.op);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.un);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 185);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // np
            // 
            this.np.Enabled = false;
            this.np.Location = new System.Drawing.Point(122, 95);
            this.np.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.np.Name = "np";
            this.np.PasswordChar = '●';
            this.np.Size = new System.Drawing.Size(172, 22);
            this.np.TabIndex = 29;
            this.np.Leave += new System.EventHandler(this.np_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "New Password";
            // 
            // op
            // 
            this.op.Location = new System.Drawing.Point(122, 60);
            this.op.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.op.Name = "op";
            this.op.PasswordChar = '●';
            this.op.Size = new System.Drawing.Size(172, 22);
            this.op.TabIndex = 27;
            this.op.Leave += new System.EventHandler(this.op_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Old Password";
            // 
            // un
            // 
            this.un.Location = new System.Drawing.Point(122, 24);
            this.un.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(172, 22);
            this.un.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "User Name";
            // 
            // changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 209);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "changepassword";
            this.Text = "changepassword";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox np;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox op;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox un;
        private System.Windows.Forms.Label label2;
    }
}