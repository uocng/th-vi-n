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
    public partial class user : Form
    {
        string connectionString;
        SqlConnection conn;
        SqlCommand cmd;
        public user()
        {
            InitializeComponent();
            connectionString = @"Data Source=DESKTOP-Q3KHQ96\NGUYENCUONG;Initial Catalog=librarian;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        private void user_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarianDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.librarianDataSet.Book);

        }
        public void Filldata()
        {
            conn.Open();
            string query = "Select * from Book";
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(dt);
            dgv_Books.DataSource = dt;
            conn.Close();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text.Trim();

            if (!string.IsNullOrEmpty(searchValue))
            {
                string query = "SELECT * FROM Book WHERE BookID LIKE @SearchValue OR Title LIKE @SearchValue OR Author LIKE @SearchValue";
                conn.Open();
                SqlCommand comm = new SqlCommand(query, conn);
                comm.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    dgv_Books.DataSource = dt;
                }
                else
                {
                    dgv_Books.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Please enter a search value!");
            }
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Filldata();
            txt_search.Text = null;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 logIn = new Form1();
            logIn.ShowDialog();
            this.Dispose();
        }
    }
}
