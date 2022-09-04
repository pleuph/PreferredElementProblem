using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreferredElementData.Migrations
{
    public partial class AddDesignIdIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Bricks_DesignId",
                table: "Bricks",
                column: "DesignId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Bricks_DesignId",
                table: "Bricks");
        }
    }
}
