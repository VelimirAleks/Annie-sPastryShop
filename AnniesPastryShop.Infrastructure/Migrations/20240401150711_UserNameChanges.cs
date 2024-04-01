using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnniesPastryShop.Infrastructure.Migrations
{
    public partial class UserNameChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ceabd70-7fa1-4a2e-b7b2-31c91f5b74e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a507206-39aa-41d9-971d-91dc2ebd8fe4");

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b7a16305-8f35-48ab-a874-facc65466452", "admin@gmail.com", "admin@gmail.com", "AQAAAAEAACcQAAAAEJ6Bsy6kYzDRJi1HaadvGbE1V8BKJcvOEv5BBHFbMr06XUSYK/0CU6Vsykh/jDOBug==", "37aed4ca-706e-49ad-bf15-87f8e6f9b156", "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d7435-4fc8-78d9-d6b3ac1f591z",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e65437c1-1c03-412b-bc6b-809e66209dc6", "moderator@gmail.com", "moderator@gmail.com", "AQAAAAEAACcQAAAAEI6Yq7fqfhBkRtNfg2N+mwmUQ5HrZh69Bn7AerE5GEUGNHOoEAijNSsQDATJZSOurg==", "b6645f29-bbd7-4001-b253-cdebd3ed3552", "moderator@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3953dc67-9c1e-43ee-b452-ca881a335e2d", "customer@gmail.com", "customer@gmail.com", "AQAAAAEAACcQAAAAEDwWTy3qp+6t7lf5agsnKt6mEaP2U/94hBzYA3zaMH4D2ccNYSKwsh4HOVOAZNXohw==", "a70084c6-668c-42d5-acfc-87b57fd38151", "customer@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "212110fc-6d85-4fd5-92d4-3d6632f1ed00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c28cd7f-b58c-4188-acc4-8e3c34dd4a68");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ceabd70-7fa1-4a2e-b7b2-31c91f5b74e4", "f91cf1bb-2747-41c5-b74c-a2940e0dfb67", "Administrator", null },
                    { "6a507206-39aa-41d9-971d-91dc2ebd8fe4", "84905cc4-e2c3-4d62-8801-aab014a175be", "Moderator", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bef7d71c-92a2-4559-89d0-af99780d55ab", null, null, "AQAAAAEAACcQAAAAEFelg4MJGOjWF+FVTmh1Cha3UECXt6LXO5uq5EcVbpac0PeYdu5ZnZclhdVnznkDrw==", "40406175-2641-471c-b0d9-fd25ae018a15", "admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d7435-4fc8-78d9-d6b3ac1f591z",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0e713492-f911-43db-ae8f-8a163e311a1e", null, null, "AQAAAAEAACcQAAAAEPbr6Hw+IAoIdRbHkRmZzqslj/osZH5EudztKO9fHvuQnLbWSTvo41mzWIXAFkdbjg==", "56df329c-9438-4738-bf66-ad33ae328e06", "moderator" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b9576873-e1e2-43cb-8d23-455bba9ec21f", null, null, "AQAAAAEAACcQAAAAELogKJdPtYXEXKiZGsHGnHcb+u2GGc1IpR0nfkkgd2Ocgxenhdn1uyTXJEISXkoQDg==", "265708b9-e2dc-4bbf-b088-ff937af0403c", "customer" });
        }
    }
}
