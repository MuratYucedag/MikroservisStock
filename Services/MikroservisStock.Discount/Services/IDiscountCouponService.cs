using MikroservisStock.Discount.Dtos;

namespace MikroservisStock.Discount.Services
{
    public interface IDiscountCouponService
    {
        Task<List<ResultDiscountCouponDto>> GetResultDiscountCouponAsync();
        Task CreateDiscountCouponAsync(CreateDiscountCouponDto createDiscountCouponDto);
        Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateDiscountCouponDto);
        Task DeleteDiscountCouponAsync(int id);
        Task<GetDiscountCouponByIdDto> GetDiscountCouponByIdAsync(int id);
    }
}
