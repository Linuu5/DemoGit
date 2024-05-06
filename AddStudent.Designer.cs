namespace CourseWork
{
    partial class AddStudent
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
            this.AddClick1 = new System.Windows.Forms.Button();
            this.fgmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ftelephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddClick1
            // 
            this.AddClick1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddClick1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClick1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddClick1.Location = new System.Drawing.Point(198, 247);
            this.AddClick1.Name = "AddClick1";
            this.AddClick1.Size = new System.Drawing.Size(75, 37);
            this.AddClick1.TabIndex = 37;
            this.AddClick1.Text = "Add";
            this.AddClick1.UseVisualStyleBackColor = false;
            this.AddClick1.Click += new System.EventHandler(this.AddClick1_Click);
            // 
            // fgmail
            // 
            this.fgmail.Location = new System.Drawing.Point(166, 193);
            this.fgmail.Name = "fgmail";
            this.fgmail.Size = new System.Drawing.Size(216, 20);
            this.fgmail.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Gmail";
            // 
            // ftelephone
            // 
            this.ftelephone.Location = new System.Drawing.Point(166, 115);
            this.ftelephone.Name = "ftelephone";
            this.ftelephone.Size = new System.Drawing.Size(216, 20);
            this.ftelephone.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Telephone";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(166, 41);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(216, 20);
            this.fname.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 300);
            this.Controls.Add(this.AddClick1);
            this.Controls.Add(this.fgmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ftelephone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddClick1;
        private System.Windows.Forms.TextBox fgmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ftelephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label1;
    }
}