#pragma warning disable

namespace Discount.Api.Entities
{
    public class Coupon
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}
