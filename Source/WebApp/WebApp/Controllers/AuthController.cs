using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

namespace WebApp.Controllers;

public class AuthController : Controller
{
    
    

    public IActionResult LoginRegistration()
    {
        return View();
    }

    public IActionResult LoginSuccess()
    {
        return View("");
    }

    
}