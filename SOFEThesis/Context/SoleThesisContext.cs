using Microsoft.EntityFrameworkCore;
using SOFEThesis.Domain;
using SOFEThesis.Domain.Conditions;

namespace SOFEThesis.Context
{
    public class SoleThesisContext : DbContext
    {
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<FacePicture> FacePictures { get; set; }
        public DbSet<SelfCondition> SelfConditions { get; set; }
        public DbSet<FaceCondition> FaceConditions { get; set; }
        public DbSet<CompoundCondition> CompoundConditions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SoleThesisContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
