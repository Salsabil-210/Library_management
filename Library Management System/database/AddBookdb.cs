using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.database
{
    internal class AddBookdb
    {

        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\msilo\Documents\librarydb.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID { set; get; }
        public string Title { set; get; }
        public string Author { set; get; }
        public string Category { set; get; }
        public int Quantity { set; get; }
        public string Image { set; get; }

        public List<AddBookdb> addBooksData()
        {
            List<AddBookdb> listData1 = new List<AddBookdb>();

            if (cnn.State != ConnectionState.Open)
            {
                try
                {
                    cnn.Open();

                    string selectData = "SELECT * FROM books WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, cnn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();


                        while (reader.Read())
                        {
                            AddBookdb bookdb = new AddBookdb();
                            bookdb.ID = (int)reader["bookID"];
                            bookdb.Title = reader["title"].ToString();
                            bookdb.Author = reader["author"].ToString();
                            bookdb.Category = reader["category"].ToString();
                            bookdb.Quantity = (int)reader["quantity"]; 
                            bookdb.Image = reader["bookImage"].ToString();

                            listData1.Add(bookdb);
                        }

                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error conenecting Database: " + ex);
                }
                finally
                {
                    cnn.Close();
                }
            }
            return listData1;
        }

    }
}
