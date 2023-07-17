using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;

#nullable disable

namespace FlavorsomeDelights.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingMoreValuesIntoIngredients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql(
            @"INSERT INTO Ingredients(Name, IsAllergenic)
            VALUES
            ('Strawberry', 0),
			('Blueberries', 0),
            ('Milk', 1),
            ('Blueberry', 0),
			('Eggs', 1),
			('Wheat', 1),
			('Soy', 1),
			('Peanuts', 1),
			('Shellfish', 1),
			('Gluten', 1),
			('Sesame', 1),
			('Mustard', 1),
			('Sulfites', 1),
			('Apples', 0),
			('Oranges', 0),
			('Bananas', 0),
			('Tomatoes', 0),
			('Potatoes', 0),
			('Rice', 0),
			('Chicken', 0),
			('Beef', 0),
			('Pork', 0),
			('Garlic', 0),
			('Onion', 0),
			('Olive oil', 0),
			('Salt', 0),
			('Sugar', 0),
			('Cinnamon', 0),
			('Yogurt', 1),
			('Cheese', 1),
			('Bread', 1),
			('Oats', 0),
			('Honey', 0),
			('Avocado', 0),
			('Green Beans', 0),
			('Corn', 0),
			('Lettuce', 0),
			('Shrimp', 1),
			('Salmon', 0),
			('Tofu', 0),
			('Quinoa', 0)"
			);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "DELETE FROM Ingredients;"
            );
        }
    }
}
