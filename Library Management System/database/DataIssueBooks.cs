using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.database
{
    internal class DataIssueBooks
    {

        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\msilo\Documents\librarydb.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID { set; get; }
        public string IssueID { set; get; }
        public string Name { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string BookTitle { set; get; }
        public string Author { set; get; }
        public string DateIssue { set; get; }
        public string DateReturn { set; get; }

        public List<DataIssueBooks> IssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();
            if (cnn.State != ConnectionState.Open)
            {
                try
                {
                    cnn.Open();

                    string selectData = "SELECT * FROM issues WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, cnn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();


                        while (reader.Read())
                        {
                            DataIssueBooks dib = new DataIssueBooks();
                            dib.ID = (int)reader["id"];
                            dib.IssueID = reader["issue_id"].ToString();
                            dib.Name = reader["full_name"].ToString();
                            dib.Phone = reader["phone"].ToString();
                            dib.Email = reader["email"].ToString();
                            dib.BookTitle = reader["book_title"].ToString();
                            dib.Author = reader["author"].ToString();
                            dib.DateIssue = reader["issue_date"].ToString();
                            dib.DateReturn = reader["return_date"].ToString();

                            listData.Add(dib);
                        }

                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    cnn.Close();
                }
            }

            return listData;
        }

        public List<DataIssueBooks> ReturnIssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();
            if (cnn.State != ConnectionState.Open)
            {
                try
                {
                    cnn.Open();

                    string selectData = "SELECT * FROM issues WHERE  status = 'Not Returned' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, cnn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();


                        while (reader.Read())
                        {
                            DataIssueBooks dib = new DataIssueBooks();
                            dib.ID = (int)reader["id"];
                            dib.IssueID = reader["issue_id"].ToString();
                            dib.Name = reader["full_name"].ToString();
                            dib.Phone = reader["phone"].ToString();
                            dib.Email = reader["email"].ToString();
                            dib.BookTitle = reader["book_title"].ToString();
                            dib.Author = reader["author"].ToString();
                            dib.DateIssue = reader["issue_date"].ToString();
                            dib.DateReturn = reader["return_date"].ToString();

                            listData.Add(dib);
                        }

                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    cnn.Close();
                }
            }

            return listData;
        }

    }
}
