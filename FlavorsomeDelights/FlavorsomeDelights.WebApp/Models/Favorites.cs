using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorsomeDelights.WebApp.Models
{
    public class Favorites
    {
        [Key]
        public int Id { get; set; }
        public int RecipeId { get; set; }
        [ForeignKey(nameof(RecipeId))]
        public virtual Recipe Recipe { get; set; }
        public int CollectionsId { get; set; }
        [ForeignKey(nameof(CollectionsId))]
        public virtual Collections Collections { get; set; }
    }
}
