using Microsoft.EntityFrameworkCore.Migrations;

namespace ShareABite2.Data.Migrations
{
    public partial class RecipeTypeanddifficulty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "RecipeModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecipeType",
                table: "RecipeModel",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "RecipeModel");

            migrationBuilder.DropColumn(
                name: "RecipeType",
                table: "RecipeModel");
        }
    }
}
