using FlavorsomeDelights.WebApp.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavorsomeDelights.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingDataIntoIngredientsAndCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
            @"INSERT INTO Ingredients(Name, IsAllergenic)
            VALUES
            ('Strawberries', 0),
            ('Milk', 1),
            ('Blueberries', 0),
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
			('Onions', 0),
			('Olive oil', 0),
			('Salt', 0),
			('Sugar', 0),
			('Cinnamon', 0),
			('Yogurt', 1),
			('Cheese', 1),
			('Bread', 1),
			('Oats', 0),
			('Honey', 0),
			('Avocados', 0),
			('Green Beans', 0),
			('Corn', 0),
			('Lettuce', 0),
			('Shrimps', 1),
			('Salmon', 0),
			('Tofu', 0),
			('Quinoa', 0)"
            );

            migrationBuilder.Sql
            (@"INSERT INTO Categories(Type, CategoryImageUrl)
            VALUES
            ('Breakfast', 'https://images.pexels.com/photos/2280545/pexels-photo-2280545.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			('Lunch', 'https://images.pexels.com/photos/361184/asparagus-steak-veal-steak-veal-361184.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'), 
			('Dinner', 'https://images.pexels.com/photos/262959/pexels-photo-262959.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			('Dessert', 'https://images.pexels.com/photos/3026804/pexels-photo-3026804.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			('Appetizer', 'https://images.pexels.com/photos/16975174/pexels-photo-16975174/free-photo-of-dumplings-with-sauce.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			('Salad', 'https://images.pexels.com/photos/2097090/pexels-photo-2097090.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			('Main Dish', 'https://images.pexels.com/photos/2641886/pexels-photo-2641886.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			('Soup', 'https://images.pexels.com/photos/539451/pexels-photo-539451.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			('Vegetarian', 'https://images.pexels.com/photos/2456434/pexels-photo-2456434.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			('Vegan', 'https://images.pexels.com/photos/1351238/pexels-photo-1351238.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1')"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql(
			"DELETE FROM Ingredients"
			);

            migrationBuilder.Sql(
            "DELETE FROM Categories"
            );
        }
    }
}
