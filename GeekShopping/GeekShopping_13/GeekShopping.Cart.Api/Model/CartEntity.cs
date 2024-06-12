using System.Collections.Generic;

namespace GeekShopping.CartAPI.Model
{
    public class CartEntity
    {
        public CartHeader CartHeader { get; set; }
        public IEnumerable<CartDetail> CartDetails { get; set; }
    }
}
