using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnniesPastryShop.Infrastructure.Migrations
{
    public partial class REVIEW : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            // Create the Reviews table with the desired schema
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Add any additional indexes or constraints if needed
            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");

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
                    { "bb8e6d2e-1d5c-44c2-bbd8-900f3d0614a6", "2d4e77cf-0402-44db-8052-6549e778b2b8", "Moderator", null },
                    { "f96ab92b-54b5-4de0-b44b-ad52b640c264", "77c6f1e2-03c7-4bcc-8d4b-88a160a1e28a", "Administrator", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d42640b-b287-4486-9c38-2693007954c9", "AQAAAAEAACcQAAAAEFaE6okD/g5sQ3UMqFPbhsoqxTsMlMszH4Oszc4Fel6va9D+fSEnGOEM2LTwFKbdtg==", "c4f558bc-4128-4ab1-b03b-71a7d6a279d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d7435-4fc8-78d9-d6b3ac1f591z",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbb15793-286b-4ddc-8c5d-30b56355575a", "AQAAAAEAACcQAAAAEMSNeZU7IezYDehysBz6Hv7TGtmzSaJXg+Xh0csvbh+EOac0OssIctojzx9Aml2MtQ==", "352c172f-1aa5-4f1d-af10-0024c1a2a5c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9d1a84c-f9ec-4517-9624-400f032f5157", "AQAAAAEAACcQAAAAELtkPPTI9Xro1xDpaN0I8FWWTFfXFDcAOjrTM2UU1lr1gBSsMAZQ2tfMfBXrT8WyKQ==", "a14ce9f8-621f-4721-88c6-50a55568621e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb8e6d2e-1d5c-44c2-bbd8-900f3d0614a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f96ab92b-54b5-4de0-b44b-ad52b640c264");

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
    }
}
