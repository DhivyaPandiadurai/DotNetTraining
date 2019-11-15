using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.TrainingService.Migrations
{
    public partial class TrainingMig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    TrainingID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UID = table.Column<long>(nullable: false),
                    MID = table.Column<long>(nullable: false),
                    SkillID = table.Column<long>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    timeslot = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    Progress = table.Column<long>(nullable: false),
                    rating = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.TrainingID);
                });

            migrationBuilder.InsertData(
                table: "Training",
                columns: new[] { "TrainingID", "EndDate", "MID", "Progress", "SkillID", "StartDate", "UID", "rating", "status", "timeslot" },
                values: new object[] { 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 122L, 25L, 345L, new DateTime(2017, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1234L, 3.5f, "Not Completed", "evening" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Training");
        }
    }
}
