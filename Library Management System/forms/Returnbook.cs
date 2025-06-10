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

namespace Library_Management_System
{
    public partial class Returnbook : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\msilo\Documents\librarydb.mdf;Integrated Security=True;Connect Timeout=30");
        public Returnbook()
        {
            InitializeComponent();
            displayIssuedBooksData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayIssuedBooksData();
        }

        private void returnBooks_returnBtn_Click(object sender, EventArgs e)
        {
            if (returnBooks_issueID.Text == ""
               || returnBooks_name.Text == ""
               || returnBooks_phone.Text == ""
               || returnBooks_email.Text == ""
               || returnBooks_bookTitle.Text == ""
               || returnBooks_author.Text == ""
               || returnBooks_issueDate.Value == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    DialogResult check = MessageBox.Show("Are you sure that Issue ID: "
                        + returnBooks_issueID.Text.Trim()
                        + "is return already?", "Confirmation Message", MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            DateTime today = DateTime.Today;
                            cnn.Open();

                            string updateData = "UPDATE issues SET status = @status, date_update = @dateUpdate " +
                            "WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, cnn))
                            {
                                cmd.Parameters.AddWithValue("@status", "Returned");
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@issueID", returnBooks_issueID.Text);

                                cmd.ExecuteNonQuery();

                                displayIssuedBooksData();

                                MessageBox.Show("Returned successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        }

        public void displayIssuedBooksData()
        {
            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.ReturnIssueBooksData();

            dataGridView.DataSource = listData;
        }


        private void returnBooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                returnBooks_issueID.Text = row.Cells[1].Value.ToString();
                returnBooks_name.Text = row.Cells[2].Value.ToString();
                returnBooks_phone.Text = row.Cells[3].Value.ToString();
                returnBooks_email.Text = row.Cells[4].Value.ToString();
                returnBooks_bookTitle.Text = row.Cells[5].Value.ToString();
                returnBooks_author.Text = row.Cells[6].Value.ToString();
                returnBooks_issueDate.Text = row.Cells[7].Value.ToString();
            }
        }

        public void clearFields()
        {
            returnBooks_issueID.Text = "";
            returnBooks_name.Text = "";
            returnBooks_phone.Text = "";
            returnBooks_email.Text = "";
            returnBooks_bookTitle.Text = "";
            returnBooks_author.Text = "";
            returnBooks_picture.Text = null;

        }

        private void returnBooks_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
