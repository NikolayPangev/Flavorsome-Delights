using System.ComponentModel.DataAnnotations;

namespace FlavorsomeDelights.WebApp.Models
{
    public class Collections
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; } = null!;
    }
}
