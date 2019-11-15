using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.PaymentService.Migrations
{
    public partial class PaymentMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Pid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<long>(nullable: false),
                    amount = table.Column<double>(nullable: false),
                    Mid = table.Column<long>(nullable: false),
                    Mentor_Amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Pid);
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Pid", "Mentor_Amount", "Mid", "Uid", "amount" },
                values: new object[] { 12L, 4589.0, 23L, 3L, 34567.889999999999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
