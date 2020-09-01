using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectStructure.WebAPI.Migrations
{
    public partial class AddIsActiveField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Projects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProjectDeadline" },
                values: new object[] { new DateTime(2020, 7, 16, 14, 22, 57, 598, DateTimeKind.Local).AddTicks(5617), new DateTime(2020, 7, 21, 14, 22, 57, 605, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ProjectDeadline" },
                values: new object[] { new DateTime(2020, 7, 16, 14, 22, 57, 605, DateTimeKind.Local).AddTicks(3892), new DateTime(2020, 7, 21, 14, 22, 57, 605, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 16, 14, 22, 57, 605, DateTimeKind.Local).AddTicks(5249), new DateTime(2020, 7, 20, 14, 22, 57, 605, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 16, 14, 22, 57, 605, DateTimeKind.Local).AddTicks(8318), new DateTime(2020, 7, 20, 14, 22, 57, 605, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtDate",
                value: new DateTime(2020, 7, 16, 14, 22, 57, 605, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAtDate",
                value: new DateTime(2020, 7, 16, 14, 22, 57, 606, DateTimeKind.Local).AddTicks(1051));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProjectDeadline" },
                values: new object[] { new DateTime(2020, 7, 16, 14, 18, 42, 177, DateTimeKind.Local).AddTicks(774), new DateTime(2020, 7, 21, 14, 18, 42, 187, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ProjectDeadline" },
                values: new object[] { new DateTime(2020, 7, 16, 14, 18, 42, 188, DateTimeKind.Local).AddTicks(577), new DateTime(2020, 7, 21, 14, 18, 42, 188, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 16, 14, 18, 42, 188, DateTimeKind.Local).AddTicks(3142), new DateTime(2020, 7, 20, 14, 18, 42, 188, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 16, 14, 18, 42, 188, DateTimeKind.Local).AddTicks(9008), new DateTime(2020, 7, 20, 14, 18, 42, 188, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtDate",
                value: new DateTime(2020, 7, 16, 14, 18, 42, 189, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAtDate",
                value: new DateTime(2020, 7, 16, 14, 18, 42, 189, DateTimeKind.Local).AddTicks(3586));
        }
    }
}
