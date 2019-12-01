using Microsoft.EntityFrameworkCore.Migrations;

namespace WS_BILER.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "CarModel",
                nullable: true,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "CarModel",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
