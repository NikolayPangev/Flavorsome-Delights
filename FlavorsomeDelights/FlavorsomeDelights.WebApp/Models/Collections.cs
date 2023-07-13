using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace FlavorsomeDelights.WebApp.Models
{
    public class Collection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CollectionId { get; set; }

        [Required]
        public string Type { get; set; } = null!;
    }
    public class CollectionContext : DbContext
    {
        public DbSet<Collection> Collections { get; set; }
    }
}

