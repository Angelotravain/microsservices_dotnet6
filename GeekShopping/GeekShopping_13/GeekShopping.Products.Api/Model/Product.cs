using GeekShopping.Products.Api.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.Products.Api.Model
{
    [Table("produto")]
    public class Product : BaseEntity
    {
        [Column("nome")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("preco")]
        [Required]
        [Range(1,10000)]
        public decimal Price { get; set; }

        [Column("escricao")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("nome_categoria")]
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        [Column("img_url")]
        [StringLength(400)]
        public string ImageURL {  get; set; }
    }
}
