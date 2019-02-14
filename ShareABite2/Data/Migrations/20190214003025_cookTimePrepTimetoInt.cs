using Microsoft.EntityFrameworkCore.Migrations;

namespace ShareABite2.Data.Migrations
{
    public partial class cookTimePrepTimetoInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PrepTime",
                table: "RecipeModel",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CookTime",
                table: "RecipeModel",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PrepTime",
                table: "RecipeModel",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "CookTime",
                table: "RecipeModel",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
