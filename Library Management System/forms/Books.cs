using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Remoting.Contexts;
using Library_Management_System.database;
using System.Net;

namespace Library_Management_System
{
    public partial class Books : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\msilo\Documents\librarydb.mdf;Integrated Security=True;Connect Timeout=30");
        public Books()
        {
            InitializeComponent();

            displayBooks();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayBooks();
        }

        private void addbooks_closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String imagePath;

        private void addBooks_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addBooks_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBooks_addBtn_Click(object sender, EventArgs e)
        {
            if (addBooks_picture.Image == null
               || addBooks_title.Text == ""
               || addBooks_author.Text == ""
               || addBooks_category.Text == ""
               || addBooks_quantity.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    try
                    {
                        DateTime today = DateTime.Today;
                        cnn.Open();
                        string insertData = "INSERT INTO books " +
                            "(title, author, category, quantity, bookImage, date_insert) " +
                            "VALUES(@title, @author, @category, @quantity, @image, @dateInsert)";

                        string path = Path.Combine(@"C:\Users\msilo\source\repos\Library Management System\Library Management System\Books\" +
                            addBooks_title.Text + addBooks_author.Text.Trim() + ".jpg");

                        string directoryPath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }
                        File.Copy(addBooks_picture.ImageLocation, path, true);

                        using (SqlCommand cmd = new SqlCommand(insertData, cnn))
                        {
                            cmd.Parameters.AddWithValue("@title", addBooks_title.Text.Trim());
                            cmd.Parameters.AddWithValue("@author", addBooks_author.Text.Trim());
                            cmd.Parameters.AddWithValue("@category", addBooks_category.Text.Trim());
                            cmd.Parameters.AddWithValue("@quantity", addBooks_quantity.Text.Trim());
                            cmd.Parameters.AddWithValue("@image", path);
                            cmd.Parameters.AddWithValue("@dateInsert", today);

                            cmd.ExecuteNonQuery();

                            displayBooks();

                            MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            addBooks_picture.Image = null;
            addBooks_title.Text = "";
            addBooks_author.Text = "";
            addBooks_category.SelectedIndex = -1;
            addBooks_quantity.Text = "";
            
        }

        public void displayBooks()
        {
            AddBookdb bookdb = new AddBookdb();
            List<AddBookdb> listData = bookdb.addBooksData();

            dataGridView.DataSource = listData;

        }

        public int ID = 0;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];  
                ID = (int)row.Cells[0].Value;
                addBooks_title.Text = row.Cells[1].Value.ToString();
                addBooks_author.Text = row.Cells[2].Value.ToString();
                addBooks_quantity.Text = row.Cells[4].Value.ToString();

                string imagePath = row.Cells[5].Value.ToString();


                if (imagePath != null || imagePath.Length >= 1)
                {
                    addBooks_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addBooks_picture.Image = null;
                }
                addBooks_category.Text = row.Cells[3].Value.ToString();
            }
        }

        private void addBooks_updateBtn_Click(object sender, EventArgs e)
        {
            if (addBooks_picture.Image == null
               || addBooks_title.Text == ""
               || addBooks_author.Text == ""
               || addBooks_category.Text == ""
               || addBooks_quantity.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cnn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Book ID:"
                        + ID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            cnn.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE books SET title = @title" +
                                ", author = @author, category = @category" +
                                ", quantity = @quantity, date_update = @dateUpdate WHERE bookID = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, cnn))
                            {
                                cmd.Parameters.AddWithValue("@title", addBooks_title.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", addBooks_author.Text.Trim());
                                cmd.Parameters.AddWithValue("@category", addBooks_category.Text.Trim());
                                cmd.Parameters.AddWithValue("@quantity", addBooks_quantity.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@id", ID);

                                cmd.ExecuteNonQuery();

                                displayBooks();

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

        private void addBooks_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addBooks_picture.Image == null
               || addBooks_title.Text == ""
               || addBooks_author.Text == ""
               || addBooks_category.Text == ""
               || addBooks_quantity.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cnn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE Book ID:"
                        + ID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            cnn.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE books SET date_delete = @dateDelete WHERE bookID = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, cnn))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@id", ID);

                                cmd.ExecuteNonQuery();

                                displayBooks();

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

        private void addBooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
