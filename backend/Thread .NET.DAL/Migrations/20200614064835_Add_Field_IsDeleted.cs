using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class Add_Field_IsDeleted : Migration
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Posts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 20, 11, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(615), false, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(623), 19 },
                    { 2, 19, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9706), false, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9734), 1 },
                    { 3, 10, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9793), true, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9801), 18 },
                    { 4, 11, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9839), false, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9847), 3 },
                    { 5, 4, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9881), false, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9888), 3 },
                    { 6, 5, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9925), false, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9933), 1 },
                    { 7, 17, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9968), true, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9976), 12 },
                    { 8, 10, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(9), false, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(16), 3 },
                    { 9, 8, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(52), false, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(59), 10 },
                    { 10, 14, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(93), true, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(101), 15 },
                    { 1, 4, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(8279), false, new DateTime(2020, 6, 14, 9, 48, 34, 61, DateTimeKind.Local).AddTicks(9008), 14 },
                    { 12, 5, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(278), true, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(287), 13 },
                    { 13, 16, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(327), true, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(335), 2 },
                    { 14, 13, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(370), false, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(377), 5 },
                    { 15, 18, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(411), true, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(419), 16 },
                    { 16, 20, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(452), false, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(459), 18 },
                    { 17, 11, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(492), false, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(500), 14 },
                    { 18, 10, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(533), true, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(540), 8 },
                    { 19, 12, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(574), false, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(582), 14 },
                    { 11, 3, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(134), false, new DateTime(2020, 6, 14, 9, 48, 34, 62, DateTimeKind.Local).AddTicks(142), 17 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Aut sed eius accusamus.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(1923), 10, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Doloribus est quibusdam.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(3842), 20, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Laudantium odit corrupti sit ea vel.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(4224), 16, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Ut quis id eum velit nihil quia.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(4552), 11, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Qui fuga molestiae molestias perferendis quos.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(4716), 17, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Quos placeat magni omnis reprehenderit iusto vero asperiores illum impedit.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5217), 15, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Qui occaecati ut pariatur voluptatem illum ut eligendi.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5427), 12, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Sit quaerat assumenda aperiam animi.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5517), 14, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Delectus laborum ut.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5588), 3, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Numquam hic nisi et corporis reprehenderit iste.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5678), 2, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Et labore dolorem incidunt.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5752), 12, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Fuga dolorem debitis possimus dolores.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5827), 17, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Nisi voluptatem sint facere perferendis sit.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6021), 3, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Ab et molestiae quaerat natus.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6103), 14, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Nesciunt deserunt consequuntur ea nemo.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6182), 12, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Aliquid rerum nam quaerat fugiat beatae.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6266), 11, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Sapiente quis rerum.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6339), 2, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Eius aut et dolor et et alias et aut sit.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6441), 20, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Optio eaque aperiam.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6508), 8, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Nam ut voluptatem accusamus nihil.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6680), 12, new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(3075), "https://s3.amazonaws.com/uifaces/faces/twitter/twittypork/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9303), "https://s3.amazonaws.com/uifaces/faces/twitter/geobikas/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9393), "https://s3.amazonaws.com/uifaces/faces/twitter/webtanya/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9431), "https://s3.amazonaws.com/uifaces/faces/twitter/joe_black/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9468), "https://s3.amazonaws.com/uifaces/faces/twitter/gusoto/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9505), "https://s3.amazonaws.com/uifaces/faces/twitter/ryhanhassan/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9543), "https://s3.amazonaws.com/uifaces/faces/twitter/cdavis565/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9580), "https://s3.amazonaws.com/uifaces/faces/twitter/otozk/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9616), "https://s3.amazonaws.com/uifaces/faces/twitter/matbeedotcom/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9653), "https://s3.amazonaws.com/uifaces/faces/twitter/yecidsm/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9689), "https://s3.amazonaws.com/uifaces/faces/twitter/markwienands/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9726), "https://s3.amazonaws.com/uifaces/faces/twitter/pmeissner/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9761), "https://s3.amazonaws.com/uifaces/faces/twitter/zforrester/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9797), "https://s3.amazonaws.com/uifaces/faces/twitter/praveen_vijaya/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9833), "https://s3.amazonaws.com/uifaces/faces/twitter/bartjo/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9869), "https://s3.amazonaws.com/uifaces/faces/twitter/baluli/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9906), "https://s3.amazonaws.com/uifaces/faces/twitter/runningskull/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9941), "https://s3.amazonaws.com/uifaces/faces/twitter/jennyyo/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9978), "https://s3.amazonaws.com/uifaces/faces/twitter/marclgonzales/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 704, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 705, DateTimeKind.Local).AddTicks(12), "https://s3.amazonaws.com/uifaces/faces/twitter/marcusgorillius/128.jpg", new DateTime(2020, 6, 14, 9, 48, 33, 705, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(6976), "https://picsum.photos/640/480/?image=382", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8256), "https://picsum.photos/640/480/?image=279", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8342), "https://picsum.photos/640/480/?image=47", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8384), "https://picsum.photos/640/480/?image=387", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8421), "https://picsum.photos/640/480/?image=35", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8459), "https://picsum.photos/640/480/?image=504", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8497), "https://picsum.photos/640/480/?image=245", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8535), "https://picsum.photos/640/480/?image=10", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8596), "https://picsum.photos/640/480/?image=164", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8634), "https://picsum.photos/640/480/?image=57", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8670), "https://picsum.photos/640/480/?image=215", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8707), "https://picsum.photos/640/480/?image=934", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8743), "https://picsum.photos/640/480/?image=172", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8780), "https://picsum.photos/640/480/?image=336", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8818), "https://picsum.photos/640/480/?image=917", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8855), "https://picsum.photos/640/480/?image=647", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8891), "https://picsum.photos/640/480/?image=411", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8928), "https://picsum.photos/640/480/?image=528", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8965), "https://picsum.photos/640/480/?image=607", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(9001), "https://picsum.photos/640/480/?image=106", new DateTime(2020, 6, 14, 9, 48, 33, 711, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 10, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4102), true, 4, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4110), 10 },
                    { 11, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4142), true, 5, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4150), 11 },
                    { 12, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4284), true, 16, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4293), 6 },
                    { 13, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4329), true, 3, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4337), 4 },
                    { 15, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4411), false, 13, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4419), 17 },
                    { 18, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4530), false, 18, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4537), 2 },
                    { 16, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4452), true, 13, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4459), 10 },
                    { 17, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4490), true, 7, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4498), 21 },
                    { 9, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4062), false, 13, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4069), 6 },
                    { 20, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4614), false, 16, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4622), 1 },
                    { 19, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4570), true, 5, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4578), 13 },
                    { 14, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4371), true, 10, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4378), 19 },
                    { 8, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4018), false, 19, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(4025), 21 },
                    { 3, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(3799), true, 19, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(3807), 13 },
                    { 6, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(3933), false, 2, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(3941), 15 },
                    { 5, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(3889), false, 7, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(3897), 16 },
                    { 1, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(2182), true, 12, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(2907), 5 },
                    { 4, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(3844), true, 6, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(3852), 9 },
                    { 2, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(3714), false, 6, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(3739), 2 },
                    { 7, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(3978), true, 5, new DateTime(2020, 6, 14, 9, 48, 34, 53, DateTimeKind.Local).AddTicks(3986), 3 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, @"Quia libero sit dicta modi molestias qui.
Voluptatem aut omnis ut qui modi natus voluptas nemo.
Occaecati et labore neque quo minima consequuntur molestiae est nulla.
Facere et placeat explicabo fugit voluptates ut dolore.
Quidem nisi qui voluptate ipsa dignissimos in dolor.", new DateTime(2020, 6, 14, 9, 48, 34, 33, DateTimeKind.Local).AddTicks(4898), 24, new DateTime(2020, 6, 14, 9, 48, 34, 33, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "Nesciunt velit perferendis magni.", new DateTime(2020, 6, 14, 9, 48, 34, 33, DateTimeKind.Local).AddTicks(7802), 26, new DateTime(2020, 6, 14, 9, 48, 34, 33, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "Quibusdam id exercitationem magni molestias aut perferendis aliquam laborum enim. Beatae qui ullam. Fugiat fugiat quia enim.", new DateTime(2020, 6, 14, 9, 48, 34, 33, DateTimeKind.Local).AddTicks(9529), 35, new DateTime(2020, 6, 14, 9, 48, 34, 33, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Error et mollitia dolores id delectus quo et officia velit.", new DateTime(2020, 6, 14, 9, 48, 34, 33, DateTimeKind.Local).AddTicks(9698), 36, new DateTime(2020, 6, 14, 9, 48, 34, 33, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, @"Provident laboriosam error non perspiciatis.
Voluptatem quia sunt fugit quo exercitationem.
Et soluta ut et cupiditate possimus.
Optio voluptates id ad nostrum est ducimus et.", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(26), 38, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Corporis iste officia non eos vel qui.", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(133), 31, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Eum eveniet libero.", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(212), 28, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Ipsam pariatur quibusdam culpa. Minus quis labore assumenda doloremque eum et. Et ut asperiores necessitatibus sit placeat quia et quibusdam. Molestiae iure necessitatibus modi vel. Vel quas non doloremque tempore qui porro. Aut delectus velit pariatur in a rem.", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(588), 30, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "Harum tempore quas laborum sequi facilis nisi sint.", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(857), 32, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "minus", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(1317), 31, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, @"Ullam non vitae excepturi unde corrupti sint.
Omnis ea tempora quo dolor.
Voluptatem dolorum dolores maxime rerum officiis necessitatibus autem iure voluptas.", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(1557), 33, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "omnis", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(1618), 25, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Rerum quia vero amet eius vitae amet. Dolore animi veniam sed soluta illum quam. Fugit sit neque libero sint quidem molestiae dolorem facere rerum. Aliquid eos dolores et quam ut. Fugiat omnis praesentium et ad. Omnis quis facilis omnis aut non rerum corporis.", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2050), 35, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "libero", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2108), 36, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "enim", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2263), 26, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Expedita fugiat qui fugit minus.", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2351), 38, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Facilis quam nobis quod et voluptates tempora doloribus voluptatem est.", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2462), 31, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "quidem", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2519), 25, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "facilis", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2574), 40, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, @"Repellat earum consequatur molestiae quo non.
Ut ea provident.
Quasi deleniti iusto non ad.
Dolorem voluptatem aut nemo saepe qui.", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2879), 31, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2020, 6, 14, 9, 48, 33, 770, DateTimeKind.Local).AddTicks(6538), "Lola.Monahan@hotmail.com", "Ix71rHBhqii3MApn43pOKnf3J8EhwYXXmQyklv6cV9E=", "Jeb2szGhDbCqaGIdohjXh7SnVxj8iK943Uwq8tbxt0A=", new DateTime(2020, 6, 14, 9, 48, 33, 770, DateTimeKind.Local).AddTicks(7359), "Chyna.Littel" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2020, 6, 14, 9, 48, 33, 782, DateTimeKind.Local).AddTicks(6404), "Maye.Schinner@hotmail.com", "YZeWypO9e+qnSv2y2y9VEJz/Oxd10PzoeEwZJo04Evk=", "4gdwLKBEgjm73oITMHaom9q0/iQ6Mg215oaRqtg8FMM=", new DateTime(2020, 6, 14, 9, 48, 33, 782, DateTimeKind.Local).AddTicks(6450), "Rupert_Paucek60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2020, 6, 14, 9, 48, 33, 794, DateTimeKind.Local).AddTicks(5435), "Emery_Harris@gmail.com", "vU4HRf9zUQWwV6dxihB7ASgUxyWmoGQMbq1W4dlThI0=", "gaUwfPXqg/gAwNOPDmdQ5inFWA9pkprjzXX/SUaa1no=", new DateTime(2020, 6, 14, 9, 48, 33, 794, DateTimeKind.Local).AddTicks(5493), "Theodora_Spencer18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2020, 6, 14, 9, 48, 33, 806, DateTimeKind.Local).AddTicks(3686), "Emmett59@hotmail.com", "AIpieYWVUGcKybGwt7Lyki3QigKCMr6woVqB3GFW+yc=", "fo77/2EObZiNfYxc2wXC/u7sQ61XwM5bLgFzvSfL9l4=", new DateTime(2020, 6, 14, 9, 48, 33, 806, DateTimeKind.Local).AddTicks(3732), "Rosa68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2020, 6, 14, 9, 48, 33, 818, DateTimeKind.Local).AddTicks(465), "Sid.Hegmann64@yahoo.com", "EQp6YebK4DZj8qlB8WvbXBI2OFdYZqwRBq1jm/wBzPk=", "hz+Bceh9/kxvWjbn2A4AiRXFK9/GPqqr7FxCwtuiWdg=", new DateTime(2020, 6, 14, 9, 48, 33, 818, DateTimeKind.Local).AddTicks(487), "Jake.MacGyver95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 830, DateTimeKind.Local).AddTicks(81), "Godfrey_Larkin99@hotmail.com", "Dsk9J/2EwkXpj94FecFoh76QRrcc1c9cEMcEr8zTMeo=", "a09aavhDYtiwm9KFzxi/P8+ODV1cCz5T3m8/u6+jgRw=", new DateTime(2020, 6, 14, 9, 48, 33, 830, DateTimeKind.Local).AddTicks(144), "Reilly_Bode" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2020, 6, 14, 9, 48, 33, 841, DateTimeKind.Local).AddTicks(8960), "Ethel.Keeling73@gmail.com", "Vp9mgy2aav9E3Pxelu/EoVl1h4AeJwoou/tQOb+slwg=", "NfjJqgVkvxum7gfI2Vs1avDCm+wgdib1w80N49nhDbc=", new DateTime(2020, 6, 14, 9, 48, 33, 841, DateTimeKind.Local).AddTicks(9016), "Jovan64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2020, 6, 14, 9, 48, 33, 855, DateTimeKind.Local).AddTicks(6885), "Breana1@hotmail.com", "M99mxX8IUtZBQq/vZDDDpfoPCo3sz4CmIC0YPV5KkSY=", "6pLNXUWviO+xfH7CNtSNZV0I0/b1oWnYDZ2MSUuD9Uk=", new DateTime(2020, 6, 14, 9, 48, 33, 855, DateTimeKind.Local).AddTicks(6981), "Napoleon74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2020, 6, 14, 9, 48, 33, 873, DateTimeKind.Local).AddTicks(9889), "Lane_Breitenberg18@yahoo.com", "k0I2VTAtSZpvQX8P3mnUyjvZpYD8Z/aSO+9aO3D87Uk=", "JGfIj1ikMirm91ySrCd/yZDzWIIhl4yF9eB+iMr3VlE=", new DateTime(2020, 6, 14, 9, 48, 33, 873, DateTimeKind.Local).AddTicks(9957), "Hassan98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2020, 6, 14, 9, 48, 33, 888, DateTimeKind.Local).AddTicks(8475), "Arthur33@gmail.com", "0QanDLzv1EXrUn/3/h8PUybLM4rS24NsDhPf81hsQ3c=", "GcbeQhjJhLfIsHG+ZzpwMw5PMiOhuNO3qUCMTucdOOI=", new DateTime(2020, 6, 14, 9, 48, 33, 888, DateTimeKind.Local).AddTicks(8526), "Pattie80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 900, DateTimeKind.Local).AddTicks(6539), "Claire.Ziemann@yahoo.com", "DVlQsHxBOxdNfrZzljuviFm5ZPIbFbXiKMI7z273eG8=", "VwBHS0aY0QWy/O0jpHuFp7FsOVBN3uIL8gYLOQJxXVg=", new DateTime(2020, 6, 14, 9, 48, 33, 900, DateTimeKind.Local).AddTicks(6587), "Aniyah.Schroeder" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2020, 6, 14, 9, 48, 33, 912, DateTimeKind.Local).AddTicks(3646), "Vernon55@gmail.com", "2BwnTwWdy+G2g2IaQSP5UjrmAKCYMj6Ws2/Z9M42uww=", "dJJwv+z6z9KWw3dBAJz16zL/oyTcXYN4rZPJudBIFqw=", new DateTime(2020, 6, 14, 9, 48, 33, 912, DateTimeKind.Local).AddTicks(3671), "Dahlia.Nienow52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2020, 6, 14, 9, 48, 33, 924, DateTimeKind.Local).AddTicks(1668), "Sophie39@gmail.com", "x0VUAWV5E/tE6K3zg93EobhUMDkAeuMD0QBD/KU7i4A=", "jXYMo6bl+2hv6raeR2MqogGBA98VpeU/ndBDYE2DzUE=", new DateTime(2020, 6, 14, 9, 48, 33, 924, DateTimeKind.Local).AddTicks(1706), "Markus81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2020, 6, 14, 9, 48, 33, 936, DateTimeKind.Local).AddTicks(1290), "Stephania_Sporer25@gmail.com", "EeHsEmc0oHYkjFAWaITJ4RNSICHjiLn6sx+eGdwDXMQ=", "tIosapqlBQq3HOiuwLWCUgvYD0He8gy98aHB36rKEnU=", new DateTime(2020, 6, 14, 9, 48, 33, 936, DateTimeKind.Local).AddTicks(1355), "Martina.Brown93" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2020, 6, 14, 9, 48, 33, 948, DateTimeKind.Local).AddTicks(592), "Alexa_Stamm34@hotmail.com", "EtpVp1pEAG6cYM/Fad1Ohbl00MK5oMK5eF1YP5pcL70=", "O4JKnylRLLUrsWdxImemRHsFU0K2jARLjzh7VxA4e8I=", new DateTime(2020, 6, 14, 9, 48, 33, 948, DateTimeKind.Local).AddTicks(631), "Lennie_Friesen40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2020, 6, 14, 9, 48, 33, 959, DateTimeKind.Local).AddTicks(7828), "Michel.Roob@gmail.com", "HJvznc7pMRar2fJHArmN+nvOgAFRu40QaO4HNm/sWIA=", "Ogw9Qbv/UXy/TYh8l/vx3uCOgsi+pQaN6i0QK0tcwLc=", new DateTime(2020, 6, 14, 9, 48, 33, 959, DateTimeKind.Local).AddTicks(7864), "Mallie.Powlowski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2020, 6, 14, 9, 48, 33, 971, DateTimeKind.Local).AddTicks(5438), "Brayan64@yahoo.com", "VltzWOaT6v34UB31O827cbW7FPhyi+xDgH6aBVfNghk=", "W06809DFHBhNEntcsPC7XUtA+OWjr2I+X73RXGH1evQ=", new DateTime(2020, 6, 14, 9, 48, 33, 971, DateTimeKind.Local).AddTicks(5473), "Tierra_Ratke8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 983, DateTimeKind.Local).AddTicks(2831), "Clifford_Gorczany@yahoo.com", "euZvW1lcmlm+/ibJaD1Gi7TJSroaOGNvVZhoRE52f/4=", "5aA9cqa/RXNNQ7gAvixR/mTtQW3o7GkoaSU6+eqrDXI=", new DateTime(2020, 6, 14, 9, 48, 33, 983, DateTimeKind.Local).AddTicks(2864), "Brendon_Gusikowski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2020, 6, 14, 9, 48, 33, 995, DateTimeKind.Local).AddTicks(9858), "Evelyn83@hotmail.com", "RUk34isxHegXDsOKixDjvEcahujTj22JZ2Gd0x6QwZI=", "quKfhPUXBI0iVZm55kRxOup9cVs3TuQswNJv9YrzV/A=", new DateTime(2020, 6, 14, 9, 48, 33, 996, DateTimeKind.Local).AddTicks(437), "Talon_Jacobs83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2020, 6, 14, 9, 48, 34, 9, DateTimeKind.Local).AddTicks(1606), "Cassie28@hotmail.com", "mko9POpA8ESHrQ+h/Fu8S+fZ6oCSpAQjvnZUuZFAZ9k=", "xDypz2DGRbKpEPa0gyAYgVmsKbxPwTWtbHW5V9au7MQ=", new DateTime(2020, 6, 14, 9, 48, 34, 9, DateTimeKind.Local).AddTicks(2139), "Lily78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 34, 21, DateTimeKind.Local).AddTicks(1329), "BCnRt2/aUfmIFiWuHb3DW/nHu4vHX67DuxwVFX6meRU=", "AgYQ/EUJI1k7ZgY1Ov9YnYeoO+c3yR+PvYtUz3Th1H4=", new DateTime(2020, 6, 14, 9, 48, 34, 21, DateTimeKind.Local).AddTicks(1329) });
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
                name: "IsDeleted",
                table: "Posts");

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 20, 11, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(2190), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(2202), 2 },
                    { 2, 18, new DateTime(2019, 6, 8, 13, 30, 1, 865, DateTimeKind.Local).AddTicks(9981), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(9), 6 },
                    { 3, 14, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(115), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(127), 18 },
                    { 4, 18, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(208), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(224), 15 },
                    { 5, 18, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(305), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(321), 2 },
                    { 6, 8, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(402), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(419), 14 },
                    { 7, 10, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(504), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(520), 12 },
                    { 8, 1, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(666), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(682), 19 },
                    { 9, 3, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(779), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(796), 16 },
                    { 10, 13, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(881), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(897), 15 },
                    { 1, 11, new DateTime(2019, 6, 8, 13, 30, 1, 865, DateTimeKind.Local).AddTicks(6993), false, new DateTime(2019, 6, 8, 13, 30, 1, 865, DateTimeKind.Local).AddTicks(8315), 21 },
                    { 12, 20, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1079), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1096), 9 },
                    { 13, 6, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1185), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1197), 1 },
                    { 14, 18, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1282), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1298), 7 },
                    { 15, 20, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1379), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1396), 13 },
                    { 16, 4, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1797), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1821), 12 },
                    { 17, 17, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1915), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1931), 1 },
                    { 18, 7, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(2008), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(2024), 18 },
                    { 19, 2, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(2101), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(2113), 10 },
                    { 11, 18, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(978), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(994), 5 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Et minus amet.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(961), 3, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Sit sint architecto.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4079), 13, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Ea ad deleniti ut quis officia voluptatibus occaecati.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4379), 7, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "In eius qui necessitatibus et sapiente quis iure.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4626), 16, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Dolor doloremque est rerum et quis.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4837), 8, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Tenetur occaecati omnis dolorem molestiae.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5039), 6, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Ut tempore ut id et odit temporibus.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5295), 7, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Qui iste temporibus dolores.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5494), 20, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Dolores ducimus magni qui nesciunt est quia aut a tempore.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5729), 10, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Delectus non nihil cumque sed dolores ut impedit.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5952), 19, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Consequuntur odit tempora omnis vel sunt illum nobis et quia.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6195), 10, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "At aut veritatis veritatis.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6402), 20, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Voluptates inventore libero sit illo pariatur.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6657), 1, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Quam magnam quidem cupiditate ratione id ab eum.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6904), 4, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "At adipisci expedita dignissimos provident architecto.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7119), 17, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Architecto deleniti earum.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7285), 10, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Quasi iusto ipsa.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7460), 20, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Aut maiores eum a quibusdam non.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7837), 6, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Soluta est animi.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(8072), 12, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "In tempora et voluptatibus ut et consequatur fuga.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(8287), 7, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 425, DateTimeKind.Local).AddTicks(742), "https://s3.amazonaws.com/uifaces/faces/twitter/exentrich/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(5920), "https://s3.amazonaws.com/uifaces/faces/twitter/kolage/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6046), "https://s3.amazonaws.com/uifaces/faces/twitter/joshaustin/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6127), "https://s3.amazonaws.com/uifaces/faces/twitter/yecidsm/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6212), "https://s3.amazonaws.com/uifaces/faces/twitter/aoimedia/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6293), "https://s3.amazonaws.com/uifaces/faces/twitter/jonkspr/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6374), "https://s3.amazonaws.com/uifaces/faces/twitter/mutlu82/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6459), "https://s3.amazonaws.com/uifaces/faces/twitter/mgonto/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6540), "https://s3.amazonaws.com/uifaces/faces/twitter/karalek/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6621), "https://s3.amazonaws.com/uifaces/faces/twitter/igorgarybaldi/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6698), "https://s3.amazonaws.com/uifaces/faces/twitter/alek_djuric/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6779), "https://s3.amazonaws.com/uifaces/faces/twitter/renbyrd/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6860), "https://s3.amazonaws.com/uifaces/faces/twitter/mahmoudmetwally/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6942), "https://s3.amazonaws.com/uifaces/faces/twitter/mattdetails/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7019), "https://s3.amazonaws.com/uifaces/faces/twitter/baumann_alex/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7100), "https://s3.amazonaws.com/uifaces/faces/twitter/kuldarkalvik/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7181), "https://s3.amazonaws.com/uifaces/faces/twitter/motionthinks/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7258), "https://s3.amazonaws.com/uifaces/faces/twitter/urrutimeoli/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7339), "https://s3.amazonaws.com/uifaces/faces/twitter/wesleytrankin/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7420), "https://s3.amazonaws.com/uifaces/faces/twitter/timmillwood/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(539), "https://picsum.photos/640/480/?image=393", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2112), "https://picsum.photos/640/480/?image=1079", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2218), "https://picsum.photos/640/480/?image=801", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2299), "https://picsum.photos/640/480/?image=951", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2376), "https://picsum.photos/640/480/?image=436", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2457), "https://picsum.photos/640/480/?image=64", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2538), "https://picsum.photos/640/480/?image=436", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2639), "https://picsum.photos/640/480/?image=243", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2720), "https://picsum.photos/640/480/?image=515", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2797), "https://picsum.photos/640/480/?image=290", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2879), "https://picsum.photos/640/480/?image=400", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2956), "https://picsum.photos/640/480/?image=839", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3037), "https://picsum.photos/640/480/?image=926", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3118), "https://picsum.photos/640/480/?image=163", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3195), "https://picsum.photos/640/480/?image=455", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3272), "https://picsum.photos/640/480/?image=688", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3349), "https://picsum.photos/640/480/?image=759", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3430), "https://picsum.photos/640/480/?image=307", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3507), "https://picsum.photos/640/480/?image=488", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3584), "https://picsum.photos/640/480/?image=902", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 10, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4275), false, 5, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4287), 15 },
                    { 11, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4364), false, 9, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4381), 8 },
                    { 12, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4458), false, 18, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4470), 2 },
                    { 13, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4543), false, 10, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4559), 16 },
                    { 15, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4721), false, 11, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4733), 12 },
                    { 18, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(5001), true, 3, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(5017), 5 },
                    { 16, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4806), true, 19, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4822), 16 },
                    { 17, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4904), false, 14, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4916), 15 },
                    { 9, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4186), false, 8, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4198), 5 },
                    { 20, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(5199), false, 8, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(5216), 19 },
                    { 19, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(5098), false, 3, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(5114), 10 },
                    { 14, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4632), true, 9, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4644), 20 },
                    { 8, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4097), true, 8, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4113), 20 },
                    { 3, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3606), false, 18, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3623), 5 },
                    { 6, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3906), false, 19, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3918), 13 },
                    { 5, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3809), true, 3, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3821), 16 },
                    { 1, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(465), false, 2, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(1693), 1 },
                    { 4, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3716), true, 6, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3728), 5 },
                    { 2, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3452), false, 7, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3485), 13 },
                    { 7, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4004), true, 7, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4020), 18 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Enim ea sunt eos reprehenderit maxime.", new DateTime(2019, 6, 8, 13, 30, 1, 808, DateTimeKind.Local).AddTicks(9179), 22, new DateTime(2019, 6, 8, 13, 30, 1, 809, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, @"Exercitationem assumenda expedita eos possimus dolorem aut repellat eos.
Error voluptate molestiae et laudantium.
Explicabo ea est totam soluta esse cumque voluptatibus qui voluptatem.
Ex corrupti praesentium omnis vitae occaecati.
Dicta doloribus qui vero sit incidunt id aspernatur ipsum.", new DateTime(2019, 6, 8, 13, 30, 1, 810, DateTimeKind.Local).AddTicks(4781), 23, new DateTime(2019, 6, 8, 13, 30, 1, 810, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Non placeat asperiores qui. Quis qui aut. Tempore iste dolores.", new DateTime(2019, 6, 8, 13, 30, 1, 810, DateTimeKind.Local).AddTicks(9731), 34, new DateTime(2019, 6, 8, 13, 30, 1, 810, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, @"Atque rerum consequuntur illum rem quia labore.
Vel eos qui et sunt.
Officia aspernatur magnam molestiae.
Laudantium a voluptatibus ut expedita sed et ratione.
Cupiditate unde vitae officia quos.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(307), 31, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "aperiam", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(1361), 29, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { @"Quisquam nihil natus quidem dolores iusto.
Qui et aspernatur est numquam harum et est totam et.
Accusantium itaque vel eum dolor asperiores placeat.
Aut voluptatum et.
Ut neque impedit voluptatum voluptatem vel aspernatur error nihil.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(1941), 35, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "sed", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(2131), 40, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Voluptas praesentium similique et voluptates unde illum libero necessitatibus facilis.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(2387), 32, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "Quos voluptas mollitia magni est quas.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(2581), 24, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "Consequuntur ipsam est. Quo autem dolor rem quia quia perferendis et. Inventore laborum saepe. Quis dolorem provident cum a dolore voluptas et occaecati.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(3027), 38, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Dolorum adipisci facere repellendus incidunt quia maiores. Pariatur iure esse nisi. Voluptatum eum error quasi repellat. Aliquid et tempore quo quis dolorem quasi. Aut consectetur itaque aut optio quis soluta qui corporis.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(3530), 26, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Qui adipisci voluptatem ratione voluptatem laborum doloribus commodi.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(3741), 40, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "In distinctio hic ex. Et neque dignissimos odit maiores repudiandae. Quisquam ut in vitae non minima.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(4065), 36, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Aliquid eligendi aut omnis vitae in et ut. Voluptas provident aut sit. Hic ut et eius et quo. Voluptate minus ut facilis. Veniam dignissimos cum doloribus deserunt et.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(4523), 38, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, @"Et vitae ipsa velit facere.
Est consectetur asperiores natus rerum culpa autem qui in.
Illum totam rerum a similique voluptates libero sed.
Iste neque ipsum quis odit doloremque.
Quis harum officia dolores sed sint blanditiis facilis dicta.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(5058), 28, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "Corporis nulla adipisci natus ab occaecati et nihil cumque. Velit et id adipisci. Deleniti ut necessitatibus provident autem nostrum maxime. Voluptatem deleniti corporis perferendis ullam officiis eius. Qui voluptatum mollitia aliquam voluptatem.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(5545), 40, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "molestias", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(5674), 24, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "Minima omnis quaerat ab est ducimus omnis voluptatem. Sunt iste nostrum non vitae placeat molestias ex eum. Saepe deserunt dignissimos qui earum minima. Quia fugiat voluptatem id quo illum sed.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(6116), 31, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, @"Ut assumenda et et.
Voluptatem optio doloremque ipsa rerum nemo repellat quo.
Dignissimos ut magni fugiat quidem voluptatem est aut enim.
Ullam et eos quod ipsum reprehenderit rerum tempora possimus aut.
Porro reprehenderit explicabo illum sed et dolore.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(6643), 30, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, @"Sapiente quis culpa velit commodi rerum iusto voluptatum neque.
Sunt sed eum nesciunt a vero.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(6931), 34, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2019, 6, 8, 13, 30, 1, 498, DateTimeKind.Local).AddTicks(4064), "Lewis66@yahoo.com", "ipp+S75e/5LiuvKBM0nZrEQsP+7SMRMzqcaRN08Npeo=", "euuwrkqYzcRNJGdeN7pEtbfzLCvqO+eavPQlg+vBgT4=", new DateTime(2019, 6, 8, 13, 30, 1, 498, DateTimeKind.Local).AddTicks(5085), "Berta.Mann13" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2019, 6, 8, 13, 30, 1, 510, DateTimeKind.Local).AddTicks(8861), "Zula.Schultz0@gmail.com", "P8ThNsvBpgNPvmH1YqSUD2/vtQRDH/Lul3MQa1elkRI=", "oI1mrCZQsTc837g5oIG3HMPEvL9DrfDpegteKB4mOas=", new DateTime(2019, 6, 8, 13, 30, 1, 510, DateTimeKind.Local).AddTicks(8946), "Emiliano_Rice44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 6, 8, 13, 30, 1, 523, DateTimeKind.Local).AddTicks(1692), "Reagan60@yahoo.com", "0seLIYhjNnliKhex2dDOLL/USB49B2vjmm35kPNClV0=", "2VgpQTnja97w2gvln6xsIeJnhGCvbckR1fahcmznjBw=", new DateTime(2019, 6, 8, 13, 30, 1, 523, DateTimeKind.Local).AddTicks(1773), "Keely_Johnston" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 6, 8, 13, 30, 1, 535, DateTimeKind.Local).AddTicks(2230), "Keon.Lang62@yahoo.com", "6U7+IRUGC7b0o9gvk13Hmjq7fqhQrz5LUeBrI7N8KFc=", "yfVqUaYEqo8GpvMHeBTVWEvVt8tbqBlOg6RdI2UT4os=", new DateTime(2019, 6, 8, 13, 30, 1, 535, DateTimeKind.Local).AddTicks(2311), "Odell91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 6, 8, 13, 30, 1, 547, DateTimeKind.Local).AddTicks(4604), "Itzel.Hintz@yahoo.com", "NuSFkBsHxCG6xLWi69+t4D0QQGJ6BVVhb9xbXZLdvuw=", "RhFEqCkXU6TJ/PlnhiUc1oPhH+KaEWnNBGn83ls6cpI=", new DateTime(2019, 6, 8, 13, 30, 1, 547, DateTimeKind.Local).AddTicks(4685), "Elmore_Zieme78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 563, DateTimeKind.Local).AddTicks(166), "Lonie68@hotmail.com", "9kzThCD61VguYbsRHNtsljedbZNR1l25iA5h7tnglD4=", "urBn05zOW2W/z0SRh+ROKzQA8zstGURtGXA8s6Vb2a4=", new DateTime(2019, 6, 8, 13, 30, 1, 563, DateTimeKind.Local).AddTicks(255), "Alanis58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 6, 8, 13, 30, 1, 578, DateTimeKind.Local).AddTicks(2826), "Kristin97@gmail.com", "0V7MfOMBFz35VAxpeLP/VykoHmFr7Y6TMb7KmCsI/aY=", "7sMIRbE3J8XKIl6X9jKvzdPbJKIBm2ObprWHVvqbjCg=", new DateTime(2019, 6, 8, 13, 30, 1, 578, DateTimeKind.Local).AddTicks(3337), "Mallory.Lowe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 6, 8, 13, 30, 1, 591, DateTimeKind.Local).AddTicks(1073), "Brock.Morissette45@yahoo.com", "W0C3ON2PXLVca3hpSsshp9A731PcJZ/uhs6iqIEPNO0=", "rfSm1BxD/Cz3A0fKq9SM3lViajI8Rf0JUblIsycGTHk=", new DateTime(2019, 6, 8, 13, 30, 1, 591, DateTimeKind.Local).AddTicks(1166), "Adrian47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 6, 8, 13, 30, 1, 603, DateTimeKind.Local).AddTicks(309), "Chester.Botsford18@hotmail.com", "TD3rl13TivQ0isdJJdv3otUiNVS1qu95yZQACMf2xlw=", "D+kG+ztr9Id+AD59gxJdJygPRlt/ioTnMqMBlmFDyjE=", new DateTime(2019, 6, 8, 13, 30, 1, 603, DateTimeKind.Local).AddTicks(394), "Alysha_Kovacek" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 6, 8, 13, 30, 1, 617, DateTimeKind.Local).AddTicks(9451), "Marcelina62@yahoo.com", "aLjZF/bDcOOeW7qCP9dwuSPumeOm9QRufFkUKft46+4=", "bh5Ft5t/KbW9P4fmQXyGpy+XgKou4wo7+Rdd1ySJm8Y=", new DateTime(2019, 6, 8, 13, 30, 1, 617, DateTimeKind.Local).AddTicks(9552), "Rupert_Kassulke55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 639, DateTimeKind.Local).AddTicks(2043), "Shaylee79@yahoo.com", "Rh0T1eDmyKZIDhDBfPV7+xzjf1K+T84PENeigQVqr+E=", "bYVeC1RbOLLbVVmDf1eTE1dAGCKYfgEgYbNWtgYNIyk=", new DateTime(2019, 6, 8, 13, 30, 1, 639, DateTimeKind.Local).AddTicks(2132), "Gwendolyn_Boehm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 6, 8, 13, 30, 1, 661, DateTimeKind.Local).AddTicks(877), "Mauricio.Von33@yahoo.com", "UTni2loimGZ5Kti93HaEZ+fciZCwfO/ZaPOc44RxhhM=", "cYSMaR0B14+YVoFvlt8tjpPoZY2z5K5jIFb2xsHfxZs=", new DateTime(2019, 6, 8, 13, 30, 1, 661, DateTimeKind.Local).AddTicks(966), "Coleman_Bosco95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 6, 8, 13, 30, 1, 673, DateTimeKind.Local).AddTicks(2489), "Elton.Farrell22@hotmail.com", "DSLPWWQIc4TRCSD6QevyvmOV2Q8UikaYj+CawmvEYhM=", "Nd3AGdFKVWNX6lV8EepGfNXRRTrIbZt+crUIxwN7K4A=", new DateTime(2019, 6, 8, 13, 30, 1, 673, DateTimeKind.Local).AddTicks(2582), "Delores_Hauck92" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 6, 8, 13, 30, 1, 685, DateTimeKind.Local).AddTicks(5677), "Sabryna13@hotmail.com", "2I1TP1TVsZiysC0zeVLdGzmL6bsTG5Yro1ZMoZPOVZs=", "2ttqWS2Z+EZN+C1+MQpRFtwsg1kh/bqEJOhp5GaQdo0=", new DateTime(2019, 6, 8, 13, 30, 1, 685, DateTimeKind.Local).AddTicks(5778), "Lucie32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 6, 8, 13, 30, 1, 702, DateTimeKind.Local).AddTicks(7746), "Ardith.Cummings95@yahoo.com", "XKm4g0rS/kMzXDlq1A0xd0Mj1UTKz78QZqEIjGiVzaI=", "joVmnahae87VaRCkiCZANdQn93d2cMmII5sssUek7AQ=", new DateTime(2019, 6, 8, 13, 30, 1, 702, DateTimeKind.Local).AddTicks(7844), "Benton99" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 6, 8, 13, 30, 1, 724, DateTimeKind.Local).AddTicks(7786), "Wilfrid54@yahoo.com", "dymXvZziyvE784wDCRRuv+Kazm4duf2yUAZQJG9MFzw=", "6iWfzQsuyR5S7/Xx02k+yJV5y6UWvnNU4rUmZYTba58=", new DateTime(2019, 6, 8, 13, 30, 1, 724, DateTimeKind.Local).AddTicks(7875), "Shaylee.King" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 6, 8, 13, 30, 1, 741, DateTimeKind.Local).AddTicks(6309), "Harold.Rowe71@yahoo.com", "LoU3WAtUBJTUjad+UJqki5rZ6n/M9omgb/3+yVk7vMw=", "n/uUFtMkyUefMnQNz/j6Vaqzr/osn7pBREHzWM8lIU8=", new DateTime(2019, 6, 8, 13, 30, 1, 741, DateTimeKind.Local).AddTicks(6406), "Cali.Waters" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 753, DateTimeKind.Local).AddTicks(8333), "Samanta_OReilly95@yahoo.com", "+YA8dDK1ZoLFTvfpnVQGzmhKXHRaAgN/fQjmZMVMGcM=", "Bhn9S4MMVApZjnGJUamRVV4ikTzCgdc/KBbTMldMsjY=", new DateTime(2019, 6, 8, 13, 30, 1, 753, DateTimeKind.Local).AddTicks(8426), "Baylee_Sipes42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 6, 8, 13, 30, 1, 765, DateTimeKind.Local).AddTicks(8563), "Rex64@hotmail.com", "JOICOM6OozRPh4VLEbxS/iJMsI1HhHyOdDtuG4tau78=", "EdoXXUo+awEKlbwKaH/IFKIzz1Ybyl69YYeYJACQ/nM=", new DateTime(2019, 6, 8, 13, 30, 1, 765, DateTimeKind.Local).AddTicks(8648), "Sharon32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 6, 8, 13, 30, 1, 779, DateTimeKind.Local).AddTicks(1504), "Brice_Abshire72@gmail.com", "D+HiHDuS3LIsqdZUuSEQeZ0VSpvsWiTYTKiW1JwGMPU=", "unJ1mBlcdh5pmmYITwm9s49RsQknqWgoUYsqdrOvjbI=", new DateTime(2019, 6, 8, 13, 30, 1, 779, DateTimeKind.Local).AddTicks(1590), "Kayla46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 791, DateTimeKind.Local).AddTicks(1782), "i2TJ0z00NYlgYE1RckEz65RuduHNOi6XLzkY/zjls3M=", "OfXWhBQuNh3ZiHzV/LYq5X7zvFdI56jXiAJ/cQcbvJM=", new DateTime(2019, 6, 8, 13, 30, 1, 791, DateTimeKind.Local).AddTicks(1782) });
        }
    }
}
