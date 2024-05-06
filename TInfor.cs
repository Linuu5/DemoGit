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
    public partial class TInfor : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        static public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\admin\Desktop\TỰ HỌC\CourseWork\Test.mdf"";Integrated Security=True;Connect Timeout=30";
        public TInfor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
                return;
            }

            // Lấy giá trị của cột Id từ dòng được chọn
            int idToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            // Tạo câu lệnh SQL để xóa dữ liệu từ bảng
            string sql = "DELETE FROM Dtb1 WHERE Id = @Id";

            // Mở kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo một đối tượng Command để thực thi câu lệnh SQL
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Đặt giá trị tham số
                        command.Parameters.AddWithValue("@Id", idToDelete);

                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bản ghi nào được xóa không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bản ghi có Id: " + idToDelete);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\admin\Desktop\TỰ HỌC\CourseWork\Test.mdf"";Integrated Security=True;Connect Timeout=30";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Dtb1";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent AddStudent = new AddStudent();
            AddStudent.Show();
            return;
        }

        private void btnView2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\admin\Desktop\TỰ HỌC\CourseWork\Test.mdf"";Integrated Security=True;Connect Timeout=30";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Dtb2";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }

}
/*
 * Comment for TInfor class:
 * 
 * This class represents the teacher information form for the CourseWork application. It provides functionality for
 * teachers to view, add, and delete student records stored in the database. It contains methods to handle button
 * click events for viewing, adding, and deleting student records. The database connection string is defined within
 * the class. Note that there are duplicate connection strings defined in some methods, which could be optimized by
 * moving the connection string definition to a shared variable accessible within the class.
 */

