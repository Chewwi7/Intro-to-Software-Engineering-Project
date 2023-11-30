using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers;

public class ShippingPaymentController : Controller
{
    private readonly ApplicationDbContext _context;

    public ShippingPaymentController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    // GET
    public IActionResult Shipping()
    {
        return View();
    }
    
    // public async Task<IActionResult> Create([Bind("SaleId,UserId,Inventory,InventoryId,SoldDate,StreetName,CityName,StateName,ZipCode,PhoneNumber,CreditCardNumber,ExpirationDate,CVV,ShippingTypeId,Shipping,tax,subtotal,total")] Sales sales)
    // {
    //     if (ModelState.IsValid)
    //     {
    //         _context.Add(sales);
    //         await _context.SaveChangesAsync();
    //         return RedirectToAction(nameof(Models.Shipping));
    //     }
    //     return View(sales);
    // }
    
    [HttpPost]
    public IActionResult ProcessShipping(Sales model)
    {
        if (ModelState.IsValid)
        {
            // Access the selected shipping option from the model
            int selectedShippingOption = model.ShippingTypeId;
            

            // Update the database with the selected shipping option
            var sale = new Sales
            {
                ShippingTypeId = selectedShippingOption
            };

            _context.Sales.Add(sale);
            _context.SaveChanges();

            // Redirect to a success page or perform further operations
            return RedirectToAction("Index", "Home");
        }

        // If the model state is not valid, return to the same view with the model
        return View("Shipping", model);
    }
}