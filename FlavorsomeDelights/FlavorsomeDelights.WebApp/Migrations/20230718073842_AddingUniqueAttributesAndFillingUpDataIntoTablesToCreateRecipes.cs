using FlavorsomeDelights.WebApp.Models;
using Humanizer;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Hosting;
using static Azure.Core.HttpHeader;
using static System.Net.WebRequestMethods;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System;

#nullable disable

namespace FlavorsomeDelights.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingUniqueAttributesAndFillingUpDataIntoTablesToCreateRecipes : Migration
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
                name: "IX_RecipesIngredients_RecipeIngredientId",
                table: "RecipesIngredients",
                column: "RecipeIngredientId",
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
                Set Identity_Insert Categories Off

                Set Identity_Insert Ingredients On
                Ingredients(IngredientId, Name, IsAllergenic)
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
                Set Identity_Insert Ingredients Off

                Set Identity_Insert Recipes On

                INSERT INTO Recipes(RecipeId, Title, HowToPrepare, Complexity, Serves, ImageUrl, CategoryId)
                VALUES
                (1, 'Chorizo & mozzarella gnocchi bake', 'Heat the oil in a medium pan over a medium heat. Fry the onion and garlic for 8-10 mins until soft. 

                Add the chorizo and fry for 5 mins more.Tip in the tomatoes and sugar, and season.Bring to a simmer, then add the gnocchi and cook for 8 mins,
                stirring often, until soft.Heat the grill to high.Stir ¾ of the mozzarella and most of the basil through the gnocchi.Divide the mixture between

                six ovenproof ramekins, or put in one baking dish.Top with the remaining mozzarella, then grill for 3 mins, or until the cheese is melted and golden.
                Season, scatter over the remaining basil and serve with green salad.', 'Beginner', 7, 'https://images.pexels.com/photos/4078190/pexels-photo-4078190.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 

                18), 
	            (2, 'Easy chocolate fudge cake', 'Heat the oven to 180C/160C fan/gas 4. Oil and line the base of two 18cm sandwich tins. Sieve the flour, cocoa powder and 

                bicarbonate of soda into a bowl. Add the caster sugar and mix well.Make a well in the centre and add the golden syrup, eggs, sunflower oil and milk. Beat well

                with an electric whisk until smooth.Pour the mixture into the two tins and bake for 25 - 30 mins until risen and firm to the touch.Remove from oven, leave to cool

                for 10 mins before turning out onto a cooling rack.To make the icing, beat the unsalted butter in a bowl until soft.Gradually sieve and beat in the icing sugar

                and cocoa powder, then add enough of the milk to make the icing fluffy and spreadable.Sandwich the two cakes together with the butter icing and cover the sides and

                the top of the cake with more icing.', 'Beginner', 8, 'https://images.pexels.com/photos/8732739/pexels-photo-8732739.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 

                4), 
	            (3, 'Vegan lemon cake', 'Heat oven to 200C/180C fan/gas 6. Oil a 1lb loaf tin and line it with baking parchment. Mix the flour, sugar, baking powder and lemon zest in a 

                bowl.Add the oil, lemon juice and 170ml cold water, then mix until smooth. Pour the mixture into the tin. Bake for 30 mins or until a skewer comes out clean.Cool in the

                tin for 10 mins, then remove and transfer the cake to a wire rack to cool fully.For the icing, sieve the icing sugar into a bowl.Mix in just enough lemon juice to make

                an icing thick enough to pour over the loaf(if you make the icing too thin, it will just run off the cake).', 'Advanced', 12, 'https://images.pexels.com/photos/6631965/pexels-photo-6631965.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 
                        4), 
	            (4, 'Tomato & feta pesto bites', 'Roll out the pastry on a surface lightly dusted with the Parmesan to about the thickness of a ten-pence piece. Stamp out 12 rounds using a 

                6cm plain cutter and line a shallow 12 - hole bun tin. Chill for 20 minutes.Preheat the oven to fan 180C / conventional 200C / gas 6.Prick each pastry base with a fork and bake

                for 15 - 20 minutes until golden.Remove from the tin and leave to cool on a wire rack.Meanwhile, tear the leaves from the parsley stalks and put all but 12 of the small sprigs 
	            in a food processor with the pine nuts, then whizz until coarsely chopped.Then add the feta, garlic and oil and whizz to make a thick paste.Keep the reserved sprigs in a bowl of

                water in the fridge.The pastry bases will keep in a tin for up to 2 days and the pesto will keep in the fridge overnight.To serve, dollop a spoonful of the feta pesto onto the

                tarts and top each one with two cherry tomato halves.Garnish with the reserved parsley sprigs.Arrange on a platter and hand round with a bowl of black olives and sparkling mint
                & lemon juleps.', 'Beginner', 12, 'https://images.pexels.com/photos/792028/pexels-photo-792028.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1', 5);

                Set Identity_Insert Recipes off

                Set Identity_Insert RecipesIngredients On
                INSERT INTO RecipesIngredients(RecipeId, IngredientId, Quantity)
                VALUES
                (1, 23, 0),
                (1, 24, 0),
                (1, 2, 0),
                (2, 16, 0),
                (2, 22, 0),
                (3, 10, 0),
                (4, 16, 0),
                (4, 25, 0);
                Set Identity_Insert RecipesIngredients Off"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RecipesIngredients_RecipeIngredientId",
                table: "RecipesIngredients");

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

            migrationBuilder.Sql(
                @"DELETE FROM RecipesIngredients;
                  DELETE FROM Recipes;
                  DELETE FROM Ingredients;
                  DELETE FROM Favorites;
                  DELETE FROM Collections;
                  DELETE FROM Categories;"
            );
        }
    }
}
