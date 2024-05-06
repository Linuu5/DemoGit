namespace CourseWork
{
    partial class AdInfor
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnView1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView2 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(223, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Teacher";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 244);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnView1
            // 
            this.btnView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnView1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnView1.Location = new System.Drawing.Point(394, 56);
            this.btnView1.Name = "btnView1";
            this.btnView1.Size = new System.Drawing.Size(141, 46);
            this.btnView1.TabIndex = 17;
            this.btnView1.Text = "View All Student";
            this.btnView1.UseVisualStyleBackColor = false;
            this.btnView1.Click += new System.EventHandler(this.btnView1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Location = new System.Drawing.Point(223, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete Teacher";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView2
            // 
            this.btnView2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnView2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnView2.Location = new System.Drawing.Point(212, 56);
            this.btnView2.Name = "btnView2";
            this.btnView2.Size = new System.Drawing.Size(141, 46);
            this.btnView2.TabIndex = 18;
            this.btnView2.Text = "View All Teacher";
            this.btnView2.UseVisualStyleBackColor = false;
            this.btnView2.Click += new System.EventHandler(this.btnView2_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete1.Location = new System.Drawing.Point(404, 168);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(119, 23);
            this.btnDelete1.TabIndex = 19;
            this.btnDelete1.Text = "Delete Student";
            this.btnDelete1.UseVisualStyleBackColor = false;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete2);
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd1.Location = new System.Drawing.Point(404, 123);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(119, 23);
            this.btnAdd1.TabIndex = 21;
            this.btnAdd1.Text = "Add Student";
            this.btnAdd1.UseVisualStyleBackColor = false;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click_1);
            // 
            // AdInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 521);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnView2);
            this.Controls.Add(this.btnView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Name = "AdInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.fInfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView2;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnAdd1;
    }
}