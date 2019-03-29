using Microsoft.EntityFrameworkCore.Migrations;

namespace HtmlHelpersCore2.Migrations
{
    public partial class modelTweaks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserEstadoCivil",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "isDormir",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isMusica",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isNetflix",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isProgramar",
                table: "Users",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDormir",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "isMusica",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "isNetflix",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "isProgramar",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "UserEstadoCivil",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
