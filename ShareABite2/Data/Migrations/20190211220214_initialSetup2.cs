using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShareABite2.Data.Migrations
{
    public partial class initialSetup2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecipeModel",
                columns: table => new
                {
                    RecipeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RecipeName = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateEdited = table.Column<DateTime>(nullable: false),
                    Story = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    OvenTemp = table.Column<string>(nullable: true),
                    Servings = table.Column<string>(nullable: true),
                    PrepTime = table.Column<string>(nullable: true),
                    CookTime = table.Column<string>(nullable: true),
                    Public = table.Column<bool>(nullable: false),
                    IngredientsJson = table.Column<string>(nullable: true),
                    DirectionsJson = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeModel", x => x.RecipeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeModel");
        }
    }
}
