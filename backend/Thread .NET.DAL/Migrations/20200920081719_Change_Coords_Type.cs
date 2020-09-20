using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class Change_Coords_Type : Migration
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

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Sunt et officia odit consequuntur velit ad.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(1749), 11, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Quia aut voluptates consequatur asperiores officiis quod officiis voluptas enim.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(5672), 19, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Incidunt et enim dolorem ab pariatur.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(6063), 6, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Mollitia fugiat rem.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(6316), 6, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Et deleniti qui placeat autem saepe cum dolorem aliquam.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(6638), 13, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Laudantium quod quo.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(6787), 14, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Illo ex cum vel.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(7407), 5, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Incidunt et dolorem quia architecto sed.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(7738), 12, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Dolore commodi est dolorem sed atque iste voluptatem illo ut.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(8101), 17, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Occaecati sit ad qui nostrum animi recusandae ipsum illum.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(8411), 8, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 14, "Natus ut excepturi sapiente dolor.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(8683), new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Similique dolores aliquid animi cupiditate inventore.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(8961), 17, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Possimus enim autem officia iure aut.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(9373), 19, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Et quod facilis est et consequuntur commodi pariatur natus eius.", new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(9799), 7, new DateTime(2020, 9, 20, 11, 17, 18, 182, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Corporis sequi molestiae ad accusantium voluptatibus tempore et ut accusantium.", new DateTime(2020, 9, 20, 11, 17, 18, 183, DateTimeKind.Local).AddTicks(166), 16, new DateTime(2020, 9, 20, 11, 17, 18, 183, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Delectus similique est.", new DateTime(2020, 9, 20, 11, 17, 18, 183, DateTimeKind.Local).AddTicks(397), 4, new DateTime(2020, 9, 20, 11, 17, 18, 183, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Doloremque dolore nihil sed omnis nulla et modi.", new DateTime(2020, 9, 20, 11, 17, 18, 183, DateTimeKind.Local).AddTicks(706), 14, new DateTime(2020, 9, 20, 11, 17, 18, 183, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Ex possimus aut aut delectus rerum neque.", new DateTime(2020, 9, 20, 11, 17, 18, 183, DateTimeKind.Local).AddTicks(1123), 2, new DateTime(2020, 9, 20, 11, 17, 18, 183, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 3, "Quaerat voluptatem aut quo excepturi delectus quis neque quibusdam.", new DateTime(2020, 9, 20, 11, 17, 18, 183, DateTimeKind.Local).AddTicks(1439), new DateTime(2020, 9, 20, 11, 17, 18, 183, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Quis ad et.", new DateTime(2020, 9, 20, 11, 17, 18, 183, DateTimeKind.Local).AddTicks(1666), 13, new DateTime(2020, 9, 20, 11, 17, 18, 183, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 798, DateTimeKind.Local).AddTicks(9194), "https://s3.amazonaws.com/uifaces/faces/twitter/gauchomatt/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 799, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(983), "https://s3.amazonaws.com/uifaces/faces/twitter/craighenneberry/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1191), "https://s3.amazonaws.com/uifaces/faces/twitter/claudioguglieri/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1329), "https://s3.amazonaws.com/uifaces/faces/twitter/kaysix_dizzy/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1453), "https://s3.amazonaws.com/uifaces/faces/twitter/doooon/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1592), "https://s3.amazonaws.com/uifaces/faces/twitter/bargaorobalo/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1714), "https://s3.amazonaws.com/uifaces/faces/twitter/andrewofficer/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1841), "https://s3.amazonaws.com/uifaces/faces/twitter/tweetubhai/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2076), "https://s3.amazonaws.com/uifaces/faces/twitter/kevinjohndayy/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2205), "https://s3.amazonaws.com/uifaces/faces/twitter/kevinoh/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2335), "https://s3.amazonaws.com/uifaces/faces/twitter/carlosjgsousa/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2461), "https://s3.amazonaws.com/uifaces/faces/twitter/raphaelnikson/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2603), "https://s3.amazonaws.com/uifaces/faces/twitter/alagoon/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2678), "https://s3.amazonaws.com/uifaces/faces/twitter/rehatkathuria/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2744), "https://s3.amazonaws.com/uifaces/faces/twitter/jayrobinson/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2883), "https://s3.amazonaws.com/uifaces/faces/twitter/vitor376/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(3033), "https://s3.amazonaws.com/uifaces/faces/twitter/sydlawrence/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(3156), "https://s3.amazonaws.com/uifaces/faces/twitter/davidcazalis/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(3273), "https://s3.amazonaws.com/uifaces/faces/twitter/danpliego/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(3366), "https://s3.amazonaws.com/uifaces/faces/twitter/chrisstumph/128.jpg", new DateTime(2020, 9, 20, 11, 17, 17, 800, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(1714), "https://picsum.photos/640/480/?image=96", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3487), "https://picsum.photos/640/480/?image=743", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3627), "https://picsum.photos/640/480/?image=515", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3696), "https://picsum.photos/640/480/?image=462", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3763), "https://picsum.photos/640/480/?image=908", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3828), "https://picsum.photos/640/480/?image=155", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3894), "https://picsum.photos/640/480/?image=1023", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3964), "https://picsum.photos/640/480/?image=44", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4031), "https://picsum.photos/640/480/?image=1046", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4098), "https://picsum.photos/640/480/?image=194", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4162), "https://picsum.photos/640/480/?image=368", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4242), "https://picsum.photos/640/480/?image=394", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4311), "https://picsum.photos/640/480/?image=575", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4382), "https://picsum.photos/640/480/?image=389", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4455), "https://picsum.photos/640/480/?image=290", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4523), "https://picsum.photos/640/480/?image=595", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4590), "https://picsum.photos/640/480/?image=957", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4657), "https://picsum.photos/640/480/?image=783", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4726), "https://picsum.photos/640/480/?image=756", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4793), "https://picsum.photos/640/480/?image=985", new DateTime(2020, 9, 20, 11, 17, 17, 814, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 20, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(4163), true, 20, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(4189), 15 },
                    { 19, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(4029), false, 11, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(4052), 9 },
                    { 17, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3766), true, 12, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3792), 21 },
                    { 16, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3631), true, 12, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3655), 19 },
                    { 15, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3500), true, 4, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3514), 7 },
                    { 14, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3405), true, 1, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3420), 6 },
                    { 13, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3212), true, 17, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3238), 3 },
                    { 12, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3072), true, 14, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3099), 11 },
                    { 11, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2963), false, 2, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2993), 6 },
                    { 10, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2813), true, 8, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2840), 7 },
                    { 9, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2735), true, 11, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2748), 10 },
                    { 8, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2622), true, 14, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2642), 19 },
                    { 7, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2463), false, 17, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2493), 9 },
                    { 6, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2305), true, 16, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2330), 18 },
                    { 5, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2183), false, 2, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(2199), 12 },
                    { 4, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(1541), false, 20, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(1987), 4 },
                    { 3, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(1407), false, 8, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(1435), 15 },
                    { 18, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3901), false, 10, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(3921), 15 },
                    { 2, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(1213), false, 19, new DateTime(2020, 9, 20, 11, 17, 18, 206, DateTimeKind.Local).AddTicks(1273), 10 },
                    { 1, new DateTime(2020, 9, 20, 11, 17, 18, 205, DateTimeKind.Local).AddTicks(8139), false, 20, new DateTime(2020, 9, 20, 11, 17, 18, 205, DateTimeKind.Local).AddTicks(9666), 9 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Sequi aut laborum sit dolorem nam autem modi ut quaerat.", new DateTime(2020, 9, 20, 11, 17, 18, 168, DateTimeKind.Local).AddTicks(7755), 30, new DateTime(2020, 9, 20, 11, 17, 18, 168, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Ea quidem neque ut quis accusamus corrupti incidunt nemo.", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(154), 30, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "qui", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(815), 25, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, @"At vitae vero voluptatem voluptas sint.
Sed laboriosam voluptatem quidem voluptas.
Nostrum possimus doloribus quibusdam laboriosam.
Ipsam eum est.", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(5446), 29, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Itaque itaque ipsum qui qui dolor. Eius ea alias. Accusamus est repudiandae.", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7302), 37, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "mollitia", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7419), 30, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "rem", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7484), 35, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "voluptate", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7547), 24, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "harum", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7612), 39, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, @"Mollitia dolorem dignissimos vel veritatis quaerat.
In doloribus possimus.", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7762), 30, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "Beatae modi voluptas laboriosam earum tempora totam.", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7877), 24, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Recusandae aut est quasi cupiditate et est. Labore commodi dolor dolor in recusandae dolor. Placeat est deserunt. Omnis perspiciatis dolorem voluptate id quia est vel rerum in.", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(8337), 29, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Voluptas explicabo tempore sint incidunt tempora.", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(8528), 38, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Odio perspiciatis earum aut quae reprehenderit ducimus fugit.", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(9410), 24, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Ipsam laudantium aliquid omnis quibusdam omnis voluptas sapiente aut. Tenetur est vitae in eum quam. Quasi eos labore qui delectus. Ut soluta voluptas.", new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(9829), 32, new DateTime(2020, 9, 20, 11, 17, 18, 169, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Sint mollitia recusandae nostrum ex blanditiis debitis.", new DateTime(2020, 9, 20, 11, 17, 18, 170, DateTimeKind.Local).AddTicks(231), 34, new DateTime(2020, 9, 20, 11, 17, 18, 170, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Possimus laboriosam neque doloribus in sapiente.", new DateTime(2020, 9, 20, 11, 17, 18, 170, DateTimeKind.Local).AddTicks(371), 40, new DateTime(2020, 9, 20, 11, 17, 18, 170, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, @"Doloribus voluptatem ex aliquid voluptate sed.
Aperiam repellat saepe cum officia totam ea tempore autem.
Autem ut est.
Excepturi omnis eligendi.
Eveniet dolore minima et natus sit officia impedit.
Id repellendus recusandae consequatur quae omnis et.", new DateTime(2020, 9, 20, 11, 17, 18, 170, DateTimeKind.Local).AddTicks(1037), 21, new DateTime(2020, 9, 20, 11, 17, 18, 170, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, @"Optio et qui ipsum tenetur labore sequi sed ea.
Autem distinctio quisquam molestias officiis deserunt.", new DateTime(2020, 9, 20, 11, 17, 18, 170, DateTimeKind.Local).AddTicks(1285), 25, new DateTime(2020, 9, 20, 11, 17, 18, 170, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, @"Tenetur facere necessitatibus vero aperiam sit dolor rerum ut dolorem.
Laborum officiis sed et.", new DateTime(2020, 9, 20, 11, 17, 18, 170, DateTimeKind.Local).AddTicks(1548), 32, new DateTime(2020, 9, 20, 11, 17, 18, 170, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2020, 9, 20, 11, 17, 17, 887, DateTimeKind.Local).AddTicks(477), "Valerie56@gmail.com", 0.0, 0.0, "RAxVJjBw4VaA/Fgv7vDzBWIFiGXcZ9FGyRnEDhxmeL4=", "ndxv+T8eHj53x/F1jxkBQcEfuyS2pK3yNawhVXE7h6E=", new DateTime(2020, 9, 20, 11, 17, 17, 887, DateTimeKind.Local).AddTicks(1394), "Paula98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2020, 9, 20, 11, 17, 17, 900, DateTimeKind.Local).AddTicks(4885), "Sheridan.Moore33@gmail.com", 0.0, 0.0, "GpDjx1ocDWbhKENKpI2NMhCvA3Dk/5kCGUQjaavvM5c=", "nUhYYm3I/t0wnQUNnoy+Pc1xeslVcNOs1hhoyGjKqhA=", new DateTime(2020, 9, 20, 11, 17, 17, 900, DateTimeKind.Local).AddTicks(4995), "Lawson_Paucek49" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2020, 9, 20, 11, 17, 17, 912, DateTimeKind.Local).AddTicks(9014), "Flavie_Bednar@yahoo.com", 0.0, 0.0, "VQ+SPBcPjryL3yl1ZpWW788wyuUis9cvqAhqkckQ8tg=", "IwAzQC2ApY3OJsjT5IS0XursX0tkx1LrqtRzAVd3vN0=", new DateTime(2020, 9, 20, 11, 17, 17, 912, DateTimeKind.Local).AddTicks(9102), "Alden.Boehm85" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2020, 9, 20, 11, 17, 17, 925, DateTimeKind.Local).AddTicks(9163), "Trinity.Rosenbaum50@gmail.com", 0.0, 0.0, "8vyo0HfCynGLXb0cSPkd9hsAWdlYnjaLVPb2IwDBjdc=", "E4xtHJwHxeJ+GOd9vV0VZNNTyGxFB8CPmu96c+qQ2E4=", new DateTime(2020, 9, 20, 11, 17, 17, 925, DateTimeKind.Local).AddTicks(9254), "Juliana92" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2020, 9, 20, 11, 17, 17, 939, DateTimeKind.Local).AddTicks(7905), "Zoila.Simonis@hotmail.com", 0.0, 0.0, "L49seZKXb2UasfxwvcEGU32m2SiYtflO1Qu+1vY4rec=", "RzwpXNdaueDQ4sE62tAGujW+SQ/KXv9ZmX8f0t9cNjo=", new DateTime(2020, 9, 20, 11, 17, 17, 939, DateTimeKind.Local).AddTicks(8025), "Buck62" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2020, 9, 20, 11, 17, 17, 953, DateTimeKind.Local).AddTicks(4987), "Joannie_Block@yahoo.com", 0.0, 0.0, "MogqDbTQ1BTiCK497biWL8kYw9CVIsO0WdO3LTQysOE=", "ix8C02PCzSsxK2TCe0brWA5dxu0QbOithKd2/+kKXn8=", new DateTime(2020, 9, 20, 11, 17, 17, 953, DateTimeKind.Local).AddTicks(5078), "Junior40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2020, 9, 20, 11, 17, 17, 966, DateTimeKind.Local).AddTicks(2820), "Elinore_Smith68@gmail.com", 0.0, 0.0, "9KEKTBGbJ/B8Z9FQqA5lPXGpEjwV6K7ZejmhybT/Avw=", "m2X1ivMu7fMs3ls9UkuBQ6+PJEEmXaj3Z2JuJ3Ws/+U=", new DateTime(2020, 9, 20, 11, 17, 17, 966, DateTimeKind.Local).AddTicks(2913), "Trey34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2020, 9, 20, 11, 17, 17, 980, DateTimeKind.Local).AddTicks(8184), "Cyrus2@gmail.com", 0.0, 0.0, "Vi27zYFWx6YHy4IDz/aFQtc+Vn0WK0uoM9mO4D4RX/M=", "fYpsB2ss9TieY6Pz12qKjMefZ9tJ2g6KKZAWjrId/W4=", new DateTime(2020, 9, 20, 11, 17, 17, 980, DateTimeKind.Local).AddTicks(8280), "Breanna.OReilly" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2020, 9, 20, 11, 17, 17, 993, DateTimeKind.Local).AddTicks(2522), "Aniya44@hotmail.com", 0.0, 0.0, "OQlq7plKykKSe2H7hzH1vSqu8SqXUVtC9HgN98ssUJI=", "MMSIBD94Q6lH/vtW6fLLyhTDeUWYY5OM7oq6FYUenG0=", new DateTime(2020, 9, 20, 11, 17, 17, 993, DateTimeKind.Local).AddTicks(2607), "Ken76" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2020, 9, 20, 11, 17, 18, 5, DateTimeKind.Local).AddTicks(5822), "Wellington88@yahoo.com", 0.0, 0.0, "MYy344dQuZLX/5RnpdWGA11SendqS+rMgnZBRxkO+rE=", "V7e4KQohtRMo3bLQu5Q1WG9nECGSVbM72+Kr63CiYOA=", new DateTime(2020, 9, 20, 11, 17, 18, 5, DateTimeKind.Local).AddTicks(5895), "Maggie96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 18, 18, DateTimeKind.Local).AddTicks(407), "Joelle.Kessler@gmail.com", 0.0, 0.0, "4G+HdO5KtBDDyj7lB9xpz/gnElLvQo6uDXZhig69l9E=", "QKwPTPy0BAtC35Hzo1xPNv3MaoIkQ9TISygWkh7JsJk=", new DateTime(2020, 9, 20, 11, 17, 18, 18, DateTimeKind.Local).AddTicks(480), "Keenan_West" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2020, 9, 20, 11, 17, 18, 30, DateTimeKind.Local).AddTicks(530), "Bethany0@yahoo.com", 0.0, 0.0, "GxGT8rORMR/FAezpNqdRdp8iT+jROnLzAb7lfgeb8zI=", "p66EVyirY/rY1Zb6iNF4jrAtW5ktx1AMrfW/2DyPc3o=", new DateTime(2020, 9, 20, 11, 17, 18, 30, DateTimeKind.Local).AddTicks(580), "Dora27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2020, 9, 20, 11, 17, 18, 42, DateTimeKind.Local).AddTicks(674), "Mason69@gmail.com", 0.0, 0.0, "1GW+NwS9m6538bWIV3iYA9XCh0zuJE09L99VEAoC/VA=", "GgqwJzUK24yIZMMSB78IbcZCu9Dym7dJKjs0ivnJ0kk=", new DateTime(2020, 9, 20, 11, 17, 18, 42, DateTimeKind.Local).AddTicks(739), "Steve33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2020, 9, 20, 11, 17, 18, 53, DateTimeKind.Local).AddTicks(7762), "Sidney.Bogan60@gmail.com", 0.0, 0.0, "/qYBGRprbzZTWvKsKA1TXE0nL9XyO1xe2YyXf58MrYw=", "T1uKSU8BEGe4G4vW7PtmcE1a+t84t/lrbz4jI3HNqg8=", new DateTime(2020, 9, 20, 11, 17, 18, 53, DateTimeKind.Local).AddTicks(7786), "Ethan.Ondricka13" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 18, 65, DateTimeKind.Local).AddTicks(9146), "Garrison16@hotmail.com", 0.0, 0.0, "LVgX7OqPFtq+YLKxomGcFC6LasbPqdlenien71+lL3o=", "zolREQL0AN9b1WRlvdv2eT5P5Q66oJO/LPw3QDsUU8s=", new DateTime(2020, 9, 20, 11, 17, 18, 65, DateTimeKind.Local).AddTicks(9215), "Furman.Renner" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2020, 9, 20, 11, 17, 18, 77, DateTimeKind.Local).AddTicks(9634), "Kieran29@gmail.com", 0.0, 0.0, "chYLeSY5qV9IYXsSQVutytPQGN59ooqjP808d2HjPIo=", "MxIHEXRpwOcHiBAgIfN0uaeZ2PCfkU4Xu12ERi7iWaw=", new DateTime(2020, 9, 20, 11, 17, 18, 77, DateTimeKind.Local).AddTicks(9697), "Alejandrin43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2020, 9, 20, 11, 17, 18, 90, DateTimeKind.Local).AddTicks(4022), "Montana_Herman@hotmail.com", 0.0, 0.0, "pIvx49jIlJQEokvDBaG8AnhdICSkF1eb9Z1cbA/dPGw=", "ZRURuae5KV+gNH9FfPZGpa0za0D7wwzYyzJft2IVkA0=", new DateTime(2020, 9, 20, 11, 17, 18, 90, DateTimeKind.Local).AddTicks(4105), "Brandyn.Gleason" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2020, 9, 20, 11, 17, 18, 102, DateTimeKind.Local).AddTicks(7387), "Hershel_Luettgen@hotmail.com", 0.0, 0.0, "jI34/NiK1caJuE9bD2taeDL7lGQrvurQmIukbVp+PDo=", "KvTkcC87Xa4tzfvuYbyljIce3RNTlOtIWN0XlL6ttpw=", new DateTime(2020, 9, 20, 11, 17, 18, 102, DateTimeKind.Local).AddTicks(7434), "Arnold36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2020, 9, 20, 11, 17, 18, 115, DateTimeKind.Local).AddTicks(5716), "Theron73@hotmail.com", 0.0, 0.0, "vwrUFnOl01h8LO9BCF2hh35IbNoBktiRUmas5fd4gQs=", "yVuMt3fV0/o2UaDTOnx5irXH5yY34cS09aeY+Qec6V0=", new DateTime(2020, 9, 20, 11, 17, 18, 115, DateTimeKind.Local).AddTicks(5796), "Angelica_Von" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2020, 9, 20, 11, 17, 18, 133, DateTimeKind.Local).AddTicks(3592), "Rafael33@yahoo.com", 0.0, 0.0, "b8RCgln97mJ5oKm7R4SLlxerCwBnOAq8RYzinunO3TU=", "x1C70iCTL62OhvAuee3M/lnnKDE8fxPHG/xbdjxgFlM=", new DateTime(2020, 9, 20, 11, 17, 18, 133, DateTimeKind.Local).AddTicks(4918), "Suzanne.Kautzer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 11, 17, 18, 149, DateTimeKind.Local).AddTicks(7621), 0.0, 0.0, "drOsGCT3T3sTIlj6+b388G+vaCr2HhQepdnHBSFHUME=", "8yii0fqnVOMdrzhHjfYbEaEVl6pXdqKWJ6g9S0bnHGw=", new DateTime(2020, 9, 20, 11, 17, 18, 149, DateTimeKind.Local).AddTicks(7621) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<int>(
                name: "Longitude",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Latitude",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

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
                    { 1, 20, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(151), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(1007), 16 },
                    { 9, 8, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3075), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3082), 6 },
                    { 11, 2, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3172), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3180), 2 },
                    { 12, 4, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3219), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3227), 18 },
                    { 13, 8, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3266), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3274), 8 },
                    { 14, 14, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3315), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3323), 10 },
                    { 15, 18, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3363), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3371), 4 },
                    { 16, 16, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3413), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3421), 1 },
                    { 17, 20, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3462), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3470), 9 },
                    { 10, 5, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3123), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3131), 18 },
                    { 18, 5, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3510), true, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3518), 21 },
                    { 19, 20, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3557), false, new DateTime(2020, 9, 20, 10, 50, 40, 714, DateTimeKind.Local).AddTicks(3565), 4 }
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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 15, "Nobis expedita sapiente quae in.", new DateTime(2020, 9, 20, 10, 50, 40, 673, DateTimeKind.Local).AddTicks(9977), new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(4) });

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
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Qui ipsum aut consequuntur in iure repellat earum aut sed.", new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(2168), 12, new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 19, "Temporibus quia ut.", new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(2390), new DateTime(2020, 9, 20, 10, 50, 40, 674, DateTimeKind.Local).AddTicks(2408) });

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
                    { 20, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(6098), true, 14, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(6111), 19 },
                    { 19, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5975), false, 6, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5995), 12 },
                    { 17, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5739), true, 8, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5767), 21 },
                    { 16, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5606), true, 1, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5632), 4 },
                    { 15, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5447), false, 17, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5478), 15 },
                    { 14, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5316), false, 8, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5334), 19 },
                    { 13, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5229), true, 5, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5242), 21 },
                    { 12, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5110), false, 18, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5139), 17 },
                    { 11, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5029), true, 9, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5042), 18 },
                    { 10, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4925), false, 3, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4955), 16 },
                    { 9, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4769), true, 20, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4799), 7 },
                    { 8, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4675), true, 18, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4686), 19 },
                    { 7, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4550), false, 17, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4576), 8 },
                    { 6, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4133), true, 3, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4159), 6 },
                    { 5, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4001), true, 19, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(4019), 7 },
                    { 4, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(3870), false, 9, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(3897), 3 },
                    { 3, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(3727), false, 6, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(3755), 16 },
                    { 18, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5842), false, 8, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(5868), 11 },
                    { 2, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(3539), false, 3, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(3591), 21 },
                    { 1, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(603), false, 18, new DateTime(2020, 9, 20, 10, 50, 40, 696, DateTimeKind.Local).AddTicks(1954), 4 }
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
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Iure rerum officiis incidunt doloribus enim qui. Tempore aperiam accusamus iure. Unde nesciunt enim ipsam et praesentium est rerum odio et. Sit occaecati voluptatem tempora laborum soluta eligendi animi debitis. Alias consequatur in alias occaecati alias aut dolore est non.", new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(6504), 39, new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(6519) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Temporibus nihil et amet harum sint ut quod. Et soluta aliquid inventore magnam et fugit dolor dicta. Eum unde sapiente mollitia nemo.", new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(8302), 39, new DateTime(2020, 9, 20, 10, 50, 40, 655, DateTimeKind.Local).AddTicks(8312) });

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
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Voluptatem dolores eveniet ad dolor.", new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(425), 30, new DateTime(2020, 9, 20, 10, 50, 40, 656, DateTimeKind.Local).AddTicks(454) });

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
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2020, 9, 20, 10, 50, 40, 366, DateTimeKind.Local).AddTicks(2762), "Carolanne.Gleichner96@gmail.com", 0, 0, "5/uXQxhdkd8X+CtaCLZtvoherK4Tsx4KO9pyq/Am3vk=", "eWcuiLpIouioblNE8pi/FKwC14pSWLrtcjmvcQJbazE=", new DateTime(2020, 9, 20, 10, 50, 40, 366, DateTimeKind.Local).AddTicks(3650), "Margaret_Ledner" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2020, 9, 20, 10, 50, 40, 379, DateTimeKind.Local).AddTicks(455), "Maryam38@yahoo.com", 0, 0, "7eASSrmnCn1f2UjKWPFKK3jsZlHgEIYLwjPSvezmBH8=", "D9vj85j0RZ8t4lE+TVYKHUqCqgB1wR5mrmE7BgEaugI=", new DateTime(2020, 9, 20, 10, 50, 40, 379, DateTimeKind.Local).AddTicks(563), "Saige.Considine" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2020, 9, 20, 10, 50, 40, 390, DateTimeKind.Local).AddTicks(9593), "Gerardo88@hotmail.com", 0, 0, "ltzTlNrxkFdfhslKoQg3xiatIj73mw8StFCBB7qO6TU=", "PqY9e2NpWHpbD1601TiufnhTBETv2n8DIWWpdlJzf7E=", new DateTime(2020, 9, 20, 10, 50, 40, 390, DateTimeKind.Local).AddTicks(9655), "Julio_Moen" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2020, 9, 20, 10, 50, 40, 402, DateTimeKind.Local).AddTicks(6105), "Anika68@hotmail.com", 0, 0, "jkntrdMusY4DSSLeepp/j310rElTmD3EFWGknx5SOq0=", "30MddVZhjnELYYRpdbQPt9oB6NIItY2SBdVfFYR5whA=", new DateTime(2020, 9, 20, 10, 50, 40, 402, DateTimeKind.Local).AddTicks(6121), "Delilah_Leuschke" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2020, 9, 20, 10, 50, 40, 414, DateTimeKind.Local).AddTicks(5810), "Matilde.Rosenbaum90@gmail.com", 0, 0, "fe/QrHo6diIuHnXctSXtOjmpH9OiecrEA4vZ0EL9mVw=", "3rL+l0ToTptDGGrvPsiFk7bhohmjdWFLQEcl7MVRapg=", new DateTime(2020, 9, 20, 10, 50, 40, 414, DateTimeKind.Local).AddTicks(5865), "Leonor31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2020, 9, 20, 10, 50, 40, 426, DateTimeKind.Local).AddTicks(4882), "Marianne_Kuhic@yahoo.com", 0, 0, "xRE6ElOBuSrSu5PhGh9NKtEZvdBT1JKKFD2Qlsvq/Uo=", "Xph2Dob5SxeInkWOqX2BcwvqVupv4caE9Wowb9mOOMQ=", new DateTime(2020, 9, 20, 10, 50, 40, 426, DateTimeKind.Local).AddTicks(4933), "Melody_Blanda" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2020, 9, 20, 10, 50, 40, 438, DateTimeKind.Local).AddTicks(7294), "Winfield93@gmail.com", 0, 0, "voTZaHTv1kRXhu+ztCX0yJmZuhj/wNBBvrpEyHnrs/s=", "U0R62kCpy88n8vFCymNvg049DP79Km/GJtUwiGGT6HY=", new DateTime(2020, 9, 20, 10, 50, 40, 438, DateTimeKind.Local).AddTicks(7350), "Antonina.Green" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2020, 9, 20, 10, 50, 40, 450, DateTimeKind.Local).AddTicks(3741), "Terrell55@gmail.com", 0, 0, "5WjBLp41xEHdEvIOixJVTdfj6Y0cN+AFlRmMyRGItwU=", "AGcydNJ7H6DHDbyGA6fwcA7YYNGilV0frM+7eMKgixc=", new DateTime(2020, 9, 20, 10, 50, 40, 450, DateTimeKind.Local).AddTicks(3763), "Maribel_Renner" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2020, 9, 20, 10, 50, 40, 462, DateTimeKind.Local).AddTicks(6213), "Justine_Larson@yahoo.com", 0, 0, "ihC1awEaY+2K49BlxHlZDNdc7h5iFQ/V9tUivJlENcI=", "s/zlxoOWXrveNZwefw2LY97bHU8EsGFf08UwiA3TYgI=", new DateTime(2020, 9, 20, 10, 50, 40, 462, DateTimeKind.Local).AddTicks(6267), "Eryn66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2020, 9, 20, 10, 50, 40, 474, DateTimeKind.Local).AddTicks(6883), "Sigmund25@gmail.com", 0, 0, "9K0uljdQgPL1F2t6OCZJQqsMqaz/LJDpAVvtDy05Ejo=", "gCPNMKq3B8upYasJt4dtKygaONuTkhfRA1ELEnfDCig=", new DateTime(2020, 9, 20, 10, 50, 40, 474, DateTimeKind.Local).AddTicks(6937), "Deja.Armstrong" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 486, DateTimeKind.Local).AddTicks(3389), "Ralph_Altenwerth@yahoo.com", 0, 0, "u6G4qRlX+pvm5Xd3DNCwj9pw8yuG6dbiAPlg/WKoiPI=", "rWNwfFqVS43NsqA8No6D2jglkR77n85ammkaoKXIufA=", new DateTime(2020, 9, 20, 10, 50, 40, 486, DateTimeKind.Local).AddTicks(3407), "Gregorio.Bayer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2020, 9, 20, 10, 50, 40, 498, DateTimeKind.Local).AddTicks(2439), "Lyla62@hotmail.com", 0, 0, "403krANcNm0CBi28Hoqk5WekIc93UL2D+KvXhHB8NqY=", "BYvoj0QA5QjBvvchv++l9BLjOZE2gUDI6H9iPHHsdLo=", new DateTime(2020, 9, 20, 10, 50, 40, 498, DateTimeKind.Local).AddTicks(2489), "Olin84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2020, 9, 20, 10, 50, 40, 510, DateTimeKind.Local).AddTicks(3898), "Jermain_Schultz@gmail.com", 0, 0, "vbzoNnsOXioY++QXdkKQ1IPkWth1/7K5RR4E7X0Vt+Y=", "qXa2s1Z1+R+vBHs2L2T++Wrd6NjpTEn1r63vfI/aWtI=", new DateTime(2020, 9, 20, 10, 50, 40, 510, DateTimeKind.Local).AddTicks(3964), "Delmer.Tromp80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2020, 9, 20, 10, 50, 40, 523, DateTimeKind.Local).AddTicks(3875), "Katelynn_Rice@hotmail.com", 0, 0, "TpqCTYpWeIfRCGD+txM+7T1raPl2wXz8L7fvMp6ha7o=", "9Kc4DBFX2ZAtvPdCrbN4vxtytdkFd0Ep9heCJavz1KU=", new DateTime(2020, 9, 20, 10, 50, 40, 523, DateTimeKind.Local).AddTicks(4442), "Jordan.VonRueden50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 536, DateTimeKind.Local).AddTicks(4390), "Rodrigo_Pollich@yahoo.com", 0, 0, "P5vdNQFLQXZkVMji46JO1hQDYGwDNVcB6ZYTIG8pAhU=", "Z3d7y5n1wlpDSk6nM+yxP4/EIJECE0wOVNVtXm6k6aY=", new DateTime(2020, 9, 20, 10, 50, 40, 536, DateTimeKind.Local).AddTicks(4942), "Rhiannon.Baumbach99" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2020, 9, 20, 10, 50, 40, 548, DateTimeKind.Local).AddTicks(9537), "Myrna.Towne55@hotmail.com", 0, 0, "HtVNu2NRoaHObBI8xM+S4l4RG3xlVIoZwqRmmDh6K3U=", "ybFYX6kyj3duHeXo9Mr+O1lL9P/9kIUteyl+zW/skIo=", new DateTime(2020, 9, 20, 10, 50, 40, 548, DateTimeKind.Local).AddTicks(9963), "Richie_McCullough" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2020, 9, 20, 10, 50, 40, 560, DateTimeKind.Local).AddTicks(8785), "Justina.Stokes91@yahoo.com", 0, 0, "LERgRZm/hpDOmJCHQ5YsGD0SMTEMdZ3wJwf61iWGg6w=", "EnAfuItTl85F9WvOqPbrtk8vW4mlbaLOLDmbHpTo64c=", new DateTime(2020, 9, 20, 10, 50, 40, 560, DateTimeKind.Local).AddTicks(8853), "Coby_Hamill" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2020, 9, 20, 10, 50, 40, 576, DateTimeKind.Local).AddTicks(1533), "Rick.Prohaska@hotmail.com", 0, 0, "Td3H8AIF/u2VCHPmqf2gAr3FdBYb+nTpYtCPjaJr9Io=", "QWu2I7MqU5n1C1IRNKDgsudquBUyA9mG1iEpqFb1AOQ=", new DateTime(2020, 9, 20, 10, 50, 40, 576, DateTimeKind.Local).AddTicks(1651), "Layne.Senger83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2020, 9, 20, 10, 50, 40, 598, DateTimeKind.Local).AddTicks(9997), "Dane_Harris80@hotmail.com", 0, 0, "YqPJ1EyZhoD+Q9a6wGvb2Qixqx1VqRugE8baos6DGOg=", "KupJ1fqj8mndzQ8mNW+bWZPieWjDf5tbNqUaMIUpFfM=", new DateTime(2020, 9, 20, 10, 50, 40, 599, DateTimeKind.Local).AddTicks(104), "Ryleigh.Hettinger27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2020, 9, 20, 10, 50, 40, 616, DateTimeKind.Local).AddTicks(4979), "Alexandrea.Hammes@hotmail.com", 0, 0, "lP6X+h00VetXrbjwGJbSEskDfey+OPsn8Cx6HqnqL9w=", "Oe3XKeciBJJzoJhH7oAkXpdnLQIUiAVUYYi98u8edEM=", new DateTime(2020, 9, 20, 10, 50, 40, 616, DateTimeKind.Local).AddTicks(5074), "Guy.Murray" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Latitude", "Longitude", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 20, 10, 50, 40, 632, DateTimeKind.Local).AddTicks(7578), 0, 0, "5vCiXXoH0QhK0hwuQ9R+ZuVmOgylfbFiUON1qon8NBw=", "nFTK7ZtDoeYdgXsyou2fLLx+1dYCpTIDzc/wCtLUd7w=", new DateTime(2020, 9, 20, 10, 50, 40, 632, DateTimeKind.Local).AddTicks(7578) });
        }
    }
}
