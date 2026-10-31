using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace BethanysPieShop3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        /*public IActionResult Index()
        {
            IEnumerable<Pie> piesOfTheWeek = (IEnumerable<Pie>)_pieRepository.PiesOfTheWeek;
            //var homeViewModel = new HomeViewModel(piesOfTheWeek);
            return View(new HomeViewModel
            {
                PiesOfTheWeek = piesOfTheWeek
            });
            
        }*/
        public async Task<IActionResult> Index(string category)
        {
            IEnumerable<Pie> pies;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                pies = await _pieRepository.GetPiesOfTheWeek();
                currentCategory = "All pies";
            }
            else
            {
                currentCategory = category.Trim();
                pies = await _pieRepository.GetByCategoryAsync(currentCategory);
            }
            return View(new HomeViewModel(pies));
        }
    }
}