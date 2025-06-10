using Library_Management_System.forms;
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
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace Library_Management_System
{
    public partial class Dashboard : Form
    {

        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\msilo\Documents\librarydb.mdf;Integrated Security=True;Connect Timeout=30");
        public Dashboard()
        {
            InitializeComponent();
            DisplayCounts();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximiz_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void addMember_btn_Click(object sender, EventArgs e)
        {
          Members memberF = new Members();
          memberF.Show();
        }

        private void addBooks_btn_Click(object sender, EventArgs e)
        {
            Books bookF = new Books();
            bookF.Show();
        }

        private void issueBooks_btn_Click(object sender, EventArgs e)
        {
            Issuebook issueBF = new Issuebook();
            issueBF.Show();   
        }

        private void returnBooks_btn_Click(object sender, EventArgs e)
        {
            Returnbook returnBF = new Returnbook();
            returnBF.Show();
        }


        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Login loginF = new Login();
                loginF.Show();
                this.Hide();

            }
        }

        private void DisplayCounts()
        {
            try
            {
                cnn.Open();

                SqlCommand cmdMemberCount = new SqlCommand("SELECT COUNT(*) FROM members", cnn);
                int memberCount = (int)cmdMemberCount.ExecuteScalar();
                membersCount_label.Text =  memberCount.ToString();

                SqlCommand cmdBookCount = new SqlCommand("SELECT SUM(quantity) FROM books", cnn);
                int bookCount = (int)cmdBookCount.ExecuteScalar();
                booksCount_label.Text = bookCount.ToString();

                SqlCommand cmdTotalIssuesCount = new SqlCommand("SELECT COUNT(*) FROM issues", cnn);
                int totalIssuesCount = (int)cmdTotalIssuesCount.ExecuteScalar();
                issuedBooksCount_label.Text =  totalIssuesCount.ToString();

                SqlCommand cmdUnreturnedIssuesCount = new SqlCommand("SELECT COUNT(*) FROM issues WHERE status = 'returned'", cnn);
                int returnedIssuesCount = (int)cmdUnreturnedIssuesCount.ExecuteScalar();
                returnedBooksCount_label.Text = returnedIssuesCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
        }

    }
}
