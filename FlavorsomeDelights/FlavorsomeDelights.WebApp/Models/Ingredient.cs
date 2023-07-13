﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace FlavorsomeDelights.WebApp.Models
{
    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IngredientId { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool IsAllergic { get; set; }
    }
}
