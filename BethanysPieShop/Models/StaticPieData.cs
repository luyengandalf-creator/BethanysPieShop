using BethanysPieShop.Models;
namespace BethanysPieShop.Models
{
    public static class StaticPieData
    {
        private static readonly List<Pie> _pies = new() //Instantiate a List<Pie>
        {
            new Pie //Instantiate each Pie
            {
                PieId = 1,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "Our famous apple pies!",
                LongDescription = "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                IsPieOfTheWeek = true,
                InStock = true
            },
            new Pie
            {
                PieId = 2,
                Name = "Chcolate Cheese Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription = "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/chocolatecheesecake.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/chocolatecheesecakesmall.jpg",
                IsPieOfTheWeek = false,
                InStock = true
            },
            new Pie
            {
                PieId = 3,
                Name = "Rhubarb Pie",
                Price = 15.95M,
                ShortDescription = "You'll love it!",
                LongDescription = "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                IsPieOfTheWeek = true,
                InStock = true
            },
            new Pie
            {
                PieId = 4,
                Name = "Pumpkin Pie",
                Price = 12.95M,
                ShortDescription = "You'll love it!",
                LongDescription = "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                IsPieOfTheWeek = false,
                InStock = true
            },
            new Pie
            {
                PieId = 5,
                Name = "Strawberry Pie",
                Price = 15.95M,
                ShortDescription = "You'll love it!",
                LongDescription = "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                IsPieOfTheWeek = true,
                InStock = true
            },
            new Pie
            {
                PieId = 6,
                Name = "Strawberry Cheese Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription = "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                IsPieOfTheWeek = false,
                InStock = true
            },
            new Pie
            {
                PieId = 7,
                Name = "Cherry Pie",
                Price = 15.95M,
                ShortDescription = "You'll love it!",
                LongDescription = "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                IsPieOfTheWeek = true,
                InStock = true
            }
        };
        public static IEnumerable<Pie> GetAll() => _pies.OrderBy(p => p.PieId);
        public static Pie? GetById(int id) => _pies.FirstOrDefault(p => p.PieId == id);
    }
}
