using Microsoft.EntityFrameworkCore;

namespace Write
{
    public class WriteDbContext : DbContext
    {
        public DbSet<SampleWriteModel> SampleWriteModels { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SampleWriteModelMappings());
        }
    }
}
