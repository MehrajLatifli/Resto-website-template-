using Microsoft.EntityFrameworkCore;
using Resto.Entities;

namespace Resto.Data
{
    public class MenuDbContext : DbContext
    {
        public MenuDbContext(DbContextOptions<MenuDbContext> options) : base(options)
        {

        }

        public DbSet<Menu> Menues { get; set; }

    }
}
