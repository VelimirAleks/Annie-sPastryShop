using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnniesPastryShop.Infrastructure.Migrations
{
    public partial class FIX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7c27478-f282-473d-85d7-0a7c1bc95f4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b20c031b-e823-4c05-9ab8-a3d3315595b2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "020c95c2-58ec-47ea-a916-6ef861a5cffb", "d97c2804-9b84-47bc-90c5-48b2f6d40d95", "Administrator", null },
                    { "c812ca7f-a613-44cc-b979-0007dc3abfe3", "51859851-b2fb-4564-9a3c-0ac3fd48ed6b", "Moderator", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "759c1e9a-86c6-4943-9242-fe3014ecae66", "AQAAAAEAACcQAAAAEFatXLtceODg8cE235aaTAHYhRbd+OQEdewnCVB0ZMh4352KMYkxdDCZNpHy7Et47Q==", "02238da1-c77e-41de-924e-460ea1d5161e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d7435-4fc8-78d9-d6b3ac1f591z",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6b7c363-64c5-4167-8764-2c3064d735db", "AQAAAAEAACcQAAAAEIw2x1a5BUlxOQopkBEQ2zaQet7j8lL5u683uOS/KbCpFwnSDPkr9UOYLX2LYf2u9Q==", "e3a73f78-2d33-481b-b160-67b69c4f4016" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e99f577-1246-448e-b6c7-418232710565", "AQAAAAEAACcQAAAAEJWt5PAYutmUMM0ihxbyTUgNfPGUowwxJIOVqPikVC+B33eJyQTnrcuqIUEfMesO8g==", "e0651ba3-4c48-48e9-ae4e-74670366f57d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "020c95c2-58ec-47ea-a916-6ef861a5cffb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c812ca7f-a613-44cc-b979-0007dc3abfe3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7c27478-f282-473d-85d7-0a7c1bc95f4f", "4ef8638a-bb53-4716-8814-12dd3c090ffb", "Administrator", null },
                    { "b20c031b-e823-4c05-9ab8-a3d3315595b2", "9b794bcb-cc7d-4293-9629-51394d138f18", "Moderator", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "846fcb57-5b1a-489e-9e48-af989461fdb9", "AQAAAAEAACcQAAAAEIuK/aJf+jUi8PzJHPUtarQKzkHolSXEQmc4mxf0VFlkoHHQfeDY9kTwkqrama7wOQ==", "dbeb188b-11b0-4f87-ae1b-48ffb276f63b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d7435-4fc8-78d9-d6b3ac1f591z",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccf621f1-9dd5-40ec-8886-5549b769214e", "AQAAAAEAACcQAAAAEBHm90GSjilICqUUSr5rbeSaYu5pDgtktOi3s+BT1s2HKvSFbjv1bjeAz4ckwURXxQ==", "216c6608-d9f7-4389-8b96-9ed7020c4bba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e5b1fe0-ff60-40f0-8b97-799a265523cf", "AQAAAAEAACcQAAAAEOSg5ijlpRkPZwWt0PQHBZM2Gf5WqSMUBPQE5S5HmP6t+72Y3WGOpj2QV2vqImLkpw==", "72f3d3a8-1850-4d6e-be29-c4094da0d6e6" });
        }
    }
}
