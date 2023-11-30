using Microsoft.AspNetCore.Mvc;

namespace LootXApp.Controllers;

public class OrderCompleteController : Controller
{
    public IActionResult Complete()
    {
        return View();
    }
}