using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SOFEThesis.Domain.Conditions;

namespace SOFEThesis.Context.Mapping
{
    public class FaceConditionMapping : IEntityTypeConfiguration<FaceCondition>
    {
        public void Configure(EntityTypeBuilder<FaceCondition> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Order);
            builder.HasOne(a => a.FacePicture);

        }
    }
}
