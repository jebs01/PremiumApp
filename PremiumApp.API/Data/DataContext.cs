using Microsoft.EntityFrameworkCore;
using PremiumApp.API.Models;
namespace PremiumApp.API.Data
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions<DataContext>  options) : base (options) {}

        public DbSet<Value> Values { get; set; }
    }
}