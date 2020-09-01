using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectStructure.WebAPI.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedAtDate", "Name" },
                values: new object[] { 1, new DateTime(2020, 7, 16, 14, 18, 42, 189, DateTimeKind.Local).AddTicks(1486), "Team 1" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedAtDate", "Name" },
                values: new object[] { 2, new DateTime(2020, 7, 16, 14, 18, 42, 189, DateTimeKind.Local).AddTicks(3586), "Team 2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { 1, new DateTime(2000, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "some", "Denis", "Pos", new DateTime(2010, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { 2, new DateTime(2001, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "some", "Vasya", "Ken", new DateTime(2010, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Decription", "Name", "ProjectDeadline", "TeamId" },
                values: new object[] { 1, 1, new DateTime(2020, 7, 16, 14, 18, 42, 177, DateTimeKind.Local).AddTicks(774), " Some", "First project", new DateTime(2020, 7, 21, 14, 18, 42, 187, DateTimeKind.Local).AddTicks(8091), 1 });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Decription", "Name", "ProjectDeadline", "TeamId" },
                values: new object[] { 2, 2, new DateTime(2020, 7, 16, 14, 18, 42, 188, DateTimeKind.Local).AddTicks(577), " Some", "Second project", new DateTime(2020, 7, 21, 14, 18, 42, 188, DateTimeKind.Local).AddTicks(735), 2 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerfomerId", "ProjectId", "State" },
                values: new object[] { 1, new DateTime(2020, 7, 16, 14, 18, 42, 188, DateTimeKind.Local).AddTicks(3142), "Some", new DateTime(2020, 7, 20, 14, 18, 42, 188, DateTimeKind.Local).AddTicks(4169), "First task", 1, 1, 0 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerfomerId", "ProjectId", "State" },
                values: new object[] { 2, new DateTime(2020, 7, 16, 14, 18, 42, 188, DateTimeKind.Local).AddTicks(9008), "Some", new DateTime(2020, 7, 20, 14, 18, 42, 188, DateTimeKind.Local).AddTicks(9090), "Second task", 2, 2, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
