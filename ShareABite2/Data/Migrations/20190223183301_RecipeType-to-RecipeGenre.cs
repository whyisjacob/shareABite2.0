using Microsoft.EntityFrameworkCore.Migrations;

namespace ShareABite2.Data.Migrations
{
    public partial class RecipeTypetoRecipeGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecipeType",
                table: "RecipeModel",
                newName: "RecipeGenre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecipeGenre",
                table: "RecipeModel",
                newName: "RecipeType");
        }
    }
}
