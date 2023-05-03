using Microsoft.EntityFrameworkCore;
using fanal1.models;

namespace fanal1.Database
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

        public DbSet<Employees> Employees { get; set; }

        public DbSet<Positions> Positions { get; set; }


    }
}
