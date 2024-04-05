using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnniesPastryShop.Infrastructure.Migrations
{
    public partial class RemoveCustomerURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "212110fc-6d85-4fd5-92d4-3d6632f1ed00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c28cd7f-b58c-4188-acc4-8e3c34dd4a68");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d4479685-1c48-4280-8771-65d2b69e66d1", "425c9abe-ce7a-4306-bce2-e2d5bc82901f", "Administrator", null },
                    { "dd247a64-5d3d-4a49-8d2c-ddebb9fe15ab", "002b8355-a54c-415c-b0ea-06ce5f04a717", "Moderator", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3ca66cf-7383-44d8-b360-b77c71bcde4d", "AQAAAAEAACcQAAAAEOBnVWARVdFdSwL7Le/4UVMW2pZJ0Y96MiWIt4lOZhYFszaQJzVuCJdJIGVODsAwUg==", "f5c02596-928c-47cd-94bf-0edaa4e4c21d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d7435-4fc8-78d9-d6b3ac1f591z",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a94736f0-d77c-437c-b229-13e3fb6ccb9b", "AQAAAAEAACcQAAAAEI9+fuqL1Nu8iRcV0ljWB+c92wJP6Uv5Xak9Ub9W+Kzl+fx3VxaPOIIT/L/EKPrUsg==", "bba69de2-ff09-4eb0-bbad-02534ddb836b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37d71a7e-5760-4acf-a01e-fb6dc22eb80d", "AQAAAAEAACcQAAAAEA/Igu2MIwugqWxWlASEIblhGsQRfBRdeuZqk263/LbCSgGtRhfOiEmD4TNVcQB2/A==", "38cb57d1-16ce-46ce-91dc-11a08e266238" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4479685-1c48-4280-8771-65d2b69e66d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd247a64-5d3d-4a49-8d2c-ddebb9fe15ab");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Customer image URL");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "212110fc-6d85-4fd5-92d4-3d6632f1ed00", "15632a32-5b43-4e40-9d04-ada2b8d10d1a", "Administrator", null },
                    { "6c28cd7f-b58c-4188-acc4-8e3c34dd4a68", "9152d68c-eb99-4da9-8bd2-bbaa85ef4392", "Moderator", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7a16305-8f35-48ab-a874-facc65466452", "AQAAAAEAACcQAAAAEJ6Bsy6kYzDRJi1HaadvGbE1V8BKJcvOEv5BBHFbMr06XUSYK/0CU6Vsykh/jDOBug==", "37aed4ca-706e-49ad-bf15-87f8e6f9b156" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d7435-4fc8-78d9-d6b3ac1f591z",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e65437c1-1c03-412b-bc6b-809e66209dc6", "AQAAAAEAACcQAAAAEI6Yq7fqfhBkRtNfg2N+mwmUQ5HrZh69Bn7AerE5GEUGNHOoEAijNSsQDATJZSOurg==", "b6645f29-bbd7-4001-b253-cdebd3ed3552" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3953dc67-9c1e-43ee-b452-ca881a335e2d", "AQAAAAEAACcQAAAAEDwWTy3qp+6t7lf5agsnKt6mEaP2U/94hBzYA3zaMH4D2ccNYSKwsh4HOVOAZNXohw==", "a70084c6-668c-42d5-acfc-87b57fd38151" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.dropbox.com/scl/fi/2ubtzb4vzkyeolsbk55n8/315091820_218444830534539_6229220902423040954_n.jpg?rlkey=vakd1rubnbe5fa13m779jgr29&dl=1");
        }
    }
}
