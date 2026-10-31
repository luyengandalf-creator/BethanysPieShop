using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable
#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional
namespace BethanysPieShop.Migrations
{
    /// <inheritdoc />
    public partial class DataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Fruit pies", null },
                    { 2, "Cheese cakes", null },
                    { 3, "Seasonal pies", null }
                });
            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, null, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.", "Apple Pie", 12.95m, "Our famous apple pies!" },
                    { 2, null, 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/chocolatecheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/chocolatecheesecake.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.", "Chcolate Cheese Cake", 18.95m, "You'll love it!" },
                    { 3, null, 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.", "Rhubarb Pie", 15.95m, "You'll love it!" },
                    { 4, null, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.", "Pumpkin Pie", 12.95m, "You'll love it!" },
                    { 5, null, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.", "Strawberry Pie", 15.95m, "You'll love it!" },
                    { 6, null, 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.", "Strawberry Cheese Cake", 18.95m, "You'll love it!" },
                    { 7, null, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Pastry topping sweet roll. Sweet roll chocolate cake sweet roll.", "Cherry Pie", 15.95m, "You'll love it!" }
                });
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1);
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5);
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6);
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7);
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
