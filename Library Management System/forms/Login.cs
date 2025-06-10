using Library_Management_System.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Library_Management_System
{
    public partial class Login : Form
    {

        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\msilo\Documents\librarydb.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void login_signupbtn_Click(object sender, EventArgs e)
        {
            Register registerF = new Register();
            registerF.Show();
            this.Hide();
            
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
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

                        String selectData
                            = "SELECT * FROM users WHERE username = @username AND password = @password";
                        using (SqlCommand cmd = new SqlCommand(selectData, cnn))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successfully!", "Information Message"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Dashboard dashboardF = new Dashboard();
                                dashboardF.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
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
