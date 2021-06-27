using Microsoft.EntityFrameworkCore;

namespace Read
{
    public class ReadDbContext : DbContext
    {
        public DbSet<SampleReadModel> SampleReadModels { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SampleReasModelMappings());
        }
    }
}
