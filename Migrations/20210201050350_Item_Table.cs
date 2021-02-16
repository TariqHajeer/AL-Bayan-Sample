using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storeak.Demo.Api.Migrations
{
    public partial class Item_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    StoreId = table.Column<long>(nullable: false),
                    UPC = table.Column<string>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: true),
                    BuyPrice = table.Column<decimal>(type: "Money", nullable: false),
                    SellPrice = table.Column<decimal>(type: "Money", nullable: false),
                    CategorieId = table.Column<Guid>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategorieId",
                table: "Items",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UPC",
                table: "Items",
                column: "UPC",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
