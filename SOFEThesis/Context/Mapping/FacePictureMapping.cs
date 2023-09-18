using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SOFEThesis.Domain;

namespace SOFEThesis.Context.Mapping
{
    public class FacePictureMapping : IEntityTypeConfiguration<FacePicture>
    {
        public void Configure(EntityTypeBuilder<FacePicture> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.Source).IsRequired();
        }
    }
}
