using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;
namespace BethanysPieShop.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
     }
}