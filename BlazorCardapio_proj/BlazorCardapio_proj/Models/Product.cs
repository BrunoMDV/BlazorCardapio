using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCardapio_proj.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!; // seta null como forgiven pq nume e nullable
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
    }
}
