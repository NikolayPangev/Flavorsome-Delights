using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace FlavorsomeDelights.WebApp.Models
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeId { get; set; }

        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string HowToPrepare { get; set; } = null!;
        [Required]
        public string Complexity { get; set; } = null!;
        [Required]
        public string Serves { get; set; } = null!;
        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
