using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class Add_Coords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.AddColumn<int>(
                name: "Latitude",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Longitude",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 20, 2, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3604), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3611), 9 },
                    { 2, 6, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(2284), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(2342), 8 },
                    { 3, 11, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(2487), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(2501), 11 },
                    { 4, 6, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(2569), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(2752), 3 },
                    { 5, 10, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(2877), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(2886), 16 },
                    { 6, 4, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(2929), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(2937), 12 },
                    { 7, 3, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(2977), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(2985), 14 },
                    { 8, 16, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3027), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3035), 17 },
                    { 9, 8, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3075), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3082), 6 },
                    { 10, 5, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3123), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3131), 18 },
                    { 1, 20, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(151), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(1007), 16 },
                    { 12, 4, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3219), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3227), 18 },
                    { 13, 8, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3266), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3274), 8 },
                    { 14, 14, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3315), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3323), 10 },
                    { 15, 18, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3363), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3371), 4 },
                    { 16, 16, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3413), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3421), 1 },
                    { 17, 20, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3462), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3470), 9 },
                    { 18, 5, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3510), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3518), 21 },
                    { 19, 20, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3557), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3565), 4 },
                    { 11, 2, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3172), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3180), 2 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "In vitae aliquid porro.", new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(4036), 4, new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Et et est iste.", new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(7358), 4, new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Quia quia ipsa.", new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(7617), 12, new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Dolorem molestiae ut omnis maxime exercitationem sit.", new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(7921), 16, new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Ipsam dolorem enim exercitationem.", new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(8206), 1, new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Qui laboriosam aut voluptate iure veniam voluptatem corporis voluptate.", new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(8523), 8, new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Impedit maxime et.", new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(8903), 4, new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Ut perspiciatis deserunt.", new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(9122), 7, new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Amet maxime ex voluptate.", new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(9347), 20, new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Error ipsum quos ipsam et unde quia omnis qui.", new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(9662), 10, new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Nobis expedita sapiente quae in.", new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(9977), 6, new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Numquam iste quos et.", new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(216), 1, new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Modi rerum non voluptates in esse placeat quibusdam rerum.", new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(542), 9, new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Doloribus doloremque corporis eum quia dolores harum et atque modi.", new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(1032), 20, new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Odio fugiat facilis aut cum dolore iste id.", new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(1343), 19, new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Numquam nemo aut et.", new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(1581), 18, new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Eum ut quo.", new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(1805), 3, new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Qui ipsum aut consequuntur in iure repellat earum aut sed.", new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(2168), 12, new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Temporibus quia ut.", new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(2390), 8, new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Magni dolorem laborum perferendis magnam.", new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(2775), 14, new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 271, DateTimeKind.Local).AddTicks(3215), "https://s3.amazonaws.com/uifaces/faces/twitter/justinrhee/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(5908), "https://s3.amazonaws.com/uifaces/faces/twitter/cboller1/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6061), "https://s3.amazonaws.com/uifaces/faces/twitter/gojeanyn/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6167), "https://s3.amazonaws.com/uifaces/faces/twitter/jamiebrittain/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6234), "https://s3.amazonaws.com/uifaces/faces/twitter/terrorpixel/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6355), "https://s3.amazonaws.com/uifaces/faces/twitter/russell_baylis/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6499), "https://s3.amazonaws.com/uifaces/faces/twitter/ifarafonow/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6635), "https://s3.amazonaws.com/uifaces/faces/twitter/abelcabans/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6737), "https://s3.amazonaws.com/uifaces/faces/twitter/alagoon/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6821), "https://s3.amazonaws.com/uifaces/faces/twitter/andrewcohen/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6938), "https://s3.amazonaws.com/uifaces/faces/twitter/instalox/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7055), "https://s3.amazonaws.com/uifaces/faces/twitter/dotgridline/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7128), "https://s3.amazonaws.com/uifaces/faces/twitter/marshallchen_/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7199), "https://s3.amazonaws.com/uifaces/faces/twitter/helderleal/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7303), "https://s3.amazonaws.com/uifaces/faces/twitter/orkuncaylar/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7409), "https://s3.amazonaws.com/uifaces/faces/twitter/nellleo/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7522), "https://s3.amazonaws.com/uifaces/faces/twitter/rmlewisuk/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7635), "https://s3.amazonaws.com/uifaces/faces/twitter/oktayelipek/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7749), "https://s3.amazonaws.com/uifaces/faces/twitter/anjhero/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7858), "https://s3.amazonaws.com/uifaces/faces/twitter/9lessons/128.jpg", new DateTime(2020, 9, 20, 10, 50, 40, 272, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(1590), "https://picsum.photos/640/480/?image=886", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(3755), "https://picsum.photos/640/480/?image=1013", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(3961), "https://picsum.photos/640/480/?image=644", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4078), "https://picsum.photos/640/480/?image=232", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4195), "https://picsum.photos/640/480/?image=8", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4309), "https://picsum.photos/640/480/?image=350", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4424), "https://picsum.photos/640/480/?image=101", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4539), "https://picsum.photos/640/480/?image=59", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4647), "https://picsum.photos/640/480/?image=384", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4766), "https://picsum.photos/640/480/?image=1071", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4861), "https://picsum.photos/640/480/?image=697", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(4996), "https://picsum.photos/640/480/?image=318", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5113), "https://picsum.photos/640/480/?image=994", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5214), "https://picsum.photos/640/480/?image=80", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5334), "https://picsum.photos/640/480/?image=663", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5455), "https://picsum.photos/640/480/?image=75", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5569), "https://picsum.photos/640/480/?image=911", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5676), "https://picsum.photos/640/480/?image=89", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5784), "https://picsum.photos/640/480/?image=853", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5901), "https://picsum.photos/640/480/?image=681", new DateTime(2020, 9, 20, 10, 50, 40, 289, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 10, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4925), false, 3, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4955), 16 },
                    { 11, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5029), true, 9, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5042), 18 },
                    { 12, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5110), false, 18, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5139), 17 },
                    { 13, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5229), true, 5, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5242), 21 },
                    { 15, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5447), false, 17, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5478), 15 },
                    { 18, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5842), false, 8, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5868), 11 },
                    { 16, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5606), true, 1, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5632), 4 },
                    { 17, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5739), true, 8, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5767), 21 },
                    { 9, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4769), true, 20, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4799), 7 },
                    { 20, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(6098), true, 14, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(6111), 19 },
                    { 19, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5975), false, 6, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5995), 12 },
                    { 14, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5316), false, 8, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5334), 19 },
                    { 8, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4675), true, 18, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4686), 19 },
                    { 3, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(3727), false, 6, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(3755), 16 },
                    { 6, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4133), true, 3, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4159), 6 },
                    { 5, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4001), true, 19, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4019), 7 },
                    { 1, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(603), false, 18, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(1954), 4 },
                    { 4, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(3870), false, 9, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(3897), 3 },
                    { 2, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(3539), false, 3, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(3591), 21 },
                    { 7, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4550), false, 17, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4576), 8 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Officiis debitis odit veritatis quos tempora ut ipsum. Impedit distinctio nihil dignissimos tenetur autem itaque illo perspiciatis. Rerum assumenda sit quis quisquam dolor dolorum. Ad vero ex iste maiores reprehenderit in similique dolores iure. Ad incidunt excepturi enim praesentium ea minima natus est vel.", new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(2738), 36, new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "earum", new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(5669), 27, new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "Iure rerum officiis incidunt doloribus enim qui. Tempore aperiam accusamus iure. Unde nesciunt enim ipsam et praesentium est rerum odio et. Sit occaecati voluptatem tempora laborum soluta eligendi animi debitis. Alias consequatur in alias occaecati alias aut dolore est non.", new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(6504), 39, new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Tempore asperiores voluptatem sint delectus nihil rerum ut accusantium quae. Quis modi ut asperiores laboriosam enim. Aut perspiciatis sequi accusamus enim repudiandae praesentium. Quidem fugiat sunt earum possimus facilis id voluptatem.", new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(6883), 39, new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "Voluptates sed inventore.", new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(7932), 35, new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Temporibus nihil et amet harum sint ut quod. Et soluta aliquid inventore magnam et fugit dolor dicta. Eum unde sapiente mollitia nemo.", new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(8302), 39, new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, @"Esse dolores ex et maxime non.
Numquam ut nemo quo quod repellat ducimus eos consequatur vitae.
Distinctio dolores earum.
Quis nam modi neque dolorem odit enim.
Ducimus voluptatem magni magnam qui.", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(93), 27, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Voluptatem dolores eveniet ad dolor.", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(425), 30, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, @"Ullam dolorem neque itaque quidem unde.
Quia est rerum qui aut dolorem et fuga eos.
Laborum maxime illo eum cum deserunt impedit.
Alias quae veniam molestias numquam.", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(858), 23, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Aut blanditiis veniam eum quos nihil sed aut.", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(972), 33, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, @"Doloribus et sint recusandae voluptatum.
Blanditiis et dolorum incidunt qui mollitia quidem quas sunt.
Voluptatum molestias aut repellendus quia eveniet ipsum in.", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(1252), 23, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "occaecati", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(1363), 35, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, @"Eligendi illo harum.
Minima distinctio aut eos voluptatem iure modi.
Temporibus vero velit sapiente ea nesciunt laboriosam possimus iusto.
Explicabo atque nisi quibusdam.
Omnis itaque eveniet culpa atque.
Rem earum ducimus earum aut adipisci.", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(1659), 37, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Rerum maxime aliquid voluptatem voluptas iste voluptas. Velit modi est natus sapiente voluptatem dolore atque corporis ipsa. Quia consequatur id ea ipsam repudiandae placeat voluptatem nostrum delectus.", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(1959), 30, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, @"Sed animi dignissimos sunt sint vel similique.
Architecto magnam repellendus eum corrupti temporibus et quo.
Consequuntur repellat doloremque cumque quia iure aperiam.
Explicabo sed aperiam sint sint.
Quia culpa autem et est eaque non quia.
Iste aut nam odit non non quaerat.", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(2383), 25, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "Praesentium excepturi hic aut voluptas non velit quod dolorem nulla.", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(2521), 31, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "et", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(2579), 33, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "quia", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(2711), 25, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Blanditiis voluptatum deserunt.", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(2790), 31, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, @"Corporis est nam ut ipsum nam harum dolores quis.
Et rem exercitationem optio voluptatem voluptas.
Corrupti sint qui ratione illo non culpa.
Blanditiis illo rem quis repellendus recusandae et.
Asperiores perspiciatis molestiae sed amet dignissimos hic ipsum et necessitatibus.
Ipsa vero impedit omnis blanditiis ut doloremque temporibus officia.", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(3236), 22, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2020, 9, 20, 10, 50, 40, 366, DateTimeKind.Local).AddTicks(2762), "Carolanne.Gleichner96@gmail.com", "5/uXQxhdkd8X+CtaCLZtvoherK4Tsx4KO9pyq/Am3vk=", "eWcuiLpIouioblNE8pi/FKwC14pSWLrtcjmvcQJbazE=", new DateTime(2020, 9, 20, 10, 50, 40, 366, DateTimeKind.Local).AddTicks(3650), "Margaret_Ledner" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2020, 9, 20, 10, 50, 40, 379, DateTimeKind.Local).AddTicks(455), "Maryam38@yahoo.com", "7eASSrmnCn1f2UjKWPFKK3jsZlHgEIYLwjPSvezmBH8=", "D9vj85j0RZ8t4lE+TVYKHUqCqgB1wR5mrmE7BgEaugI=", new DateTime(2020, 9, 20, 10, 50, 40, 379, DateTimeKind.Local).AddTicks(563), "Saige.Considine" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2020, 9, 20, 10, 50, 40, 390, DateTimeKind.Local).AddTicks(9593), "Gerardo88@hotmail.com", "ltzTlNrxkFdfhslKoQg3xiatIj73mw8StFCBB7qO6TU=", "PqY9e2NpWHpbD1601TiufnhTBETv2n8DIWWpdlJzf7E=", new DateTime(2020, 9, 20, 10, 50, 40, 390, DateTimeKind.Local).AddTicks(9655), "Julio_Moen" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2020, 9, 20, 10, 50, 40, 402, DateTimeKind.Local).AddTicks(6105), "Anika68@hotmail.com", "jkntrdMusY4DSSLeepp/j310rElTmD3EFWGknx5SOq0=", "30MddVZhjnELYYRpdbQPt9oB6NIItY2SBdVfFYR5whA=", new DateTime(2020, 9, 20, 10, 50, 40, 402, DateTimeKind.Local).AddTicks(6121), "Delilah_Leuschke" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 414, DateTimeKind.Local).AddTicks(5810), "Matilde.Rosenbaum90@gmail.com", "fe/QrHo6diIuHnXctSXtOjmpH9OiecrEA4vZ0EL9mVw=", "3rL+l0ToTptDGGrvPsiFk7bhohmjdWFLQEcl7MVRapg=", new DateTime(2020, 9, 20, 10, 50, 40, 414, DateTimeKind.Local).AddTicks(5865), "Leonor31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2020, 9, 20, 10, 50, 40, 426, DateTimeKind.Local).AddTicks(4882), "Marianne_Kuhic@yahoo.com", "xRE6ElOBuSrSu5PhGh9NKtEZvdBT1JKKFD2Qlsvq/Uo=", "Xph2Dob5SxeInkWOqX2BcwvqVupv4caE9Wowb9mOOMQ=", new DateTime(2020, 9, 20, 10, 50, 40, 426, DateTimeKind.Local).AddTicks(4933), "Melody_Blanda" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2020, 9, 20, 10, 50, 40, 438, DateTimeKind.Local).AddTicks(7294), "Winfield93@gmail.com", "voTZaHTv1kRXhu+ztCX0yJmZuhj/wNBBvrpEyHnrs/s=", "U0R62kCpy88n8vFCymNvg049DP79Km/GJtUwiGGT6HY=", new DateTime(2020, 9, 20, 10, 50, 40, 438, DateTimeKind.Local).AddTicks(7350), "Antonina.Green" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2020, 9, 20, 10, 50, 40, 450, DateTimeKind.Local).AddTicks(3741), "Terrell55@gmail.com", "5WjBLp41xEHdEvIOixJVTdfj6Y0cN+AFlRmMyRGItwU=", "AGcydNJ7H6DHDbyGA6fwcA7YYNGilV0frM+7eMKgixc=", new DateTime(2020, 9, 20, 10, 50, 40, 450, DateTimeKind.Local).AddTicks(3763), "Maribel_Renner" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2020, 9, 20, 10, 50, 40, 462, DateTimeKind.Local).AddTicks(6213), "Justine_Larson@yahoo.com", "ihC1awEaY+2K49BlxHlZDNdc7h5iFQ/V9tUivJlENcI=", "s/zlxoOWXrveNZwefw2LY97bHU8EsGFf08UwiA3TYgI=", new DateTime(2020, 9, 20, 10, 50, 40, 462, DateTimeKind.Local).AddTicks(6267), "Eryn66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2020, 9, 20, 10, 50, 40, 474, DateTimeKind.Local).AddTicks(6883), "Sigmund25@gmail.com", "9K0uljdQgPL1F2t6OCZJQqsMqaz/LJDpAVvtDy05Ejo=", "gCPNMKq3B8upYasJt4dtKygaONuTkhfRA1ELEnfDCig=", new DateTime(2020, 9, 20, 10, 50, 40, 474, DateTimeKind.Local).AddTicks(6937), "Deja.Armstrong" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2020, 9, 20, 10, 50, 40, 486, DateTimeKind.Local).AddTicks(3389), "Ralph_Altenwerth@yahoo.com", "u6G4qRlX+pvm5Xd3DNCwj9pw8yuG6dbiAPlg/WKoiPI=", "rWNwfFqVS43NsqA8No6D2jglkR77n85ammkaoKXIufA=", new DateTime(2020, 9, 20, 10, 50, 40, 486, DateTimeKind.Local).AddTicks(3407), "Gregorio.Bayer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2020, 9, 20, 10, 50, 40, 498, DateTimeKind.Local).AddTicks(2439), "Lyla62@hotmail.com", "403krANcNm0CBi28Hoqk5WekIc93UL2D+KvXhHB8NqY=", "BYvoj0QA5QjBvvchv++l9BLjOZE2gUDI6H9iPHHsdLo=", new DateTime(2020, 9, 20, 10, 50, 40, 498, DateTimeKind.Local).AddTicks(2489), "Olin84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2020, 9, 20, 10, 50, 40, 510, DateTimeKind.Local).AddTicks(3898), "Jermain_Schultz@gmail.com", "vbzoNnsOXioY++QXdkKQ1IPkWth1/7K5RR4E7X0Vt+Y=", "qXa2s1Z1+R+vBHs2L2T++Wrd6NjpTEn1r63vfI/aWtI=", new DateTime(2020, 9, 20, 10, 50, 40, 510, DateTimeKind.Local).AddTicks(3964), "Delmer.Tromp80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2020, 9, 20, 10, 50, 40, 523, DateTimeKind.Local).AddTicks(3875), "Katelynn_Rice@hotmail.com", "TpqCTYpWeIfRCGD+txM+7T1raPl2wXz8L7fvMp6ha7o=", "9Kc4DBFX2ZAtvPdCrbN4vxtytdkFd0Ep9heCJavz1KU=", new DateTime(2020, 9, 20, 10, 50, 40, 523, DateTimeKind.Local).AddTicks(4442), "Jordan.VonRueden50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2020, 9, 20, 10, 50, 40, 536, DateTimeKind.Local).AddTicks(4390), "Rodrigo_Pollich@yahoo.com", "P5vdNQFLQXZkVMji46JO1hQDYGwDNVcB6ZYTIG8pAhU=", "Z3d7y5n1wlpDSk6nM+yxP4/EIJECE0wOVNVtXm6k6aY=", new DateTime(2020, 9, 20, 10, 50, 40, 536, DateTimeKind.Local).AddTicks(4942), "Rhiannon.Baumbach99" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2020, 9, 20, 10, 50, 40, 548, DateTimeKind.Local).AddTicks(9537), "Myrna.Towne55@hotmail.com", "HtVNu2NRoaHObBI8xM+S4l4RG3xlVIoZwqRmmDh6K3U=", "ybFYX6kyj3duHeXo9Mr+O1lL9P/9kIUteyl+zW/skIo=", new DateTime(2020, 9, 20, 10, 50, 40, 548, DateTimeKind.Local).AddTicks(9963), "Richie_McCullough" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2020, 9, 20, 10, 50, 40, 560, DateTimeKind.Local).AddTicks(8785), "Justina.Stokes91@yahoo.com", "LERgRZm/hpDOmJCHQ5YsGD0SMTEMdZ3wJwf61iWGg6w=", "EnAfuItTl85F9WvOqPbrtk8vW4mlbaLOLDmbHpTo64c=", new DateTime(2020, 9, 20, 10, 50, 40, 560, DateTimeKind.Local).AddTicks(8853), "Coby_Hamill" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2020, 9, 20, 10, 50, 40, 576, DateTimeKind.Local).AddTicks(1533), "Rick.Prohaska@hotmail.com", "Td3H8AIF/u2VCHPmqf2gAr3FdBYb+nTpYtCPjaJr9Io=", "QWu2I7MqU5n1C1IRNKDgsudquBUyA9mG1iEpqFb1AOQ=", new DateTime(2020, 9, 20, 10, 50, 40, 576, DateTimeKind.Local).AddTicks(1651), "Layne.Senger83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2020, 9, 20, 10, 50, 40, 598, DateTimeKind.Local).AddTicks(9997), "Dane_Harris80@hotmail.com", "YqPJ1EyZhoD+Q9a6wGvb2Qixqx1VqRugE8baos6DGOg=", "KupJ1fqj8mndzQ8mNW+bWZPieWjDf5tbNqUaMIUpFfM=", new DateTime(2020, 9, 20, 10, 50, 40, 599, DateTimeKind.Local).AddTicks(104), "Ryleigh.Hettinger27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2020, 9, 20, 10, 50, 40, 616, DateTimeKind.Local).AddTicks(4979), "Alexandrea.Hammes@hotmail.com", "lP6X+h00VetXrbjwGJbSEskDfey+OPsn8Cx6HqnqL9w=", "Oe3XKeciBJJzoJhH7oAkXpdnLQIUiAVUYYi98u8edEM=", new DateTime(2020, 9, 20, 10, 50, 40, 616, DateTimeKind.Local).AddTicks(5074), "Guy.Murray" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 632, DateTimeKind.Local).AddTicks(7578), "5vCiXXoH0QhK0hwuQ9R+ZuVmOgylfbFiUON1qon8NBw=", "nFTK7ZtDoeYdgXsyou2fLLx+1dYCpTIDzc/wCtLUd7w=", new DateTime(2020, 9, 20, 10, 50, 40, 632, DateTimeKind.Local).AddTicks(7578) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Users");

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 20, 4, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2690), true, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2698), 9 },
                    { 2, 2, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(1664), false, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(1689), 17 },
                    { 3, 16, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(1752), false, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(1762), 14 },
                    { 4, 5, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(1809), true, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(1818), 15 },
                    { 5, 20, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(1862), false, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(1871), 7 },
                    { 6, 17, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(1914), true, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(1922), 18 },
                    { 7, 15, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(1967), false, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(1976), 21 },
                    { 8, 3, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2022), true, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2030), 20 },
                    { 9, 11, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2077), true, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2085), 14 },
                    { 10, 13, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2233), false, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2243), 3 },
                    { 1, 7, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(147), false, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(913), 18 },
                    { 12, 16, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2328), true, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2335), 17 },
                    { 13, 11, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2372), true, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2380), 15 },
                    { 14, 12, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2417), true, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2425), 17 },
                    { 15, 12, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2466), true, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2474), 1 },
                    { 16, 9, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2513), false, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2521), 6 },
                    { 17, 19, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2558), true, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2566), 2 },
                    { 18, 13, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2602), true, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2610), 16 },
                    { 19, 19, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2645), true, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2653), 12 },
                    { 11, 15, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2282), false, new DateTime(2020, 6, 14, 19, 43, 45, 271, DateTimeKind.Local).AddTicks(2291), 14 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Voluptate sunt esse sint dolor id consequatur non.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(3202), 11, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Earum vel dicta ipsam rerum.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(4941), 11, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Sunt id minus esse quas quisquam facilis.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5176), 20, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Iure sapiente repellendus tempore voluptatibus repudiandae velit sit.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5299), 11, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Dolore sit velit magnam at.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5397), 4, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Eligendi corrupti quaerat assumenda magni blanditiis molestiae cum cum voluptates.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5626), 3, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Ea unde est omnis voluptatum.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5725), 17, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Fugit et eveniet voluptatibus.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5809), 17, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Provident dolorem et debitis rem enim.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5906), 4, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Adipisci expedita eius inventore.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5987), 11, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Quod in maiores voluptas dolor omnis.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6079), 8, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Nisi aut culpa officiis ea temporibus aut.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6178), 11, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Excepturi quaerat quia nam.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6342), 3, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Sint ea qui quae omnis recusandae.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6441), 4, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Qui voluptatem alias fuga.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6526), 10, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Ullam consequuntur quas est ullam.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6611), 9, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Est ut explicabo aut neque quam minus voluptatibus cumque.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6749), 1, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Iste provident similique officiis maiores.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6838), 4, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Dolorum est necessitatibus neque.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6995), 20, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Sed dolores qui.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(7077), 15, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(1103), "https://s3.amazonaws.com/uifaces/faces/twitter/sovesove/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7329), "https://s3.amazonaws.com/uifaces/faces/twitter/sdidonato/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7421), "https://s3.amazonaws.com/uifaces/faces/twitter/igorgarybaldi/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7464), "https://s3.amazonaws.com/uifaces/faces/twitter/smaczny/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7504), "https://s3.amazonaws.com/uifaces/faces/twitter/evandrix/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7544), "https://s3.amazonaws.com/uifaces/faces/twitter/overcloacked/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7583), "https://s3.amazonaws.com/uifaces/faces/twitter/bcrad/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7622), "https://s3.amazonaws.com/uifaces/faces/twitter/ariffsetiawan/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7661), "https://s3.amazonaws.com/uifaces/faces/twitter/themadray/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7701), "https://s3.amazonaws.com/uifaces/faces/twitter/nerdgr8/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7740), "https://s3.amazonaws.com/uifaces/faces/twitter/HenryHoffman/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7779), "https://s3.amazonaws.com/uifaces/faces/twitter/jackiesaik/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7817), "https://s3.amazonaws.com/uifaces/faces/twitter/charliecwaite/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7856), "https://s3.amazonaws.com/uifaces/faces/twitter/rehatkathuria/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7894), "https://s3.amazonaws.com/uifaces/faces/twitter/pechkinator/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7931), "https://s3.amazonaws.com/uifaces/faces/twitter/mbilderbach/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7969), "https://s3.amazonaws.com/uifaces/faces/twitter/zackeeler/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(8008), "https://s3.amazonaws.com/uifaces/faces/twitter/helderleal/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(8046), "https://s3.amazonaws.com/uifaces/faces/twitter/hugomano/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(8085), "https://s3.amazonaws.com/uifaces/faces/twitter/chaabane_wail/128.jpg", new DateTime(2020, 6, 14, 19, 43, 44, 921, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(4901), "https://picsum.photos/640/480/?image=329", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(5993), "https://picsum.photos/640/480/?image=398", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6076), "https://picsum.photos/640/480/?image=653", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6116), "https://picsum.photos/640/480/?image=356", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6154), "https://picsum.photos/640/480/?image=250", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6192), "https://picsum.photos/640/480/?image=919", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6230), "https://picsum.photos/640/480/?image=869", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6266), "https://picsum.photos/640/480/?image=350", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6303), "https://picsum.photos/640/480/?image=76", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6407), "https://picsum.photos/640/480/?image=259", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6449), "https://picsum.photos/640/480/?image=70", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6487), "https://picsum.photos/640/480/?image=165", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6523), "https://picsum.photos/640/480/?image=111", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6559), "https://picsum.photos/640/480/?image=306", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6596), "https://picsum.photos/640/480/?image=950", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6633), "https://picsum.photos/640/480/?image=7", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6669), "https://picsum.photos/640/480/?image=539", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6706), "https://picsum.photos/640/480/?image=16", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6744), "https://picsum.photos/640/480/?image=465", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6780), "https://picsum.photos/640/480/?image=570", new DateTime(2020, 6, 14, 19, 43, 44, 928, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 10, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3821), true, 4, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3830), 9 },
                    { 11, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3868), true, 7, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3875), 6 },
                    { 12, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3911), true, 11, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3918), 8 },
                    { 13, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3953), true, 1, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3961), 7 },
                    { 15, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4040), true, 7, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4048), 8 },
                    { 18, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4171), false, 10, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4179), 16 },
                    { 16, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4085), false, 19, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4093), 5 },
                    { 17, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4128), true, 20, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4136), 6 },
                    { 9, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3695), false, 20, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3703), 20 },
                    { 20, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4256), true, 19, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4264), 13 },
                    { 19, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4213), true, 18, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4221), 16 },
                    { 14, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3998), true, 10, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(4005), 14 },
                    { 8, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3647), true, 1, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3655), 4 },
                    { 3, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3415), true, 17, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3424), 16 },
                    { 6, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3555), false, 13, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3563), 12 },
                    { 5, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3511), false, 15, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3519), 3 },
                    { 1, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(1614), false, 9, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(2476), 1 },
                    { 4, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3464), true, 5, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3472), 7 },
                    { 2, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3332), true, 12, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3356), 18 },
                    { 7, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3598), false, 12, new DateTime(2020, 6, 14, 19, 43, 45, 262, DateTimeKind.Local).AddTicks(3606), 14 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Quo quia dicta accusantium.", new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(1364), 27, new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "autem", new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(3467), 35, new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, @"Accusamus omnis voluptas voluptates perspiciatis doloremque unde.
Odit asperiores ut ea ut ipsa facilis architecto doloremque.
Excepturi ut est veritatis molestiae consectetur nam asperiores.", new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(7911), 25, new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Qui provident sunt odio quam.", new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(8079), 21, new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "voluptatem", new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(8143), 33, new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Sit unde libero assumenda unde occaecati ullam nihil.", new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(8255), 33, new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Pariatur sunt et unde vel et nostrum at voluptatem. Repellendus aspernatur fuga. Vel voluptates deleniti rerum harum enim sit quod. Repellat tempora tempore in neque perspiciatis odit eum. Fuga laborum nesciunt est debitis animi illum minima. Debitis sint ut aut.", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(84), 34, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "Eos voluptatem adipisci quas voluptatum odit non et voluptatem. Incidunt consequuntur nemo nesciunt. Eaque voluptatum aut rem quia aperiam aut. Aliquid eos qui.", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(448), 37, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "natus", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(516), 35, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, @"Sed omnis sed eos illo omnis harum veniam cum quae.
Sunt omnis repudiandae.
Consectetur repudiandae esse consequatur omnis quaerat velit nulla consequatur.
Veniam dolorem consequuntur.
Reprehenderit quisquam qui iste consectetur quas corrupti ea officiis.", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(892), 29, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Reprehenderit corporis sunt aut veritatis consectetur enim.", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(1002), 28, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "nemo", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(1141), 40, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Fugit assumenda itaque quas occaecati veniam voluptas mollitia perferendis. Velit ea fugiat eaque asperiores consequatur commodi. Consequatur ut ad qui eius quidem vero iure. Fuga qui similique corrupti qui dolor id. Et nihil saepe architecto odit reiciendis quos et dolores.", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(1556), 36, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, @"Corporis fuga ipsa.
Dolorem voluptatum ut.
Corporis est dolores qui nihil blanditiis dignissimos.
Dolorem culpa tempora.
Nisi culpa totam officia cumque.", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(1784), 32, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Vero rerum at possimus cupiditate quo earum dignissimos.", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(1968), 30, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "temporibus", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(2033), 23, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "earum", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(2089), 28, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "quam", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(2146), 29, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Cupiditate possimus quisquam nesciunt blanditiis.", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(2235), 29, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, @"Ducimus cumque minima ut dolor dolorum quas quidem aliquid.
Aspernatur atque et praesentium eius facilis quia nostrum placeat vero.
Ut laborum ut ut voluptas.
Dolor doloribus veritatis.
Iusto aspernatur minima.", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(2662), 34, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2020, 6, 14, 19, 43, 44, 983, DateTimeKind.Local).AddTicks(7892), "Ramiro_Beer@gmail.com", "D3h0sPyz3BEfMYVuvwr+6yFV0GzrKCRQNm/5wlgMx1s=", "GxNRzNFfJqyjOc1mJhmtlR4Kg3lnxHiNg90KsxkGYxI=", new DateTime(2020, 6, 14, 19, 43, 44, 983, DateTimeKind.Local).AddTicks(8707), "Wilhelm.Rosenbaum49" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2020, 6, 14, 19, 43, 44, 996, DateTimeKind.Local).AddTicks(1046), "Mitchel_Bayer@hotmail.com", "EjmDnNNb1XptrLzXiGhpXy7bUbAO+qlC1s2fO4b+878=", "Wq98KgrD6bGh6XLj4X/2aazDjZ98sKfw1zrMl0IxfDk=", new DateTime(2020, 6, 14, 19, 43, 44, 996, DateTimeKind.Local).AddTicks(1150), "Chris.Stanton" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2020, 6, 14, 19, 43, 45, 10, DateTimeKind.Local).AddTicks(5432), "Yessenia_Klein@gmail.com", "A8teFnOxMmz6CF0oSrY0xWk70koxD9Ck5QppsGlxFuA=", "TKegl0+6hvmAs4e+Un/nEuXYJfiOJXZoM23/Ed65kHM=", new DateTime(2020, 6, 14, 19, 43, 45, 10, DateTimeKind.Local).AddTicks(5496), "Blaze.OReilly" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2020, 6, 14, 19, 43, 45, 22, DateTimeKind.Local).AddTicks(2360), "Jade.Balistreri@yahoo.com", "V5Ya/pOQ+nqaZjCLrhd3om+tGICUKhyeFXoOxZd5EHQ=", "SQRDPQEiJD9orCPXK+tVwf9MGLOPZai3c2QYqCPd0AM=", new DateTime(2020, 6, 14, 19, 43, 45, 22, DateTimeKind.Local).AddTicks(2392), "Leda51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 45, 34, DateTimeKind.Local).AddTicks(100), "Eli_Turcotte@hotmail.com", "1bSNYvHThGgxkpWJMRbd56hzf4uARwr7ernndalR4tE=", "Of1mKice+yHlcb2jwA5zlMJdYjVXt8C5jP3oOnAH9+U=", new DateTime(2020, 6, 14, 19, 43, 45, 34, DateTimeKind.Local).AddTicks(155), "Sidney4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2020, 6, 14, 19, 43, 45, 46, DateTimeKind.Local).AddTicks(1328), "Ernesto.Kub@yahoo.com", "Oc2wIJClYHEoI07vyVVH0atADpda/TAn7/8a3k4kS6M=", "7P9waCiihX5ktkl4G/R+6DbLfuL2H6lbo6+/4rcgLZM=", new DateTime(2020, 6, 14, 19, 43, 45, 46, DateTimeKind.Local).AddTicks(1364), "Hope38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2020, 6, 14, 19, 43, 45, 58, DateTimeKind.Local).AddTicks(9226), "Jamarcus_Runolfsson@hotmail.com", "/tETWDlqRpGgZyq0TLIyjMHwUAmx2l1ccZvhIiOEQVg=", "4g+x+0IGaUse5JjalBxAiP1VeH3H7IbaeueyTT10A+o=", new DateTime(2020, 6, 14, 19, 43, 45, 58, DateTimeKind.Local).AddTicks(9323), "Darby4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2020, 6, 14, 19, 43, 45, 75, DateTimeKind.Local).AddTicks(133), "Dixie70@yahoo.com", "tJB4kmnbacbYhkf8n3AW3ERMlmaOjEEG/hXI5EUKYJk=", "3aZYC2LMxoy7Oaktun4OLaxZn1CI/wzPuFtvfQX3VEg=", new DateTime(2020, 6, 14, 19, 43, 45, 75, DateTimeKind.Local).AddTicks(218), "Lavada_Daniel88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2020, 6, 14, 19, 43, 45, 86, DateTimeKind.Local).AddTicks(8284), "Otha.Beer@yahoo.com", "syqopeBbaFyfd/UQ7xfAbl1BoZgFdI8wvQ6V2KpMw/4=", "5JKzhhzAdFuPFLbq9FtRlKDhiX4rkU3nrkk1NacFt1Q=", new DateTime(2020, 6, 14, 19, 43, 45, 86, DateTimeKind.Local).AddTicks(8332), "Tavares.Hartmann" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2020, 6, 14, 19, 43, 45, 98, DateTimeKind.Local).AddTicks(8034), "Bernadette89@yahoo.com", "Co+2Y+8Oc0a39OoWiCfkXvS/BxgD9euszL2tMj1rjso=", "NYNNBQIkVZfpGdELEMGIwpuJ+JIfLDGOIXcSGSIRGRg=", new DateTime(2020, 6, 14, 19, 43, 45, 98, DateTimeKind.Local).AddTicks(8109), "Angelica_Reichel15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2020, 6, 14, 19, 43, 45, 110, DateTimeKind.Local).AddTicks(6029), "Jace.Legros42@gmail.com", "paMmKdU4w0M62wf4hXmaWlzfIhKM2kzxExAqh8B8bNw=", "METagVut4xsd/W++OtFeZIl8/hLFBho/CAusq775GkU=", new DateTime(2020, 6, 14, 19, 43, 45, 110, DateTimeKind.Local).AddTicks(6068), "Ernest_Wisozk" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2020, 6, 14, 19, 43, 45, 122, DateTimeKind.Local).AddTicks(4576), "Darryl_Greenholt@hotmail.com", "n5f4mpMvGP6IQSWmrG5slctR4yY/EmIqx9uqNDk11Fk=", "26ZHN5prBoTvqNwGOtoRUTe61i4t732vEOi5OpBDM2M=", new DateTime(2020, 6, 14, 19, 43, 45, 122, DateTimeKind.Local).AddTicks(4648), "Isai0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2020, 6, 14, 19, 43, 45, 134, DateTimeKind.Local).AddTicks(1376), "Gregg_Abshire7@hotmail.com", "+3cmweKK/LyO8cDD8R/SLZG/AKkU6c4q6xIdr+K6qAE=", "eF4d8D6kqphQ0sUoxR5x9T72aZK8Hh+YA3kr0gl4kPg=", new DateTime(2020, 6, 14, 19, 43, 45, 134, DateTimeKind.Local).AddTicks(1397), "Marlee_Emard" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2020, 6, 14, 19, 43, 45, 145, DateTimeKind.Local).AddTicks(8193), "William_Mann39@yahoo.com", "tC9lkkYv5/bUA65vMjtLX/k0FlyyIwpwD19SYtPXrxg=", "08TdyhDr1BWJkRqlt0lIeddxdGcNxrfkshBDbYfluXU=", new DateTime(2020, 6, 14, 19, 43, 45, 145, DateTimeKind.Local).AddTicks(8226), "Robb_Fadel" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2020, 6, 14, 19, 43, 45, 157, DateTimeKind.Local).AddTicks(4740), "Stephanie81@hotmail.com", "T8/33WtA6ehtVYTVKARWCHcWhxDUcFXTSZPAGB8HUlM=", "6ZogFTciORvkuAc9Qtzf/idGQ1H1X6POiinRcP9vZNE=", new DateTime(2020, 6, 14, 19, 43, 45, 157, DateTimeKind.Local).AddTicks(4758), "Adriel_Pfeffer63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2020, 6, 14, 19, 43, 45, 169, DateTimeKind.Local).AddTicks(2788), "Daniella_Metz@yahoo.com", "ajLM13w1mh8u9BtF1roJ3V1NVEdHM8leY64426nx30s=", "19YzYVqnw2f1ePMp/wppEnGB1DGN/sNTTGea2WU46Ek=", new DateTime(2020, 6, 14, 19, 43, 45, 169, DateTimeKind.Local).AddTicks(3309), "Stevie83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2020, 6, 14, 19, 43, 45, 182, DateTimeKind.Local).AddTicks(4236), "Nadia_Yundt@yahoo.com", "dBYjlgVNIJGEVXDm2YR5LnJzIeM7Y5PEkAS5XR9jk9w=", "ATtt2qjGMZDbwIS0ny2PC1ITEEOAavctGYK3pSNw3Fc=", new DateTime(2020, 6, 14, 19, 43, 45, 182, DateTimeKind.Local).AddTicks(4795), "Felton0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2020, 6, 14, 19, 43, 45, 195, DateTimeKind.Local).AddTicks(2050), "Adrien90@yahoo.com", "VJzV4MfCFDT9qD7UgyuKFW+Rw3YK4jjCJ4ZXnUB7ZDo=", "H7vP32nbLfM6vn6zbellpu0CYlm4wwWUu4PJ2fo78no=", new DateTime(2020, 6, 14, 19, 43, 45, 195, DateTimeKind.Local).AddTicks(2493), "George14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2020, 6, 14, 19, 43, 45, 206, DateTimeKind.Local).AddTicks(9795), "Emerald.Sawayn@hotmail.com", "hDYYEgEpkKUEzPq3NvGfJzSSFmK7ibjsOI065Um515s=", "kaqKj4eeBvndMQ0g3lZB0JrsKkF1WzKjJMubcMvOrl4=", new DateTime(2020, 6, 14, 19, 43, 45, 206, DateTimeKind.Local).AddTicks(9839), "Beau72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2020, 6, 14, 19, 43, 45, 218, DateTimeKind.Local).AddTicks(7699), "Rosalind_Smitham@yahoo.com", "8yTzq8qZA1c7xKbhPF4AY4wt5GnlOCFgK33HePsGBOg=", "rstTFPPYt+YMNX1HkT94aLeG6nVBv4rv80ldVD/jHes=", new DateTime(2020, 6, 14, 19, 43, 45, 218, DateTimeKind.Local).AddTicks(7733), "Francesca_McClure4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 45, 230, DateTimeKind.Local).AddTicks(4148), "DjKf3CL4sGtoLKE9SXz+9O4DMymjnW0MlGkdWm2jSvE=", "pAHAF9LIFGTzBKRc83OaOQ9RyW61fSsbY0GzAKXt1y4=", new DateTime(2020, 6, 14, 19, 43, 45, 230, DateTimeKind.Local).AddTicks(4148) });
        }
    }
}
