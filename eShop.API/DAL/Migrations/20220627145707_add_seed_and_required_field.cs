using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShop.API.DAL.Migrations
{
    public partial class add_seed_and_required_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Mark", "Name", "PictureUrl", "Price" },
                values: new object[] { 1, "Eligible for Shipping To Mars or somewhere else", 4.0499999999999998, "Vintage Typewriter to post awesome stories about UI design and webdev.", "https://www.wired.com/story/stay-in-the-moment-take-a-picture/", 49.5 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Mark", "Name", "PictureUrl", "Price" },
                values: new object[] { 2, "1258 bids, 359 watchers $5.95 for shipping", 4.5599999999999996, "Lee Pucker design. Leather botinki for handsome designers. Free shipping.", "https://www.wired.com/story/stay-in-the-moment-take-a-picture/", 13.949999999999999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
