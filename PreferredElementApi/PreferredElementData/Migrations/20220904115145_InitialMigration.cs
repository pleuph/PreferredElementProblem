using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreferredElementData.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bricks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bricks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrickColorCodes",
                columns: table => new
                {
                    BrickId = table.Column<int>(type: "int", nullable: false),
                    ColorCodeId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrickColorCodes", x => new { x.BrickId, x.Order, x.ColorCodeId });
                    table.ForeignKey(
                        name: "FK_BrickColorCodes_Bricks_BrickId",
                        column: x => x.BrickId,
                        principalTable: "Bricks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrickColorCodes_ColorCodes_ColorCodeId",
                        column: x => x.ColorCodeId,
                        principalTable: "ColorCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemBrick",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    BrickId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemBrick", x => new { x.ItemId, x.BrickId });
                    table.ForeignKey(
                        name: "FK_ItemBrick_Bricks_BrickId",
                        column: x => x.BrickId,
                        principalTable: "Bricks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemBrick_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MasterData_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ColorCodes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Red" },
                    { 2, "Green" },
                    { 3, "Blue" },
                    { 4, "Yellow" },
                    { 5, "Orange" },
                    { 6, "Purple" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrickColorCodes_ColorCodeId",
                table: "BrickColorCodes",
                column: "ColorCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemBrick_BrickId",
                table: "ItemBrick",
                column: "BrickId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterData_ItemId",
                table: "MasterData",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrickColorCodes");

            migrationBuilder.DropTable(
                name: "ItemBrick");

            migrationBuilder.DropTable(
                name: "MasterData");

            migrationBuilder.DropTable(
                name: "ColorCodes");

            migrationBuilder.DropTable(
                name: "Bricks");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
