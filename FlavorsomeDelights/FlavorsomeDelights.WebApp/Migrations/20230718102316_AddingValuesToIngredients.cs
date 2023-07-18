using FlavorsomeDelights.WebApp.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;

#nullable disable

namespace FlavorsomeDelights.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingValuesToIngredients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql(
			@"Set Identity_Insert Ingredients On
				INSERT INTO Ingredients(IngredientId, Name, IsAllergenic)
					VALUES
					(1, 'Strawberries', 0),
					(2, 'Milk', 1),
					(3, 'Blueberries', 0),
					(4, 'Eggs', 1),
					(5, 'Wheat', 1),
					(6, 'Soy', 1),
					(7, 'Peanuts', 1),
					(8, 'Shellfish', 1),
					(9, 'Gluten', 1),
					(10, 'Sesame', 1),
					(11, 'Mustard', 1),
					(12, 'Sulfites', 1),
					(13, 'Apples', 0),
					(14, 'Oranges', 0),
					(15, 'Bananas', 0),
					(16, 'Tomatoes', 0),
					(17, 'Potatoes', 0),
					(18, 'Rice', 0),
					(19, 'Chicken', 0),
					(20, 'Beef', 0),
					(21, 'Pork', 0),
					(22, 'Garlic', 0),
					(23, 'Onions', 0),
					(24, 'Olive oil', 0),
					(25, 'Salt', 0),
					(26, 'Sugar', 0),
					(27, 'Cinnamon', 0),
					(28, 'Yogurt', 1),
					(29, 'Cheese', 1),
					(30, 'Bread', 1),
					(31, 'Oats', 0),
					(32, 'Honey', 0),
					(33, 'Avocados', 0),
					(34, 'Green Beans', 0),
					(35, 'Corn', 0),
					(36, 'Lettuce', 0),
					(37, 'Shrimps', 1),
					(38, 'Salmon', 0),
					(39, 'Tofu', 0),
					(40, 'Quinoa', 0)
				Set Identity_Insert Ingredients Off"
				);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql(
				@"DELETE FROM Ingredients;"
			);
        }
    }
}
