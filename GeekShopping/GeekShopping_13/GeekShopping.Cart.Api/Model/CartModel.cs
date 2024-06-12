using GeekShopping.CartAPI.Model;

namespace GeekShopping.Cart.Api.Model
{
    public class CartModel
    {
        public CartHeader CartHeader { get; set; }
        public IEnumerable<CartDetail> CartDetails { get; set; }
    }
}
