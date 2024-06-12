using GeekShopping.CouponAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CouponAPI.Model
{
    [Table("coupon")]
    public class Coupon : BaseEntity
    {

        [Column("coupon_code")]
        [Required]
        [StringLength(150)]
        public string CouponCode { get; set; }

        [Column("discount_amout")]
        [Required]
        public decimal DiscountAmout { get; set; }

    }
}
