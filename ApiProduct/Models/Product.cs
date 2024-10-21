using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProduct.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Informe a descrição do produto")]
        [StringLength(100)]
        public required string Description { get; set; }

        [Required(ErrorMessage = "Informe o preço para o produto")]
        [Column(TypeName = "decimal(18,2)")]
        public required decimal Price { get; set; }

    }
}   
