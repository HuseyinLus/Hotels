using Microsoft.EntityFrameworkCore.SqlServer;
using Entities;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer
{
    public class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("SERVER=DESKTOP-TBKO1DI\\SQLEXPRESS; Database=TestDb; uid=Huseyin;pwd=1234");
        }
        public DbSet<Hotels> hotels { get; set; }
    }
}
