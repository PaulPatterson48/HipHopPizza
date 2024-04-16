using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HipHopPizzaWings.Migrations
{
    /// <inheritdoc />
    public partial class ThirdCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cashiers",
                columns: new[] { "Id", "Name", "email", "uid" },
                values: new object[,]
                {
                    { 1, "Alice Hyatt", "aliceHyatt@google.com", "AH12345MD" },
                    { 2, "Florence Jean Casteberry", "flo@google.com", "FJC12345MD" },
                    { 3, "Mel Sharples", "mel@google.com", "MD12345MD" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cashiers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cashiers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cashiers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
