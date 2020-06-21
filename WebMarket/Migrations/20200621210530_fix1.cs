using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMarket.Migrations
{
    public partial class fix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_ProductRange_PRangeId",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_PRangeId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "PRangeId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PRangeId",
                table: "OrderDetail",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_PRangeId",
                table: "OrderDetail",
                column: "PRangeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_ProductRange_PRangeId",
                table: "OrderDetail",
                column: "PRangeId",
                principalTable: "ProductRange",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
