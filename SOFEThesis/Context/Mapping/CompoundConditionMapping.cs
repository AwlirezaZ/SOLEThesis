using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SOFEThesis.Domain.Conditions;

namespace SOFEThesis.Context.Mapping
{
    public class CompoundConditionMapping : IEntityTypeConfiguration<CompoundCondition>
    {
        public void Configure(EntityTypeBuilder<CompoundCondition> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.Order);
            builder.Property(a => a.PictureId);
            builder.Property(a => a.FirstFacePictureId);
            builder.Property(a => a.SecondFacePictureId);

            builder.HasOne(a => a.Picture).WithOne().HasForeignKey<CompoundCondition>(a => a.PictureId);
            builder.HasOne(a => a.FirstFacePicture).WithOne().HasForeignKey<CompoundCondition>(a => a.FirstFacePictureId);
            builder.HasOne(a => a.SecondFacePicture).WithOne().HasForeignKey<CompoundCondition>(a => a.SecondFacePictureId);


        }
    }
}
