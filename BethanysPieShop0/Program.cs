using BethanysPieShop0.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseInMemoryDatabase("PieShopDb"));
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("PieShopDb0")));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Correct method to serve static files
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pie}/{action=List}/{id?}");
//.WithStaticAssets(); //Adding code to serve static assets from the wwwroot folder

app.Run();