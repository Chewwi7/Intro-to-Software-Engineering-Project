using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CheckoutController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Checkout
        public async Task<IActionResult> Index()
        {
              return _context.Checkout != null ? 
                          View(await _context.Checkout.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Checkout'  is null.");
        }

        // GET: Checkout/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Checkout == null)
            {
                return NotFound();
            }

            var checkout = await _context.Checkout
                .FirstOrDefaultAsync(m => m.CheckoutId == id);
            if (checkout == null)
            {
                return NotFound();
            }

            return View(checkout);
        }

        // GET: Checkout/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Checkout/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CheckoutId,InventoryName,InventoryPic,InventoryPrice")] Checkout checkout)
        {
            if (ModelState.IsValid)
            {
                _context.Add(checkout);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(checkout);
        }

        // GET: Checkout/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Checkout == null)
            {
                return NotFound();
            }

            var checkout = await _context.Checkout.FindAsync(id);
            if (checkout == null)
            {
                return NotFound();
            }
            return View(checkout);
        }

        // POST: Checkout/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CheckoutId,InventoryName,InventoryPic,InventoryPrice")] Checkout checkout)
        {
            if (id != checkout.CheckoutId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(checkout);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CheckoutExists(checkout.CheckoutId))
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
            return View(checkout);
        }

        // GET: Checkout/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Checkout == null)
            {
                return NotFound();
            }

            var checkout = await _context.Checkout
                .FirstOrDefaultAsync(m => m.CheckoutId == id);
            if (checkout == null)
            {
                return NotFound();
            }

            return View(checkout);
        }

        // POST: Checkout/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Checkout == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Checkout'  is null.");
            }
            var checkout = await _context.Checkout.FindAsync(id);
            if (checkout != null)
            {
                _context.Checkout.Remove(checkout);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CheckoutExists(int id)
        {
          return (_context.Checkout?.Any(e => e.CheckoutId == id)).GetValueOrDefault();
        }
    }
}