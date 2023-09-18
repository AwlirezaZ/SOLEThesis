using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SOFEThesis.Domain;

namespace SOFEThesis.Context.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Age).IsRequired();
            builder.Property(a => a.Degree).IsRequired();
            builder.Property(a => a.University).IsRequired();
            builder.Property(a => a.Gender).IsRequired();
            builder.Property(a => a.FieldOfStudy).IsRequired();
        }
    }
}
