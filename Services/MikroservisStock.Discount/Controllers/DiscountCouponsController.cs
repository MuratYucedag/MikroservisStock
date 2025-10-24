using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MikroservisStock.Discount.Dtos;
using MikroservisStock.Discount.Services;

namespace MikroservisStock.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountCouponsController : ControllerBase
    {
        private readonly IDiscountCouponService _discountCouponService;
        public DiscountCouponsController(IDiscountCouponService discountCouponService)
        {
            _discountCouponService = discountCouponService;
        }

        [HttpGet]
        public async Task<IActionResult> DiscountCouponList()
        {
            var values = await _discountCouponService.GetResultDiscountCouponAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupon(CreateDiscountCouponDto createDiscountCouponDto)
        {
            await _discountCouponService.CreateDiscountCouponAsync(createDiscountCouponDto);
            return Ok("Ekleme başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountCouponService.DeleteDiscountCouponAsync(id);
            return Ok("Silme başarılı");
        }

        [HttpGet("GetDiscountCoupon")]
        public async Task<IActionResult> GetDiscountCoupon(int id)
        {
            var value = await _discountCouponService.GetDiscountCouponByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDto updateDiscountCouponDto)
        {
            await _discountCouponService.UpdateDiscountCouponAsync(updateDiscountCouponDto);
            return Ok("Güncelleme başarılı");
        }
    }
}
