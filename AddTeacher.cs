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
using System.IO;

namespace CourseWork
{
    public partial class AddTeacher : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\admin\Desktop\TỰ HỌC\CourseWork\Test.mdf"";Integrated Security=True;Connect Timeout=30";
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void AddClick_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fname.Text) ||
                string.IsNullOrWhiteSpace(ftelephone.Text) ||
                string.IsNullOrWhiteSpace(fsalary.Text) ||
                string.IsNullOrWhiteSpace(fgmail.Text) ||
                string.IsNullOrWhiteSpace(fdate.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Tạo câu lệnh SQL để chèn dữ liệu vào bảng
            string sql = "INSERT INTO Dtb2 (name, telephone, salary, gmail, stardate) " +
                         "VALUES (@Name, @Telephone, @Salary, @Gmail, @StartDate)";

            // Mở kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo một đối tượng Command để thực thi câu lệnh SQL
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Đặt các giá trị tham số
                        command.Parameters.AddWithValue("@Name", fname.Text);
                        command.Parameters.AddWithValue("@Telephone", ftelephone.Text);
                        command.Parameters.AddWithValue("@Salary", fsalary.Text);
                        command.Parameters.AddWithValue("@Gmail", fgmail.Text);
                        command.Parameters.AddWithValue("@StartDate", DateTime.Parse(fdate.Text));

                        // Thực thi câu lệnh SQL
                        command.ExecuteNonQuery();

                        MessageBox.Show("Thêm dữ liệu thành công.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

            }
        }
    }
}
/*
 * Comment for AddTeacher class:
 * 
 * This class represents the form for adding teacher records to the CourseWork application. It provides functionality
 * for users to input teacher information such as name, telephone, salary, email, and start date, and then add this
 * information to the database. It contains a method to handle the button click event for adding teacher records.
 * The database connection string is defined within the class. Note that input validation is performed to ensure that
 * all required fields are filled in before adding a teacher record.
 */
