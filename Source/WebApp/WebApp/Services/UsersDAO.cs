using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Services;

public class UsersDAO
{
    private string connectionString = "Data Source=identifier.db";

    public bool FindUserByNameAndPassword(Users user)
    {
        bool success = false;
        string sqlStatement = "SELECT * from Users WHERE username = @username AND password = @password ";

        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            SqliteCommand command = new SqliteCommand(sqlStatement, connection );

            command.Parameters.Add("@username", SqliteType.Text).Value = user.username;
            command.Parameters.Add("@password", SqliteType.Text).Value = user.password;

            try
            {
                connection.Open();
                SqliteDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    success = true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

        }

        return success;



    }
    
    
}