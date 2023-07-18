using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavorsomeDelights.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class DeclaringUniqueAttributes : Migration
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
                name: "IX_Recipes_RecipeId",
                table: "Recipes",
                column: "RecipeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_IngredientId",
                table: "Ingredients",
                column: "IngredientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_FavoriteId",
                table: "Favorites",
                column: "FavoriteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Collections_CollectionId",
                table: "Collections",
                column: "CollectionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId",
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
                name: "IX_Recipes_RecipeId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_FavoriteId",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Collections_CollectionId",
                table: "Collections");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_IngredientId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories");


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
