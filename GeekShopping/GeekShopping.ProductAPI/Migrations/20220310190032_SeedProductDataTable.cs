using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 2L, "T-shirt", "Descriçao do produto, Descriçao do produto, Descriçao do produto, Descriçao do produto, ", "http://url", "Produto 1", 69.9m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2L);
        }
    }
}
