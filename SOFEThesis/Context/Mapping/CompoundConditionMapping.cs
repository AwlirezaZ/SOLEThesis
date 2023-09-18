﻿using Microsoft.EntityFrameworkCore;
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
            builder.HasOne(a => a.Picture);
            builder.HasOne(a => a.FirstFacePicture);
            builder.HasOne(a => a.SecondFacePicture);


        }
    }
}
