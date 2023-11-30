using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class InventoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ApplicationDbContext _contextCheck;
        
        public InventoryController(ApplicationDbContext context, ApplicationDbContext contextCheck)
        {
            _context = context;
            _contextCheck = contextCheck;
        }

        public List<Inventory> GetInventory()
        {
            List<Inventory> inventory = new List<Inventory>();
            var connectionString = "Data Source=identifier.db";
            
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite(connectionString).Options;
            
            using var inv = new ApplicationDbContext(contextOptions);
            inventory = inv.Inventory.ToList();
            return inventory;
        }

        public List<Checkout> GetCheckout()
        {
            List<Checkout> checkout = new List<Checkout>();
            var connectionString = "Data Source=identifier.db";
            
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite(connectionString).Options;
            using var check = new ApplicationDbContext(contextOptions);
            checkout = check.Checkout.ToList();
            
            return checkout;
        }
        public ActionResult Index()
        {
            ViewData["IndexInventory"] = GetInventory();
            ViewData["IndexCheckout"] = GetCheckout();
            return View();
        }
        
        public async Task<IActionResult> IndexInv()
        {
              return _context.Inventory != null ? 
                          View(await _context.Inventory.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Inventory'  is null.");
        }

        // GET: Inventory/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Inventory == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventory
                .FirstOrDefaultAsync(m => m.InventoryId == id);
            if (inventory == null)
            {
                return NotFound();
            }

            return View(inventory);
        }

        // GET: Inventory/ShowItem
        public async Task<IActionResult> ShowItem()
        {
            return _context.Inventory != null ?
                        View() :
                        Problem("Entity set 'ApplicationDbContext.Inventory'  is null.");
        }

        // PoST: Jokes/ShowSearchResults
        public async Task<IActionResult> ShowSearchResults(String SearchPhrase)
        {
            return _context.Inventory != null ?
                        View("Search", await _context.Inventory.Where(i=>i.InventoryName.ToLower().Contains(SearchPhrase.ToLower())).ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Inventory'  is null.");
        }

        // GET: Inventory/Create
        
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inventory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InventoryId,InventoryName,InventoryDescription,InventoryPic,InventoryPrice")] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inventory);
        }
        
        // GET: Inventory/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Inventory == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventory.FindAsync(id);
            if (inventory == null)
            {
                return NotFound();
            }
            return View(inventory);
        }

        public async Task<IActionResult> CreateCartItem(int Id)
        {
            if (ModelState.IsValid)
            {
                if (Id < 0 || _context.Inventory == null)
                {
                    return NotFound();
                }

                var cart = _contextCheck.Checkout;
                var item =await _context.Inventory.FindAsync(Id);
                

                var newItem =new Checkout();
                string? name = item?.InventoryName;
                string? pic = item?.InventoryPic;
                decimal price = item.InventoryPrice;
                if (item != null)
                {
                    newItem = new Checkout(name, pic, price);
                }

                
                _contextCheck.Add(newItem);
                await _contextCheck.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InventoryId,InventoryName,InventoryDescription,InventoryPic,InventoryPrice")] Inventory inventory)
        {
            if (id != inventory.InventoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventoryExists(inventory.InventoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(inventory);
        }

        // GET: Inventory/Delete/5
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Inventory == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventory
                .FirstOrDefaultAsync(m => m.InventoryId == id);
            if (inventory == null)
            {
                return NotFound();
            }

            return View(inventory);
        }

        // POST: Inventory/Delete/5
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Inventory == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Inventory'  is null.");
            }
            var inventory = await _context.Inventory.FindAsync(id);
            if (inventory != null)
            {
                _context.Inventory.Remove(inventory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventoryExists(int id)
        {
          return (_context.Inventory?.Any(e => e.InventoryId == id)).GetValueOrDefault();
        }
    }
}
