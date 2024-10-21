using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiProduct.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "Description", "Price" },
                values: new object[,]
                {
                    { new Guid("0dd8151c-5fdb-41a6-a6d7-21e30d6963ef"), "Laptop Dell XPS 13, 11ª Geração Intel Core i7, 16GB RAM, 512GB SSD", 8499.00m },
                    { new Guid("10507c9d-cf26-4d3d-963d-39f045ecf9f5"), "Placa de Vídeo NVIDIA GeForce RTX 3080, 10GB GDDR6X", 7499.00m },
                    { new Guid("2af1a308-ec3a-4ad1-9fba-7137740e522d"), "Cadeira Gamer DXRacer Formula Series, Ergonomica", 1699.00m },
                    { new Guid("2cce7a2a-5daa-4352-8aff-5a90bba52efb"), "Teclado Mecânico Corsair K95, RGB, Switch Cherry MX", 1199.00m },
                    { new Guid("3e680e1d-0d18-44b9-98c0-b2dd7228c1f1"), "SSD Samsung 970 EVO Plus 1TB, NVMe M.2", 1199.00m },
                    { new Guid("99dd86c8-2643-4e67-88e7-5a649b5c950b"), "Headset Gamer HyperX Cloud II, Surround 7.1, USB", 799.00m },
                    { new Guid("abe2182a-c093-4571-b7f3-2abe1f09f3aa"), "Mouse Logitech MX Master 3, Wireless, 4000 DPI", 499.00m },
                    { new Guid("ba3e3b61-5d20-4d3a-8787-be84b2a2ef66"), "Roteador Wi-Fi TP-Link Archer AX6000, Dual Band, 8 Antenas", 1299.00m },
                    { new Guid("cfb63739-81d0-4efa-aed4-9fef9b06b62e"), "Impressora Multifuncional HP DeskJet 2776, Wi-Fi, Jato de Tinta", 499.00m },
                    { new Guid("fd422584-3018-49a4-b8b0-de4813561a41"), "Monitor LG UltraWide 34'', WQHD, IPS, 75Hz", 3299.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
