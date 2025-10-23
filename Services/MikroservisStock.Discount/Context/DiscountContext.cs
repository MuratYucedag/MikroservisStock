using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MikroservisStock.Discount.Entities;
using System.Data;

namespace MikroservisStock.Discount.Context
{
    public class DiscountContext:DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DiscountContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }   
        public DbSet<DiscountCoupon> DiscountCoupons { get; set; }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}