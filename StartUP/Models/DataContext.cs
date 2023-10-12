
using Microsoft.EntityFrameworkCore;

namespace StartUP.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Menu> Menus { get; set; }
    }
}