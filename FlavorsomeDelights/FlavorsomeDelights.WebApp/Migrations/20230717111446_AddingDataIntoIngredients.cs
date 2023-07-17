using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;

#nullable disable

namespace FlavorsomeDelights.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingDataIntoIngredients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
            @"INSERT INTO Ingredients(Name, IsAllergenic)
            VALUES
            ('Strawberry', 1),
            ('Milk', 1),
            ('Blueberry', 0)"
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
