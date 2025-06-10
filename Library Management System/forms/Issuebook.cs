using Library_Management_System.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.forms
{
    public partial class Issuebook : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\msilo\Documents\librarydb.mdf;Integrated Security=True;Connect Timeout=30");
        public Issuebook()
        {
            InitializeComponent();

            displayBookIssueData();
            DataBookTitle();

        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayBookIssueData();
            DataBookTitle();
            bookIssue_email.TextChanged += bookIssue_email_TextChanged;
        }

        public void displayBookIssueData()
        {

            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.IssueBooksData();

            dataGridView.DataSource = listData;
        }

        private void bookIssue_addBtn_Click(object sender, EventArgs e)
        {
            if (bookIssue_id.Text == ""
                || bookIssue_name.Text == ""
                || bookIssue_phone.Text == ""
                || bookIssue_email.Text == ""
                || bookIssue_booktitle.Text == ""
                || bookIssue_author.Text == ""
                || bookIssue_issueDate.Value == null
                || bookIssue_returnDate.Value == null
                || bookIssue_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cnn.State != ConnectionState.Open)
                {
                    try
                    {
                        DateTime today = DateTime.Today;

                        cnn.Open();

                        string insertData = "INSERT INTO issues " +
                            "(issue_id, full_name, phone, email, book_title, author, issue_date, return_date, date_insert) " +
                            "VALUES(@issueID, @fullname, @phone, @email, @bookTitle, @author, @issueDate, @returnDate, @dateInsert)";

                        using (SqlCommand cmd = new SqlCommand(insertData, cnn))
                        {
                            cmd.Parameters.AddWithValue("@issueID", bookIssue_id.Text.Trim());
                            cmd.Parameters.AddWithValue("@fullname", bookIssue_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", bookIssue_phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", bookIssue_email.Text.Trim());
                            cmd.Parameters.AddWithValue("@bookTitle", bookIssue_booktitle.Text.Trim());
                            cmd.Parameters.AddWithValue("@author", bookIssue_author.Text.Trim());
                            cmd.Parameters.AddWithValue("@issueDate", bookIssue_issueDate.Value);
                            cmd.Parameters.AddWithValue("@returnDate", bookIssue_returnDate.Value); ;
                            cmd.Parameters.AddWithValue("@dateInsert", today);

                            cmd.ExecuteNonQuery();

                            displayBookIssueData();

                            MessageBox.Show("Issued successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }
        }

        public void clearFields()
        {
            bookIssue_id.Text = "";
            bookIssue_name.Text = "";
            bookIssue_phone.Text = "";
            bookIssue_email.Text = "";
            bookIssue_booktitle.SelectedIndex = -1;
            bookIssue_author.SelectedIndex = -1;
            bookIssue_picture.Image = null;
        }

        public void DataBookTitle()
        {
            if (cnn.State == ConnectionState.Closed)
            {
                try
                {
                    cnn.Open();
                    string selectData = "SELECT bookID, title FROM books WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, cnn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        bookIssue_booktitle.DataSource = table;
                        bookIssue_booktitle.DisplayMember = "title";
                        bookIssue_booktitle.ValueMember = "bookID";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    cnn.Close();
                }
            }

        }

        private void bookIssue_booktitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cnn.State != ConnectionState.Open)
            {
                if (bookIssue_booktitle.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)bookIssue_booktitle.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["bookID"]);
                    try
                    {
                        cnn.Open();

                        string selectData = "SELECT * FROM books WHERE bookID = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, cnn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                bookIssue_author.Text = table.Rows[0]["author"].ToString();

                                string imagePath = table.Rows[0]["bookImage"].ToString();

                                if (imagePath != null)
                                {
                                    bookIssue_picture.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    bookIssue_picture.Image = null;
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }
        }
        private void bookIssue_updateBtn_Click(object sender, EventArgs e)
        {
            if (bookIssue_id.Text == ""
                || bookIssue_name.Text == ""
                || bookIssue_phone.Text == ""
                || bookIssue_email.Text == ""
                || bookIssue_booktitle.Text == ""
                || bookIssue_author.Text == ""
                || bookIssue_issueDate.Value == null
                || bookIssue_returnDate.Value == null
                || bookIssue_picture.Image == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cnn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Issue ID:"
                        + bookIssue_id + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            cnn.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE issues SET full_name = @fullName, phone = @phone, email = @email" +
                                ", book_title = @bookTitle, author = @author, issue_date = @issueDate" +
                                ", return_date = @returnDate, date_update = @dateUpdate WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, cnn))
                            {
                                cmd.Parameters.AddWithValue("@fullName", bookIssue_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@contact", bookIssue_phone.Text.Trim());
                                cmd.Parameters.AddWithValue("@email", bookIssue_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@bookTitle", bookIssue_booktitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", bookIssue_author.Text.Trim());
                                cmd.Parameters.AddWithValue("@issueDate", bookIssue_issueDate.Value);
                                cmd.Parameters.AddWithValue("@returnDate", bookIssue_returnDate.Value);
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@issueID", bookIssue_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayBookIssueData();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            cnn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void bookIssue_deleteBtn_Click(object sender, EventArgs e)
        {
            if (bookIssue_id.Text == ""
                || bookIssue_name.Text == ""
                || bookIssue_phone.Text == ""
                || bookIssue_email.Text == ""
                || bookIssue_booktitle.Text == ""
                || bookIssue_author.Text == ""
                || bookIssue_issueDate.Value == null
                || bookIssue_returnDate.Value == null
                || bookIssue_picture.Image == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cnn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE Issue ID:"
                        + bookIssue_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            cnn.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE issues SET date_delete = @dateDelete WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, cnn))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@issueID", bookIssue_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayBookIssueData();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            cnn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void bookIssue_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                bookIssue_id.Text = row.Cells[1].Value.ToString();
                bookIssue_name.Text = row.Cells[2].Value.ToString();
                bookIssue_phone.Text = row.Cells[3].Value.ToString();
                bookIssue_email.Text = row.Cells[4].Value.ToString();
                bookIssue_booktitle.Text = row.Cells[5].Value.ToString();
                bookIssue_author.Text = row.Cells[6].Value.ToString();
                bookIssue_issueDate.Text = row.Cells[7].Value.ToString();
                bookIssue_returnDate.Text = row.Cells[8].Value.ToString();

            }
        }

        private void bookIssue_email_TextChanged(object sender, EventArgs e)
        {
            if (cnn.State != ConnectionState.Open)
            {
                try
                {
                    cnn.Open();

                    string selectData = "SELECT name, phone FROM members WHERE email = @email";

                    using (SqlCommand cmd = new SqlCommand(selectData, cnn))
                    {
                        cmd.Parameters.AddWithValue("@email", bookIssue_email.Text.Trim());

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Retrieve member details
                            string name = reader["name"].ToString();
                            string phone = reader["phone"].ToString();

                            // Display member information in corresponding fields
                            bookIssue_name.Text = name;
                            bookIssue_phone.Text = phone;
                        }
                        else
                        {
                            // Clear member information if no matching email found
                            bookIssue_name.Text = "";
                            bookIssue_phone.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }
    }
}
