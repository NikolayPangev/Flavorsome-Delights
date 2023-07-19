using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlavorsomeDelights.WebApp.Entities
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = null!;
        [Required]
        public string HowToPrepare { get; set; } = null!;
        [Required]
        [MaxLength(15)]
        public string Complexity { get; set; } = null!;
        [Required]
        [MaxLength(20)]
        public int Serves { get; set; }
        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public List<RecipeIngredient> Ingredients { get; set; }
    }
}
