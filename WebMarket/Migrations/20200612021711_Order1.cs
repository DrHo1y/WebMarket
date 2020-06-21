using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMarket.Migrations
{
    public partial class Order1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Surame",
                table: "Order");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Order");

            migrationBuilder.AlterColumn<long>(
                name: "Price",
                table: "OrderDetail",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Surame",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
