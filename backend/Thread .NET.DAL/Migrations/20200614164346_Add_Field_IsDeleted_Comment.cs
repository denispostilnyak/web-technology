using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class Add_Field_IsDeleted_Comment : Migration
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
                table: "Comments",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 20, "Iure sapiente repellendus tempore voluptatibus repudiandae velit sit.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5299), new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5310) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Adipisci expedita eius inventore.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5987), 11, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Quod in maiores voluptas dolor omnis.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6079), 8, new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6088) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1, "Excepturi quaerat quia nam.", new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6342), new DateTime(2020, 6, 14, 19, 43, 45, 252, DateTimeKind.Local).AddTicks(6351) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Sit unde libero assumenda unde occaecati ullam nihil.", new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(8255), 33, new DateTime(2020, 6, 14, 19, 43, 45, 242, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Pariatur sunt et unde vel et nostrum at voluptatem. Repellendus aspernatur fuga. Vel voluptates deleniti rerum harum enim sit quod. Repellat tempora tempore in neque perspiciatis odit eum. Fuga laborum nesciunt est debitis animi illum minima. Debitis sint ut aut.", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(84), 34, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(109) });

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
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "nemo", new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(1141), 40, new DateTime(2020, 6, 14, 19, 43, 45, 243, DateTimeKind.Local).AddTicks(1150) });

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
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2020, 6, 14, 19, 43, 45, 34, DateTimeKind.Local).AddTicks(100), "Eli_Turcotte@hotmail.com", "1bSNYvHThGgxkpWJMRbd56hzf4uARwr7ernndalR4tE=", "Of1mKice+yHlcb2jwA5zlMJdYjVXt8C5jP3oOnAH9+U=", new DateTime(2020, 6, 14, 19, 43, 45, 34, DateTimeKind.Local).AddTicks(155), "Sidney4" });

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
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 45, 98, DateTimeKind.Local).AddTicks(8034), "Bernadette89@yahoo.com", "Co+2Y+8Oc0a39OoWiCfkXvS/BxgD9euszL2tMj1rjso=", "NYNNBQIkVZfpGdELEMGIwpuJ+JIfLDGOIXcSGSIRGRg=", new DateTime(2020, 6, 14, 19, 43, 45, 98, DateTimeKind.Local).AddTicks(8109), "Angelica_Reichel15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2020, 6, 14, 19, 43, 45, 110, DateTimeKind.Local).AddTicks(6029), "Jace.Legros42@gmail.com", "paMmKdU4w0M62wf4hXmaWlzfIhKM2kzxExAqh8B8bNw=", "METagVut4xsd/W++OtFeZIl8/hLFBho/CAusq775GkU=", new DateTime(2020, 6, 14, 19, 43, 45, 110, DateTimeKind.Local).AddTicks(6068), "Ernest_Wisozk" });

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
                table: "Comments");

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 3, "Ut quis id eum velit nihil quia.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(4552), new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(4570) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 15, "Nisi voluptatem sint facere perferendis sit.", new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6021), new DateTime(2020, 6, 14, 9, 48, 34, 43, DateTimeKind.Local).AddTicks(6029) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "Corporis iste officia non eos vel qui.", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(133), 31, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Eum eveniet libero.", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(212), 28, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(220) });

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
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "omnis", new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(1618), 25, new DateTime(2020, 6, 14, 9, 48, 34, 34, DateTimeKind.Local).AddTicks(1626) });

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
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2020, 6, 14, 9, 48, 33, 830, DateTimeKind.Local).AddTicks(81), "Godfrey_Larkin99@hotmail.com", "Dsk9J/2EwkXpj94FecFoh76QRrcc1c9cEMcEr8zTMeo=", "a09aavhDYtiwm9KFzxi/P8+ODV1cCz5T3m8/u6+jgRw=", new DateTime(2020, 6, 14, 9, 48, 33, 830, DateTimeKind.Local).AddTicks(144), "Reilly_Bode" });

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
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2020, 6, 14, 9, 48, 33, 888, DateTimeKind.Local).AddTicks(8475), "Arthur33@gmail.com", "0QanDLzv1EXrUn/3/h8PUybLM4rS24NsDhPf81hsQ3c=", "GcbeQhjJhLfIsHG+ZzpwMw5PMiOhuNO3qUCMTucdOOI=", new DateTime(2020, 6, 14, 9, 48, 33, 888, DateTimeKind.Local).AddTicks(8526), "Pattie80" });

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
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2020, 6, 14, 9, 48, 33, 983, DateTimeKind.Local).AddTicks(2831), "Clifford_Gorczany@yahoo.com", "euZvW1lcmlm+/ibJaD1Gi7TJSroaOGNvVZhoRE52f/4=", "5aA9cqa/RXNNQ7gAvixR/mTtQW3o7GkoaSU6+eqrDXI=", new DateTime(2020, 6, 14, 9, 48, 33, 983, DateTimeKind.Local).AddTicks(2864), "Brendon_Gusikowski" });

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
    }
}
