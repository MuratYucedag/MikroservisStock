namespace MikroservisStock.Discount.Dtos
{
    public class CreateDiscountCouponDto
    {
        public string CouponCode { get; set; }
        public int Rate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
