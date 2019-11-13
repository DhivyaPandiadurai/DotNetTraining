using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderProject.Migrations
{
    public partial class OrderMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Iid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iname = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Iid);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Orderid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iid = table.Column<int>(nullable: false),
                    ODate = table.Column<DateTime>(nullable: false),
                    DDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Orderid);
                    table.ForeignKey(
                        name: "FK_Order_Item_Iid",
                        column: x => x.Iid,
                        principalTable: "Item",
                        principalColumn: "Iid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Iid", "Iname", "Price" },
                values: new object[] { 1, "Nippon Blobby", 200 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Iid", "Iname", "Price" },
                values: new object[] { 2, "Smiley", 250 });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Orderid", "DDate", "Iid", "ODate" },
                values: new object[] { 1, new DateTime(2019, 11, 19, 17, 20, 49, 490, DateTimeKind.Local).AddTicks(4738), 1, new DateTime(2019, 11, 12, 17, 20, 49, 489, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Orderid", "DDate", "Iid", "ODate" },
                values: new object[] { 2, new DateTime(2019, 11, 19, 17, 20, 49, 490, DateTimeKind.Local).AddTicks(6304), 2, new DateTime(2019, 11, 12, 17, 20, 49, 490, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Iid",
                table: "Order",
                column: "Iid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
