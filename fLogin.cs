using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = fusername.Text;
            string password = fpassword.Text;
            string role = frole.Text;

            if (username == "admin" & password == "123456" & role == "Admin")
            {
                AdInfor fInfor = new AdInfor();
                fInfor.Show();
                return;
            }
            if (username == "tung" & password == "123456" & role == "Teacher")
            {   
                TInfor TInfor = new TInfor();
                TInfor.Show();
                return;
            }
            if (username == "linh" & password == "123456" & role == "Student")
            {
                SInfor SInfor = new SInfor();   
                SInfor.Show();
                return;
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
/*
 * Comment for fLogin class:
 * 
 * This class represents the login form for the CourseWork application. It provides functionality for users to log in
 * with a username, password, and role. Upon clicking the login button, it checks the entered credentials against
 * predefined values for admin, teacher, and student roles. If the credentials match, it opens a corresponding information
 * form (AdInfor for admin, TInfor for teacher, and SInfor for student). If the credentials are invalid, it displays
 * a message box indicating so.
 * 
 * Note: The '&' operator in the if conditions should be replaced with '&&' for logical AND operations.
 */
