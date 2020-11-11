using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VendingMachine.Persistance.EntityFramework.Migrations
{
    public partial class initail_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Statuses",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    CreatorUserId = table.Column<Guid>(nullable: true),
                    LastModifierUserId = table.Column<Guid>(nullable: true),
                    ModicationTime = table.Column<DateTime>(nullable: true),
                    DeleterUserId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    StatusCode = table.Column<int>(nullable: false),
                    StatusName = table.Column<string>(maxLength: 50, nullable: false),
                    StatusDescription = table.Column<string>(maxLength: 500, nullable: true),
                    ActiveStatus = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<Guid>(nullable: true),
                    LastModifierUserId = table.Column<Guid>(nullable: true),
                    ModicationTime = table.Column<DateTime>(nullable: true),
                    DeleterUserId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StatusId = table.Column<long>(nullable: false),
                    ImageName = table.Column<string>(maxLength: 100, nullable: false),
                    ImageData = table.Column<byte[]>(nullable: false),
                    ImageDescription = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "dbo",
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<Guid>(nullable: true),
                    LastModifierUserId = table.Column<Guid>(nullable: true),
                    ModicationTime = table.Column<DateTime>(nullable: true),
                    DeleterUserId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StatusId = table.Column<long>(nullable: false),
                    ProductImageId = table.Column<Guid>(nullable: true),
                    ProductName = table.Column<string>(maxLength: 100, nullable: false),
                    ProductDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    ProductPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductImages_ProductImageId",
                        column: x => x.ProductImageId,
                        principalSchema: "dbo",
                        principalTable: "ProductImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "dbo",
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StatusId = table.Column<long>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<decimal>(nullable: false),
                    Change = table.Column<decimal>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "dbo",
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockInventories",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<Guid>(nullable: true),
                    LastModifierUserId = table.Column<Guid>(nullable: true),
                    ModicationTime = table.Column<DateTime>(nullable: true),
                    DeleterUserId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StatusId = table.Column<long>(nullable: false),
                    TotalItems = table.Column<int>(nullable: false),
                    IsOutOfStock = table.Column<bool>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockInventories_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "dbo",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockInventories_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "dbo",
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_StatusId",
                schema: "dbo",
                table: "ProductImages",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductImageId",
                schema: "dbo",
                table: "Products",
                column: "ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StatusId",
                schema: "dbo",
                table: "Products",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                schema: "dbo",
                table: "Sales",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_StatusId",
                schema: "dbo",
                table: "Sales",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_StatusCode",
                schema: "dbo",
                table: "Statuses",
                column: "StatusCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockInventories_ProductId",
                schema: "dbo",
                table: "StockInventories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockInventories_StatusId",
                schema: "dbo",
                table: "StockInventories",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StockInventories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductImages",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Statuses",
                schema: "dbo");
        }
    }
}
