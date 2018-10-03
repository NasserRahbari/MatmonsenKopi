using ConceptsMicroservice.DefaultDbValues;
using Microsoft.EntityFrameworkCore;

namespace ConceptsMicroservice.Models
{
    public class ConceptsContext : DbContext
    {
        public ConceptsContext(DbContextOptions<ConceptsContext> options): base(options){ }

        public DbSet<Concept> Concepts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ConceptMeta> ConceptMetas { get; set; }
        public DbSet<Metadata> Metadata { get; set; }
        public DbSet<PublishingStatus> PublishingStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Map join tabled
            modelBuilder.Entity<ConceptMeta>()
                .HasKey(bc => new { bc.ConceptId, bc.MetadataId });

            modelBuilder.Entity<ConceptMeta>()
                .HasOne(bc => bc.Concept)
                .WithMany(b => b.Metadata)
                .HasForeignKey(bc => bc.ConceptId);

            modelBuilder.Entity<ConceptMeta>()
                .HasOne(bc => bc.Metadata)
                .WithMany(c => c.Concepts)
                .HasForeignKey(bc => bc.MetadataId);
            #endregion

            #region Seed database with initial values
            foreach (var category in Seed.SeedCategories())
            {
                modelBuilder.Entity<Category>().HasData(category);
            }
            foreach (var meta in Seed.SeedMeta())
            {
                modelBuilder.Entity<Metadata>().HasData(meta);
            }

            foreach (var status in Seed.SeedPublishedStatus())
            {
                modelBuilder.Entity<PublishingStatus>().HasData(status);
            }
            foreach (var status in Seed.SeedConcept())
            {
                modelBuilder.Entity<Concept>().HasData(status);
            }

            foreach (var status in Seed.SeedConceptMetas())
            {
                modelBuilder.Entity<ConceptMeta>().HasData(status);
            }
            #endregion

        }
    }
}
