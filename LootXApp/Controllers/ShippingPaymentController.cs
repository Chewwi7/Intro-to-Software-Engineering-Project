using Microsoft.AspNetCore.Mvc;

namespace LootXApp.Controllers;

public class ShippingPaymentController : Controller
{
    // GET
    public IActionResult Shipping()
    {
        return View();
    }
}