using Microsoft.EntityFrameworkCore.Migrations;

namespace Reto.Payment.DAL.Migrations
{
    public partial class Facturas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacturaId",
                table: "PRODUCTS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_FacturaId",
                table: "PRODUCTS",
                column: "FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCTS_Facturas_FacturaId",
                table: "PRODUCTS",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCTS_Facturas_FacturaId",
                table: "PRODUCTS");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_PRODUCTS_FacturaId",
                table: "PRODUCTS");

            migrationBuilder.DropColumn(
                name: "FacturaId",
                table: "PRODUCTS");
        }
    }
}
