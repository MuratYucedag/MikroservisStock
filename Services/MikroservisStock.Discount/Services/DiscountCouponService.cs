using Dapper;
using MikroservisStock.Discount.Context;
using MikroservisStock.Discount.Dtos;

namespace MikroservisStock.Discount.Services
{
    public class DiscountCouponService : IDiscountCouponService
    {
        private readonly DiscountContext _context;
        public DiscountCouponService(DiscountContext context)
        {
            _context = context;
        }
        public async Task CreateDiscountCouponAsync(CreateDiscountCouponDto createDiscountCouponDto)
        {
            string query = "insert into DiscountCoupons (CouponCode,Rate,EndDate,IsActive) values (@couponCode,@rate,@endDate,@isActive)";
            var parameters = new DynamicParameters();
            parameters.Add("@couponCode", createDiscountCouponDto.CouponCode);
            parameters.Add("@rate", createDiscountCouponDto.Rate);
            parameters.Add("@endDate", createDiscountCouponDto.EndDate);
            parameters.Add("@isActive", createDiscountCouponDto.IsActive);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }
        public async Task DeleteDiscountCouponAsync(int id)
        {
            string query = "Delete From DiscountCoupons Where DiscountCouponId=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }
        public async Task<GetDiscountCouponByIdDto> GetDiscountCouponByIdAsync(int id)
        {
            string query = "Select * From DiscountCoupons Where DiscountCouponId=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            var connection = _context.CreateConnection();
            var values = await connection.QueryFirstOrDefaultAsync<GetDiscountCouponByIdDto>(query, parameters);
            return values;
        }

        public async Task<List<ResultDiscountCouponDto>> GetResultDiscountCouponAsync()
        {
            string query = "Select * From DiscountCoupon";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultDiscountCouponDto>(query);
            return values.ToList();
        }

        public async Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateDiscountCouponDto)
        {
            string query = "update DiscountCoupons Set CouponCode=@couponCode,Rate=@rate,EndDate=@endDate,IsActive=@isActive where DiscountCouponId=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@couponCode", updateDiscountCouponDto.CouponCode);
            parameters.Add("@rate", updateDiscountCouponDto.Rate);
            parameters.Add("@endDate", updateDiscountCouponDto.EndDate);
            parameters.Add("@isActive", updateDiscountCouponDto.IsActive);
            parameters.Add("@id", updateDiscountCouponDto.DiscountCouponId);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }
    }
}
