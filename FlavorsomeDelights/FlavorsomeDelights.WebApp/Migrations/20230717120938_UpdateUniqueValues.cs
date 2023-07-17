using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavorsomeDelights.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUniqueValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_Name",
                table: "Ingredients",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Collections_Type",
                table: "Collections",
                column: "Type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Type",
                table: "Categories",
                column: "Type",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ingredients_Name",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Collections_Type",
                table: "Collections");

            migrationBuilder.DropIndex(
                name: "IX_Categories_Type",
                table: "Categories");
        }
    }
}
