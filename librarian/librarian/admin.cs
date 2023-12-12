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
    public partial class admin : Form
    {
        string connectionString;
        SqlConnection conn;
        SqlCommand cmd;
        string choosenID;
        public admin()
        {
            InitializeComponent();
            connectionString = @"Data Source=DESKTOP-Q3KHQ96\NGUYENCUONG;Initial Catalog=librarian;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.Connection = conn;

            // lbl_User.Text = "User: " + username;
        }
        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarianDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.librarianDataSet.Book);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_Books.Rows[e.RowIndex];
                    choosenID = row.Cells["BookID"].Value.ToString();
                    txtBookID.Text = row.Cells["BookID"].Value.ToString();
                    txtTitle.Text = row.Cells["Title"].Value.ToString();
                    txtAuthor.Text = row.Cells["Author"].Value.ToString();
                    txtGenre.Text = row.Cells["Genre"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message, "Error");
            }
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
        private void bnt_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 logIn = new Form1();
            logIn.ShowDialog();
            this.Dispose();
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            int error = 0;
            string bookid = txtBookID.Text;
            if (bookid.Equals(""))
            {
                error++;
                lbl_BookID.Text = "BookID can't be blank";
            }
            else
            {
                lbl_BookID.Text = " ";
            }
            string Title = txtTitle.Text;
            if (Title.Equals(" "))
            {
                error++;
                lbl_Title.Text = "Title can't be blank";
            }
            else //check ID trùng
            {
                try
                {
                    conn.Open();
                    string query = "select * from Book where BookID = @BookID";
                    SqlCommand cmdcheck = new SqlCommand(query, conn);
                    cmdcheck.Parameters.AddWithValue("@BookID", SqlDbType.Char); //tạo @id trong sql
                    cmdcheck.Parameters["@BookID"].Value = bookid;  //gán giá trị cho parameter = biến id
                    SqlDataReader reader = cmdcheck.ExecuteReader();
                    if (reader.Read())
                    {
                        error++;
                        lbl_Error.Text = "BookID had existed";
                    }
                    else
                    {
                        lbl_Title.Text = "";
                    }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex.Message, "Error");
                }
                finally
                {
                    conn.Close();
                }

            }

            string Author = txtAuthor.Text;
            string Genre = txtGenre.Text;

            if (error == 0)
            {

                string insert = "Insert into Book values (@BookID,@Title,@Author,@Genre)";
                conn.Open();
                SqlCommand cmdinsert = new SqlCommand(insert, conn);
                cmdinsert.Parameters.AddWithValue("@BookID", SqlDbType.Int);
                cmdinsert.Parameters["@BookID"].Value = bookid;
                cmdinsert.Parameters.AddWithValue("@Title", SqlDbType.VarChar);
                cmdinsert.Parameters["@Title"].Value = Title;
                cmdinsert.Parameters.AddWithValue("@Author", SqlDbType.VarChar);
                cmdinsert.Parameters["@Author"].Value = Author;
                cmdinsert.Parameters.AddWithValue("@Genre", SqlDbType.VarChar);
                cmdinsert.Parameters["@Genre"].Value = Genre;

                cmdinsert.ExecuteNonQuery();
                conn.Close();
                Filldata();
                MessageBox.Show("Insert successfully");

            }
        }
        private void bnt_Update_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to update?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                String update = "Update Book set Title = @Title , Author = @Author , Genre =@Genre " + " where BookID = @BookID";
                conn.Open();
                SqlCommand updated = new SqlCommand(update, conn);

                updated.Parameters.Add("@BookID", SqlDbType.Int);
                updated.Parameters["@BookID"].Value = txtBookID.Text;

                updated.Parameters.Add("@Title", SqlDbType.VarChar);
                updated.Parameters["@Title"].Value = txtTitle.Text;

                updated.Parameters.Add("@Author", SqlDbType.VarChar);
                updated.Parameters["@Author"].Value = txtAuthor.Text;

                updated.Parameters.Add("@Genre", SqlDbType.VarChar);
                updated.Parameters["@Genre"].Value = txtGenre.Text;

                int i = updated.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    Filldata();
                    MessageBox.Show("Update successful");
                }


            }
        }
        private void bnt_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (choosenID != null)
                {
                    conn.Open();
                    MessageBox.Show("Do you no delete this book=" + choosenID + "?", "confirm", MessageBoxButtons.YesNo);
                    String sqlQuery = "DELETE Book WHERE BookID = @BookID";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sqlQuery;
                    cmd.Parameters.Add("@BookID", SqlDbType.Char);
                    cmd.Parameters["@BookID"].Value = choosenID;

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Filldata();
                    MessageBox.Show("deleted successfully");


                }
                else
                {
                    MessageBox.Show("Select 1 record to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message, "Error");
            }
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











        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
