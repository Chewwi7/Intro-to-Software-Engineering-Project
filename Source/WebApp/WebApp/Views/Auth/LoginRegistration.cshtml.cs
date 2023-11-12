using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.Sqlite;

namespace WebApp.Views.Auth
{
    public class LoginRegistrationModel : PageModel
    {
        private readonly string _connectionString = "Data Source=identifier.db";

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPostRegister(string username, string password)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = new SqliteCommand("INSERT INTO Users (username, password) VALUES (@username, @password)", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
            }

            return RedirectToPage("Index");
        }

        public IActionResult OnPostLogin(string username, string password)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = new SqliteCommand("SELECT * FROM Users WHERE username = @username AND password = @password", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return RedirectToPage("Index");
                    }
                }
            }

            ViewData["Error"] = "Invalid username or password";
            return Page();
        }
    }
}