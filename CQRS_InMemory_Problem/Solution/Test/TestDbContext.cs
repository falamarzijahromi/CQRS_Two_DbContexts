using Microsoft.EntityFrameworkCore;
using Read;
using Write;

namespace Test
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WriteDbContext).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReadDbContext).Assembly);
        }
    }
}
