using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WSR2.Classes
{
    public class Database
    {
        public static string connectionPath = @"Data Source=PC\SQLEXPRESS;Initial Catalog=Trade;Integrated Security=True";
        public static string userId = string.Empty;

        public static bool LoginConfirmation(string Login, string Password)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string databaseCommand = "SELECT UserLogin, UserPassword, UserRole FROM [User]";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["UserLogin"].ToString() == Login && reader["UserPassword"].ToString() == Password)
                        {
                            userId = reader["UserRole"].ToString(); 
                            connection.Close();
                            return true;
                        }
                    }
                }

                connection.Close();
                return false;
            }
        }

        public static string GetUserRoleName(string userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string databaseCommand = $"SELECT RoleName FROM [Role] WHERE RoleID = {userId}";

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string userRoleName = null;

                    while (reader.Read())
                    {
                        userRoleName = reader["RoleName"].ToString();
                        connection.Close();
                        return userRoleName;
                    }
                }

                string statement = "Error";
                connection.Close();
                return statement;
            }
        }

        public static void GetProducts(DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string databaseCommand = "SELECT * FROM [Product]";
                DataTable dataTable = new DataTable();

                using (SqlCommand command = new SqlCommand(databaseCommand, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    command.ExecuteNonQuery();

                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;

                    connection.Close();
                }
            }
        }
    }
}
