namespace CourseWork
{
    partial class AddTeacher
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
            this.fgmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ftelephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fdate = new System.Windows.Forms.DateTimePicker();
            this.fsalary = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddClick1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fgmail
            // 
            this.fgmail.Location = new System.Drawing.Point(164, 157);
            this.fgmail.Name = "fgmail";
            this.fgmail.Size = new System.Drawing.Size(216, 20);
            this.fgmail.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Gmail";
            // 
            // ftelephone
            // 
            this.ftelephone.Location = new System.Drawing.Point(164, 119);
            this.ftelephone.Name = "ftelephone";
            this.ftelephone.Size = new System.Drawing.Size(216, 20);
            this.ftelephone.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Telephone";
            // 
            // fdate
            // 
            this.fdate.Location = new System.Drawing.Point(164, 203);
            this.fdate.Name = "fdate";
            this.fdate.Size = new System.Drawing.Size(216, 20);
            this.fdate.TabIndex = 20;
            // 
            // fsalary
            // 
            this.fsalary.Location = new System.Drawing.Point(164, 80);
            this.fsalary.Name = "fsalary";
            this.fsalary.Size = new System.Drawing.Size(216, 20);
            this.fsalary.TabIndex = 19;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(164, 45);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(216, 20);
            this.fname.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // AddClick1
            // 
            this.AddClick1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddClick1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClick1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddClick1.Location = new System.Drawing.Point(196, 251);
            this.AddClick1.Name = "AddClick1";
            this.AddClick1.Size = new System.Drawing.Size(75, 37);
            this.AddClick1.TabIndex = 26;
            this.AddClick1.Text = "Add";
            this.AddClick1.UseVisualStyleBackColor = false;
            this.AddClick1.Click += new System.EventHandler(this.AddClick_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 300);
            this.Controls.Add(this.AddClick1);
            this.Controls.Add(this.fgmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ftelephone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fdate);
            this.Controls.Add(this.fsalary);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTeacher";
            this.Text = "Add Teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fgmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ftelephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fdate;
        private System.Windows.Forms.TextBox fsalary;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddClick1;
    }
}