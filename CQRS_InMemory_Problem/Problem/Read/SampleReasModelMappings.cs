using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Read
{
    public class SampleReasModelMappings : IEntityTypeConfiguration<SampleReadModel>
    {
        public void Configure(EntityTypeBuilder<SampleReadModel> builder)
        {
            builder.ToTable("SampleWriteModels");

            builder.HasKey(srm => srm.Id);

            builder.Property(srm => srm.Name);
        }
    }
}
