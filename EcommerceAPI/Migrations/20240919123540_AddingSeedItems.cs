using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeedItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 8, 35, 40, 606, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedDate", "Description", "Name", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "A t-shirt with the logo of a popular band.", "Band T-Shirt", 20m, null },
                    { 3, 4, new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "A kitchen tool used to emulsify food.", "Blender", 35m, null },
                    { 4, 5, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "A tube of lipstick in a bright red color.", "Lipstick", 15m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 17, 7, 57, 589, DateTimeKind.Local).AddTicks(8655));
        }
    }
}
