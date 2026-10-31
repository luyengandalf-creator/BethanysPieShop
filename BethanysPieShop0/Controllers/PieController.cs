using BethanysPieShop0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop0.Controllers
{
    public class PieController : Controller
    {
        private readonly AppDbContext _context;
        public PieController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> List()
        {
            ViewBag.CurrentCategory = "All pies";
            var pies = await _context.Pies
                       .AsNoTracking()
                       .OrderBy((Pie p) => p.PieId)
                       .ToListAsync();
            string category = "All pies";
            return View(pies);
        }
        public async Task<IActionResult> Details(int id)
        {
            Models.Pie pie = await _context.Pies
                       .AsNoTracking()
                       .FirstOrDefaultAsync((Pie p) => p.PieId == id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }
    }
}