using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMarket.Migrations
{
    public partial class ProdItem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TypeObj",
                table: "ProductRange",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BasketId",
                table: "ProductItem",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductItem",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Basket",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeObj",
                table: "ProductRange");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductItem");

            migrationBuilder.AlterColumn<int>(
                name: "BasketId",
                table: "ProductItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Basket",
                type: "int",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
