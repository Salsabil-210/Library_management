using Library_Management_System.database;
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

namespace Library_Management_System
{
    public partial class Members : Form
    {

        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\msilo\Documents\librarydb.mdf;Integrated Security=True;Connect Timeout=30");
        public Members()
        {
            InitializeComponent();

            displayMembers();
        }

        private void addMembers_closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayMembers();
        }

        private void addMembers_addBtn_Click(object sender, EventArgs e)
        {
            if (addMembers_name.Text == ""
               || addMembers_email.Text == ""
               || addMembers_phone.Text == ""
               || addMembers_gender.Text == "")

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
                        string insertData = "INSERT INTO members " +
                            "(name, email, phone, gender, date_insert) " +
                            "VALUES(@name, @email, @phone, @gender, @dateInsert)";


                        using (SqlCommand cmd = new SqlCommand(insertData, cnn))
                        {
                            cmd.Parameters.AddWithValue("@name", addMembers_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", addMembers_email.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", addMembers_phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addMembers_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@dateInsert", today);

                            cmd.ExecuteNonQuery();

                            displayMembers();

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

        public int ID = 0;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                ID = (int)row.Cells[0].Value;
                addMembers_name.Text = row.Cells[1].Value.ToString();
                addMembers_email.Text = row.Cells[2].Value.ToString();
                addMembers_phone.Text = row.Cells[3].Value.ToString();
                addMembers_gender.Text = row.Cells[4].Value.ToString();
            }
        }

        private void addMembers_updateBtn_Click(object sender, EventArgs e)
        {
            if (addMembers_name.Text == ""
               || addMembers_email.Text == ""
               || addMembers_phone.Text == ""
               || addMembers_gender.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cnn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Member ID:"
                        + ID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            cnn.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE members SET name = @name" +
                                ", email = @email, phone = @phone" +
                                ", gender = @gender, date_update = @dateUpdate WHERE MemberID = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, cnn))
                            {
                                cmd.Parameters.AddWithValue("@name", addMembers_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@email", addMembers_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@phone", addMembers_phone.Text.Trim());
                                cmd.Parameters.AddWithValue("@gender", addMembers_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@id", ID);

                                cmd.ExecuteNonQuery();

                                displayMembers();

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

        private void addMembers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addMembers_name.Text == ""
               || addMembers_email.Text == ""
               || addMembers_phone.Text == ""
               || addMembers_gender.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cnn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE Member ID:"
                        + ID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            cnn.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE members SET date_delete = @dateDelete WHERE memberID = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, cnn))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@id", ID);

                                cmd.ExecuteNonQuery();

                                displayMembers();

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

        private void addMembers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            addMembers_name.Text = "";
            addMembers_email.Text = "";
            addMembers_phone.Text = "";
            addMembers_gender.SelectedIndex = -1;
        }

        public void displayMembers()
        {
            AddMembersdb memberdb = new AddMembersdb();
            List<AddMembersdb> listData1 = memberdb.addMembersData();

            dataGridView.DataSource = listData1;

        }

     
    }
}
