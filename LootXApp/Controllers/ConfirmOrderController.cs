using Microsoft.AspNetCore.Mvc;
using LootXApp.Data;
using LootXApp.Models;

namespace LootXApp.Controllers;

public class ConfirmOrderController : Controller
{
    private readonly ApplicationDbContext _context;

    public ConfirmOrderController(ApplicationDbContext context)
    {
        _context = context;
    }
    public IActionResult Confirm()
    {
        return View();
    }
}