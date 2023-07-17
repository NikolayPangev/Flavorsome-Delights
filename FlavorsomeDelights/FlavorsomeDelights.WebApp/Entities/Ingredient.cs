using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorsomeDelights.WebApp.Models
{
    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IngredientId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
      
        [Required]
        public bool IsAllergenic { get; set; }
    }
}
