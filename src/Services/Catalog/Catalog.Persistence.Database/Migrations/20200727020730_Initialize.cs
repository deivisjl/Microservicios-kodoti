using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 725m },
                    { 73, "Description for product 73", "Product 73", 223m },
                    { 72, "Description for product 72", "Product 72", 669m },
                    { 71, "Description for product 71", "Product 71", 319m },
                    { 70, "Description for product 70", "Product 70", 250m },
                    { 69, "Description for product 69", "Product 69", 800m },
                    { 68, "Description for product 68", "Product 68", 417m },
                    { 67, "Description for product 67", "Product 67", 951m },
                    { 66, "Description for product 66", "Product 66", 868m },
                    { 65, "Description for product 65", "Product 65", 977m },
                    { 64, "Description for product 64", "Product 64", 240m },
                    { 63, "Description for product 63", "Product 63", 501m },
                    { 62, "Description for product 62", "Product 62", 349m },
                    { 61, "Description for product 61", "Product 61", 747m },
                    { 60, "Description for product 60", "Product 60", 312m },
                    { 59, "Description for product 59", "Product 59", 414m },
                    { 58, "Description for product 58", "Product 58", 574m },
                    { 57, "Description for product 57", "Product 57", 198m },
                    { 56, "Description for product 56", "Product 56", 974m },
                    { 55, "Description for product 55", "Product 55", 699m },
                    { 54, "Description for product 54", "Product 54", 890m },
                    { 53, "Description for product 53", "Product 53", 486m },
                    { 74, "Description for product 74", "Product 74", 477m },
                    { 52, "Description for product 52", "Product 52", 693m },
                    { 75, "Description for product 75", "Product 75", 963m },
                    { 77, "Description for product 77", "Product 77", 718m },
                    { 98, "Description for product 98", "Product 98", 891m },
                    { 97, "Description for product 97", "Product 97", 178m },
                    { 96, "Description for product 96", "Product 96", 601m },
                    { 95, "Description for product 95", "Product 95", 620m },
                    { 94, "Description for product 94", "Product 94", 885m },
                    { 93, "Description for product 93", "Product 93", 242m },
                    { 92, "Description for product 92", "Product 92", 153m },
                    { 91, "Description for product 91", "Product 91", 878m },
                    { 90, "Description for product 90", "Product 90", 635m },
                    { 89, "Description for product 89", "Product 89", 836m },
                    { 88, "Description for product 88", "Product 88", 739m },
                    { 87, "Description for product 87", "Product 87", 396m },
                    { 86, "Description for product 86", "Product 86", 189m },
                    { 85, "Description for product 85", "Product 85", 581m },
                    { 84, "Description for product 84", "Product 84", 881m },
                    { 83, "Description for product 83", "Product 83", 445m },
                    { 82, "Description for product 82", "Product 82", 768m },
                    { 81, "Description for product 81", "Product 81", 681m },
                    { 80, "Description for product 80", "Product 80", 404m },
                    { 79, "Description for product 79", "Product 79", 101m },
                    { 78, "Description for product 78", "Product 78", 299m },
                    { 76, "Description for product 76", "Product 76", 630m },
                    { 51, "Description for product 51", "Product 51", 961m },
                    { 50, "Description for product 50", "Product 50", 803m },
                    { 49, "Description for product 49", "Product 49", 380m },
                    { 22, "Description for product 22", "Product 22", 751m },
                    { 21, "Description for product 21", "Product 21", 211m },
                    { 20, "Description for product 20", "Product 20", 814m },
                    { 19, "Description for product 19", "Product 19", 744m },
                    { 18, "Description for product 18", "Product 18", 321m },
                    { 17, "Description for product 17", "Product 17", 226m },
                    { 16, "Description for product 16", "Product 16", 847m },
                    { 15, "Description for product 15", "Product 15", 226m },
                    { 14, "Description for product 14", "Product 14", 410m },
                    { 13, "Description for product 13", "Product 13", 853m },
                    { 12, "Description for product 12", "Product 12", 581m },
                    { 11, "Description for product 11", "Product 11", 651m },
                    { 10, "Description for product 10", "Product 10", 760m },
                    { 9, "Description for product 9", "Product 9", 684m },
                    { 8, "Description for product 8", "Product 8", 187m },
                    { 7, "Description for product 7", "Product 7", 975m },
                    { 6, "Description for product 6", "Product 6", 862m },
                    { 5, "Description for product 5", "Product 5", 931m },
                    { 4, "Description for product 4", "Product 4", 875m },
                    { 3, "Description for product 3", "Product 3", 930m },
                    { 2, "Description for product 2", "Product 2", 414m },
                    { 23, "Description for product 23", "Product 23", 316m },
                    { 24, "Description for product 24", "Product 24", 456m },
                    { 25, "Description for product 25", "Product 25", 560m },
                    { 26, "Description for product 26", "Product 26", 718m },
                    { 48, "Description for product 48", "Product 48", 446m },
                    { 47, "Description for product 47", "Product 47", 137m },
                    { 46, "Description for product 46", "Product 46", 256m },
                    { 45, "Description for product 45", "Product 45", 454m },
                    { 44, "Description for product 44", "Product 44", 116m },
                    { 43, "Description for product 43", "Product 43", 132m },
                    { 42, "Description for product 42", "Product 42", 580m },
                    { 41, "Description for product 41", "Product 41", 850m },
                    { 40, "Description for product 40", "Product 40", 367m },
                    { 39, "Description for product 39", "Product 39", 197m },
                    { 99, "Description for product 99", "Product 99", 139m },
                    { 38, "Description for product 38", "Product 38", 557m },
                    { 36, "Description for product 36", "Product 36", 976m },
                    { 35, "Description for product 35", "Product 35", 610m },
                    { 34, "Description for product 34", "Product 34", 535m },
                    { 33, "Description for product 33", "Product 33", 629m },
                    { 32, "Description for product 32", "Product 32", 783m },
                    { 31, "Description for product 31", "Product 31", 783m },
                    { 30, "Description for product 30", "Product 30", 543m },
                    { 29, "Description for product 29", "Product 29", 685m },
                    { 28, "Description for product 28", "Product 28", 725m },
                    { 27, "Description for product 27", "Product 27", 214m },
                    { 37, "Description for product 37", "Product 37", 628m },
                    { 100, "Description for product 100", "Product 100", 586m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 12 },
                    { 73, 73, 0 },
                    { 72, 72, 2 },
                    { 71, 71, 12 },
                    { 70, 70, 7 },
                    { 69, 69, 1 },
                    { 68, 68, 2 },
                    { 67, 67, 10 },
                    { 66, 66, 2 },
                    { 65, 65, 13 },
                    { 64, 64, 16 },
                    { 63, 63, 13 },
                    { 62, 62, 19 },
                    { 61, 61, 8 },
                    { 60, 60, 12 },
                    { 59, 59, 8 },
                    { 58, 58, 9 },
                    { 57, 57, 5 },
                    { 56, 56, 19 },
                    { 55, 55, 14 },
                    { 54, 54, 15 },
                    { 53, 53, 0 },
                    { 74, 74, 8 },
                    { 52, 52, 6 },
                    { 75, 75, 14 },
                    { 77, 77, 14 },
                    { 98, 98, 2 },
                    { 97, 97, 11 },
                    { 96, 96, 0 },
                    { 95, 95, 7 },
                    { 94, 94, 3 },
                    { 93, 93, 1 },
                    { 92, 92, 1 },
                    { 91, 91, 2 },
                    { 90, 90, 9 },
                    { 89, 89, 11 },
                    { 88, 88, 12 },
                    { 87, 87, 9 },
                    { 86, 86, 9 },
                    { 85, 85, 18 },
                    { 84, 84, 13 },
                    { 83, 83, 4 },
                    { 82, 82, 2 },
                    { 81, 81, 4 },
                    { 80, 80, 0 },
                    { 79, 79, 18 },
                    { 78, 78, 19 },
                    { 76, 76, 11 },
                    { 51, 51, 6 },
                    { 50, 50, 1 },
                    { 49, 49, 8 },
                    { 22, 22, 13 },
                    { 21, 21, 16 },
                    { 20, 20, 14 },
                    { 19, 19, 4 },
                    { 18, 18, 15 },
                    { 17, 17, 13 },
                    { 16, 16, 2 },
                    { 15, 15, 14 },
                    { 14, 14, 10 },
                    { 13, 13, 8 },
                    { 12, 12, 19 },
                    { 11, 11, 11 },
                    { 10, 10, 9 },
                    { 9, 9, 0 },
                    { 8, 8, 8 },
                    { 7, 7, 12 },
                    { 6, 6, 2 },
                    { 5, 5, 19 },
                    { 4, 4, 4 },
                    { 3, 3, 8 },
                    { 2, 2, 7 },
                    { 23, 23, 2 },
                    { 24, 24, 19 },
                    { 25, 25, 15 },
                    { 26, 26, 7 },
                    { 48, 48, 12 },
                    { 47, 47, 2 },
                    { 46, 46, 15 },
                    { 45, 45, 0 },
                    { 44, 44, 2 },
                    { 43, 43, 19 },
                    { 42, 42, 4 },
                    { 41, 41, 19 },
                    { 40, 40, 16 },
                    { 39, 39, 15 },
                    { 99, 99, 9 },
                    { 38, 38, 10 },
                    { 36, 36, 7 },
                    { 35, 35, 8 },
                    { 34, 34, 6 },
                    { 33, 33, 8 },
                    { 32, 32, 9 },
                    { 31, 31, 15 },
                    { 30, 30, 4 },
                    { 29, 29, 15 },
                    { 28, 28, 13 },
                    { 27, 27, 14 },
                    { 37, 37, 10 },
                    { 100, 100, 18 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
