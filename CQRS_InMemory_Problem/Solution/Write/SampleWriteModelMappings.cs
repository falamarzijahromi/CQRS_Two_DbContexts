using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Write
{
    public class SampleWriteModelMappings : IEntityTypeConfiguration<SampleWriteModel>
    {
        public void Configure(EntityTypeBuilder<SampleWriteModel> builder)
        {
            builder.ToTable("SampleWriteModels");

            builder.HasKey(srm => srm.Id);
            builder.Property(srm => srm.Name);
            builder.Property(srm => srm.Code);
        }
    }
}
