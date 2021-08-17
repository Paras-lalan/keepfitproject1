namespace keepfit2._1._2
{
    partial class period
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(period));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.avoid_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.change_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p_name = new System.Windows.Forms.TextBox();
            this.p_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.avoid_btn);
            this.groupBox2.Controls.Add(this.remove_btn);
            this.groupBox2.Controls.Add(this.change_btn);
            this.groupBox2.Controls.Add(this.save_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 52);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // avoid_btn
            // 
            this.avoid_btn.Location = new System.Drawing.Point(249, 21);
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
            this.remove_btn.Location = new System.Drawing.Point(168, 21);
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
            this.change_btn.Location = new System.Drawing.Point(87, 21);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(75, 23);
            this.change_btn.TabIndex = 1;
            this.change_btn.Text = "Change";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(6, 21);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.p_name);
            this.groupBox1.Controls.Add(this.p_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 86);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // p_name
            // 
            this.p_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.p_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.p_name.Location = new System.Drawing.Point(83, 48);
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(244, 22);
            this.p_name.TabIndex = 3;
            this.p_name.Leave += new System.EventHandler(this.p_name_Leave);
            // 
            // p_id
            // 
            this.p_id.Location = new System.Drawing.Point(83, 19);
            this.p_id.Name = "p_id";
            this.p_id.Size = new System.Drawing.Size(100, 22);
            this.p_id.TabIndex = 2;
            this.p_id.Leave += new System.EventHandler(this.p_id_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Period";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Period Id";
            // 
            // period
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 163);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "period";
            this.Text = "period";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button avoid_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox p_name;
        private System.Windows.Forms.TextBox p_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}