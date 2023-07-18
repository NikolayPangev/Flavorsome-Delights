using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlavorsomeDelights.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingValuesToCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
               @"Set Identity_Insert Categories On
                INSERT INTO Categories(CategoryId, Type, CategoryImageUrl)
                VALUES
                (1, 'Breakfast', 'https://images.pexels.com/photos/2280545/pexels-photo-2280545.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			    (2, 'Lunch', 'https://images.pexels.com/photos/361184/asparagus-steak-veal-steak-veal-361184.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'), 
			    (3, 'Dinner', 'https://images.pexels.com/photos/262959/pexels-photo-262959.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			    (4, 'Dessert', 'https://images.pexels.com/photos/3026804/pexels-photo-3026804.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			    (5, 'Appetizer', 'https://images.pexels.com/photos/16975174/pexels-photo-16975174/free-photo-of-dumplings-with-sauce.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			    (6, 'Salad', 'https://images.pexels.com/photos/2097090/pexels-photo-2097090.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			    (7, 'Main Dish', 'https://images.pexels.com/photos/2641886/pexels-photo-2641886.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			    (8, 'Soup', 'https://images.pexels.com/photos/539451/pexels-photo-539451.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			    (9, 'Vegetarian', 'https://images.pexels.com/photos/2456434/pexels-photo-2456434.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'),
			    (10, 'Vegan', 'https://images.pexels.com/photos/1351238/pexels-photo-1351238.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1')
                Set Identity_Insert Categories Off"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "DELETE FROM Categories;"
            ); 
        }
    }
}
