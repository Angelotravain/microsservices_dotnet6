﻿namespace GeekShopping.OrderAPI.Messages
{
    public class CheckoutHeaderVO
    {
        public string UserId { get; set; }
        public string CouponCode { get; set; }
        public double PurchaseAmount { get; set; }
        public decimal DiscountTotal { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Time { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public string MouthYear { get; set; }
        public int? CartTotalItens { get; set; }
        public IEnumerable<CartDetailVO>? CartDetails { get; set; }
    }
}