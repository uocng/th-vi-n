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

namespace librarian
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            connectionString = @"Data Source=DESKTOP-Q3KHQ96\NGUYENCUONG;Initial Catalog=librarian;Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string password = txt_Password.Text;
            string query = "Select * from account where UserName = @UserName and UserPassword = @Password";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.VarChar);
            cmd.Parameters["@UserName"].Value = username;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar);
            cmd.Parameters["@Password"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string role = reader["UserRole"].ToString();
                if (role.Equals("admin"))
                {
                    MessageBox.Show("Login successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    admin ad = new admin();  //chuyển form
                    ad.ShowDialog(); //show hộp thoại thông báo
                    this.Dispose(); //Xóa bộ nhớ
                }
                else if (role.Equals("user"))
                {
                    MessageBox.Show("Login successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    user us = new user();  //chuyển form
                    us.ShowDialog(); //show hộp thoại thông báo
                    this.Dispose(); //Xóa bộ nhớ
                }
                else
                {
                    lbl_Error.Text = "You are not allowed to accesss!";
                }

            }
            else
            {
                lbl_Error.Text = "Wrong username or password";
            }
        }
    }
}
