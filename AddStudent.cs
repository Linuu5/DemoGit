using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork
{
    public partial class AddStudent : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\admin\Desktop\TỰ HỌC\CourseWork\Test.mdf"";Integrated Security=True;Connect Timeout=30";
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddClick1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fname.Text) ||
                string.IsNullOrWhiteSpace(ftelephone.Text) ||
                string.IsNullOrWhiteSpace(fgmail.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Tạo câu lệnh SQL để chèn dữ liệu vào bảng
            string sql = "INSERT INTO Dtb1 (name, telephone, gmail) " +
                         "VALUES (@Name, @Telephone, @Gmail)";

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
                        command.Parameters.AddWithValue("@Gmail", fgmail.Text);

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
 * Comment for AddStudent class:
 * 
 * This class represents the form for adding student records to the CourseWork application. It provides functionality
 * for users to input student information such as name, telephone, and email, and then add this information to the
 * database. It contains a method to handle the button click event for adding student records. The database connection
 * string is defined within the class. Note that input validation is performed to ensure that all required fields
 * are filled in before adding a student record.
 */


