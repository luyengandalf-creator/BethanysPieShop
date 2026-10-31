using Microsoft.EntityFrameworkCore;
namespace BethanysPieShop0.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Fruit pies" },
                new Category { CategoryId = 2, CategoryName = "Cheese cakes" },
                new Category { CategoryId = 3, CategoryName = "Seasonal pies" }
          );
            modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    PieId = 1,
                    Name = "Apple Pie",
                    Price = 12.95M,
                    ShortDescription = "Our famous apple pies!",
                    LongDescription = "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.",
                    CategoryId = 1,
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
                        CategoryId = 2,
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
                        CategoryId = 3,
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
                        CategoryId = 1,
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
                        CategoryId = 1,
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
                        CategoryId = 2,
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
                        CategoryId = 1,
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                        ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                        IsPieOfTheWeek = true,
                        InStock = true
                    }
                );
        }
    }
}
