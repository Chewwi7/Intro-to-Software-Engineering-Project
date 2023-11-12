using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

namespace WebApp.Controllers;

public class AuthController : Controller
{
    
    private string _connectionString = "Data Source=identifier.db";

    public IActionResult LoginRegistration()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(string username, string password)
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var command = new SqliteCommand("INSERT INTO Users (username, password) VALUES (@username, @password)", connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.ExecuteNonQuery();
        }

        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public IActionResult LoginRegistration(string username, string password)
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
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        ViewData["Error"] = "Invalid username or password";
        return View();
    }
}