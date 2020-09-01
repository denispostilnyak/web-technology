using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectStructure.WebAPI.Migrations
{
    public partial class AddDataAnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Projects",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Decription",
                table: "Projects",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProjectDeadline" },
                values: new object[] { new DateTime(2020, 7, 16, 15, 19, 9, 289, DateTimeKind.Local).AddTicks(7828), new DateTime(2020, 7, 21, 15, 19, 9, 297, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ProjectDeadline" },
                values: new object[] { new DateTime(2020, 7, 16, 15, 19, 9, 297, DateTimeKind.Local).AddTicks(8144), new DateTime(2020, 7, 21, 15, 19, 9, 297, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 16, 15, 19, 9, 297, DateTimeKind.Local).AddTicks(9925), new DateTime(2020, 7, 20, 15, 19, 9, 298, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 16, 15, 19, 9, 298, DateTimeKind.Local).AddTicks(3706), new DateTime(2020, 7, 20, 15, 19, 9, 298, DateTimeKind.Local).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAtDate",
                value: new DateTime(2020, 7, 16, 15, 19, 9, 298, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAtDate",
                value: new DateTime(2020, 7, 16, 15, 19, 9, 298, DateTimeKind.Local).AddTicks(6516));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 5000);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Decription",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 5000);

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
    }
}
