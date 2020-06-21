using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMarket.Migrations
{
    public partial class Refs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CPU_ProductRange_ProductRangeId",
                table: "CPU");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_ProductRange_ProductRangeId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_MB_ProductRange_ProductRangeId",
                table: "MB");

            migrationBuilder.DropColumn(
                name: "Id_PRange",
                table: "MB");

            migrationBuilder.DropColumn(
                name: "Id_PRange",
                table: "GPU");

            migrationBuilder.DropColumn(
                name: "Id_PRange",
                table: "CPU");

            migrationBuilder.AlterColumn<int>(
                name: "ProductRangeId",
                table: "MB",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductRangeId",
                table: "GPU",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductRangeId",
                table: "CPU",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CPU_ProductRange_ProductRangeId",
                table: "CPU",
                column: "ProductRangeId",
                principalTable: "ProductRange",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_ProductRange_ProductRangeId",
                table: "GPU",
                column: "ProductRangeId",
                principalTable: "ProductRange",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MB_ProductRange_ProductRangeId",
                table: "MB",
                column: "ProductRangeId",
                principalTable: "ProductRange",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CPU_ProductRange_ProductRangeId",
                table: "CPU");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_ProductRange_ProductRangeId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_MB_ProductRange_ProductRangeId",
                table: "MB");

            migrationBuilder.AlterColumn<int>(
                name: "ProductRangeId",
                table: "MB",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Id_PRange",
                table: "MB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProductRangeId",
                table: "GPU",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Id_PRange",
                table: "GPU",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProductRangeId",
                table: "CPU",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Id_PRange",
                table: "CPU",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CPU_ProductRange_ProductRangeId",
                table: "CPU",
                column: "ProductRangeId",
                principalTable: "ProductRange",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_ProductRange_ProductRangeId",
                table: "GPU",
                column: "ProductRangeId",
                principalTable: "ProductRange",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MB_ProductRange_ProductRangeId",
                table: "MB",
                column: "ProductRangeId",
                principalTable: "ProductRange",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
