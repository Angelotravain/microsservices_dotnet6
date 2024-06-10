using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.Products.Api.Migrations
{
    public partial class InitialCreate03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "produto",
                columns: new[] { "id", "nome_categoria", "escricao", "img_url", "nome", "preco" },
                values: new object[] { 4L, "T-shirt", "", "", "Name", 0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 4L);
        }
    }
}
