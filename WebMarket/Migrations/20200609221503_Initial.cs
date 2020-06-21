using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMarket.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductRange",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorCode = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRange", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPU",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    MarketEntryDate = table.Column<string>(nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    Id_PRange = table.Column<int>(nullable: false),
                    ProductRangeId = table.Column<int>(nullable: true),
                    Socket = table.Column<string>(maxLength: 15, nullable: false),
                    NumberCores = table.Column<byte>(maxLength: 6, nullable: false),
                    MaximumNumberThreads = table.Column<byte>(maxLength: 6, nullable: false),
                    Baseclock = table.Column<string>(maxLength: 15, nullable: false),
                    MaximumFrequency = table.Column<string>(maxLength: 10, nullable: false),
                    L2cache = table.Column<string>(maxLength: 6, nullable: false),
                    L3cache = table.Column<string>(maxLength: 6, nullable: false),
                    MemorySupport = table.Column<string>(maxLength: 6, nullable: false),
                    NumberOfChannels = table.Column<string>(maxLength: 2, nullable: false),
                    MaxMemoryFrequency = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPU", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPU_ProductRange_ProductRangeId",
                        column: x => x.ProductRangeId,
                        principalTable: "ProductRange",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GPU",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    MarketEntryDate = table.Column<string>(nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    Id_PRange = table.Column<int>(nullable: false),
                    ProductRangeId = table.Column<int>(nullable: true),
                    Interface = table.Column<string>(maxLength: 20, nullable: false),
                    Manufacturer = table.Column<string>(maxLength: 6, nullable: false),
                    GPU = table.Column<string>(maxLength: 30, nullable: false),
                    OverclockedVersion = table.Column<bool>(nullable: false),
                    Frequency = table.Column<string>(maxLength: 10, nullable: false),
                    TurboFrequency = table.Column<string>(maxLength: 10, nullable: false),
                    NumberOfStreamProcessors = table.Column<int>(nullable: false),
                    VideoMemory = table.Column<string>(maxLength: 8, nullable: false),
                    TypeMemory = table.Column<string>(maxLength: 6, nullable: false),
                    MemoryFrequency = table.Column<string>(maxLength: 10, nullable: false),
                    MemoryBusWidth = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPU", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GPU_ProductRange_ProductRangeId",
                        column: x => x.ProductRangeId,
                        principalTable: "ProductRange",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    MarketEntryDate = table.Column<string>(nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    Id_PRange = table.Column<int>(nullable: false),
                    ProductRangeId = table.Column<int>(nullable: true),
                    ProcessorSupport = table.Column<string>(maxLength: 6, nullable: false),
                    Socket = table.Column<string>(maxLength: 15, nullable: false),
                    Chipset = table.Column<string>(maxLength: 20, nullable: false),
                    FormFactor = table.Column<string>(maxLength: 10, nullable: false),
                    Backlight = table.Column<bool>(nullable: false),
                    MemoryType = table.Column<string>(maxLength: 10, nullable: false),
                    MemorySlots = table.Column<byte>(maxLength: 2, nullable: false),
                    MaxMemoryCapacity = table.Column<string>(maxLength: 8, nullable: false),
                    MemoryMode = table.Column<string>(maxLength: 30, nullable: false),
                    MaxMemoryFrequency = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MB_ProductRange_ProductRangeId",
                        column: x => x.ProductRangeId,
                        principalTable: "ProductRange",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    IdProduct = table.Column<int>(nullable: false),
                    ProductsId = table.Column<int>(nullable: true),
                    BasketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductItem_Basket_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Basket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductItem_ProductRange_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "ProductRange",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CPU_ProductRangeId",
                table: "CPU",
                column: "ProductRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_ProductRangeId",
                table: "GPU",
                column: "ProductRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_MB_ProductRangeId",
                table: "MB",
                column: "ProductRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItem_BasketId",
                table: "ProductItem",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItem_ProductsId",
                table: "ProductItem",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPU");

            migrationBuilder.DropTable(
                name: "GPU");

            migrationBuilder.DropTable(
                name: "MB");

            migrationBuilder.DropTable(
                name: "ProductItem");

            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropTable(
                name: "ProductRange");
        }
    }
}
