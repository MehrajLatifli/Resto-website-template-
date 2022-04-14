using Microsoft.EntityFrameworkCore;
using Resto.Entities;

namespace Resto.Data
{
    public class TeamDbContext : DbContext
    {
        public TeamDbContext(DbContextOptions<TeamDbContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }

    }
}
