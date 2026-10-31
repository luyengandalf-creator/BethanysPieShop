using BethanysPieShop.Models;
namespace BethanysPieShop.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; } = Enumerable.Empty<Pie>();
        public string? CurrentCategory { get; set; }
    }
}
