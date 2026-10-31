using BethanysPieShop.Migrations;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace BethanysPieShop.Controllers
{
    //[Route("pies")]

    public class PieController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        //[HttpGet("")]
        public async Task<IActionResult> List(string category)
        {
            IEnumerable<Pie> pies;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                pies = await _pieRepository.GetAllAsync();
                currentCategory = "All pies";
            }
            else
            {
                currentCategory=category.Trim();
                pies = await _pieRepository.GetByCategoryAsync(currentCategory);

                currentCategory = (await _categoryRepository.GetAllAsync()).FirstOrDefault(c => c.CategoryName == currentCategory).CategoryName;
            }

            return View(new PiesListViewModel
            {
                Pies = pies,
                CurrentCategory = currentCategory
            });
        }
        //[HttpGet("{id:int:min(1)}")]
        public async Task<IActionResult> Details(int id)
        {
            var pie = _pieRepository.GetByidAsync(id);
            if (pie == null)
                return NotFound();
            return View(pie.Result);
        }
    }
}