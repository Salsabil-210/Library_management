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
    public partial class Register : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\msilo\Documents\librarydb.mdf;Integrated Security=True;Connect Timeout=30");
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void Register_signinbtn_Click(object sender, EventArgs e)
        {
            Login loginf = new Login();
            loginf.Show();
            this.Close();
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            if (register_email.Text == "" || register_username.Text == "" || register_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cnn.State != ConnectionState.Open)
                {
                    try
                    {
                        cnn.Open();

                        String checkUsername = "SELECT COUNT(*) FROM users WHERE username = @username";

                        using (SqlCommand checkCMD = new SqlCommand(checkUsername, cnn))
                        {
                            checkCMD.Parameters.AddWithValue("@username", register_username.Text.Trim());
                            int count = (int)checkCMD.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(register_username.Text.Trim()
                                    + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // TO GET THE DATE TODAY
                                DateTime day = DateTime.Today;

                                String insertData = "INSERT INTO users (email, username, password, date_register) " +
                                "VALUES(@email, @username, @password, @date)";

                                using (SqlCommand insertCMD = new SqlCommand(insertData, cnn))
                                {
                                    insertCMD.Parameters.AddWithValue("@email", register_email.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@password", register_password.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@date", day.ToString());

                                    insertCMD.ExecuteNonQuery();

                                    MessageBox.Show("Register successfully!", "Information Message"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Login loginF = new Login();
                                    loginF.Show();
                                    this.Hide();
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }
        }
    }
}
