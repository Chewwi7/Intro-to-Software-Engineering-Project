using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers;

public class ConfirmOrderController : Controller
{
    private readonly ApplicationDbContext _context;

    public ConfirmOrderController(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Confirm()
    {
        return _context.Inventory != null ?
            View(await _context.Checkout.ToListAsync()) :
            Problem("Entity set 'ApplicationDbContext.Inventory'  is null.");
    }

    public void Create([Bind("SaleId,UserId,Users,InventoryId,Inventorys, SoldDate, StreetName, CityName, StateName, ZipCode,PhoneNumber,CreditCardNumber, ExpirationDate, CVV,ShippingTypeId, Shipping,tax, subtotal, total")] Sales sales){
        if (ModelState.IsValid)
        {
            _context.Add(sales);
            _context.SaveChangesAsync();
        }
    }
}