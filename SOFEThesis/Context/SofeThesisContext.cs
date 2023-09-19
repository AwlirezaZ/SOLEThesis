using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SOFEThesis.Domain;
using SOFEThesis.Domain.Conditions;

namespace SOFEThesis.Context
{
    public class SofeThesisContext : DbContext
    {
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<FacePicture> FacePictures { get; set; }
        public DbSet<SelfCondition> SelfConditions { get; set; }
        public DbSet<FaceCondition> FaceConditions { get; set; }
        public DbSet<CompoundCondition> CompoundConditions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SofeThesisContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public SofeThesisContext(DbContextOptions<SofeThesisContext> options) : base(options)
        {
            //this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        }

    }

}
