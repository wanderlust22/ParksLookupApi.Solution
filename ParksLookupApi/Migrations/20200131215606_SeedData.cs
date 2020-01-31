using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookupApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Parks",
                newName: "Review");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "City", "Name", "Rating", "Review", "State" },
                values: new object[,]
                {
                    { 1, "Mariposa", "Yosemite", 5, "It's Yosemite, dude. So yeah, it's pretty awesome.", "California" },
                    { 2, "Columbia Falls", "Glacier", 5, "Feels like a John Wayne movie.", "Montana" },
                    { 3, "Moab", "Arches", 4, "How did the Mormons get such a pretty state.", "Utah" },
                    { 4, "Ozark", "Jackson Falls", 2, "It's not too grand, but it's better than the cornfields.", "Illinois" },
                    { 5, "Estes Park", "Rocky Mountain", 5, "So beautiful I had trouble breathing, or maybe that was just the elevation.", "Colorado" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "Review",
                table: "Parks",
                newName: "Description");
        }
    }
}
