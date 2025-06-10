using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.database
{
    internal class AddMembersdb
    {

        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\msilo\Documents\librarydb.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Gender { set; get; }

        public List<AddMembersdb> addMembersData()
        {
            List<AddMembersdb> listData = new List<AddMembersdb>();

            if (cnn.State != ConnectionState.Open)
            {
                try
                {
                    cnn.Open();

                    string selectData = "SELECT * FROM members WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, cnn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();


                        while (reader.Read())
                        {
                            AddMembersdb memberdb = new AddMembersdb();
                            memberdb.ID = (int)reader["MemberID"];
                            memberdb.Name = reader["name"].ToString();
                            memberdb.Email = reader["email"].ToString();
                            memberdb.Phone = reader["phone"].ToString();
                            memberdb.Gender = reader["gender"].ToString();

                            listData.Add(memberdb);
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
            return listData;
        }

    }
}
