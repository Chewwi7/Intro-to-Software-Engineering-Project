using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using WebApp.Models;
using Index = Microsoft.EntityFrameworkCore.Metadata.Internal.Index;
using WebApp.Views;
namespace WebApp.Controllers;

public class AuthController : Controller
{
    
    

    public IActionResult LoginRegistration()
    {
        return View();
    }

    public IActionResult LoginSuccess(Users users)
    {
        
        // ReSharper disable once Mvc.ViewNotResolved
        return View("Index", users);
    }

    
}