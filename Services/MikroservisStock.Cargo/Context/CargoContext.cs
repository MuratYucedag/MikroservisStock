using Microsoft.EntityFrameworkCore;
using MikroservisStock.Cargo.Entites;

namespace MikroservisStock.Cargo.Context
{
    public class CargoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1441;initial catalog=MikroservisCargoDb;User=sa;Password=123456aA*");
        }
        public DbSet<CargoDetail> CargoDetails { get; set; }
        public DbSet<CargoProcess> CargoProcesses { get; set; }
    }
}
