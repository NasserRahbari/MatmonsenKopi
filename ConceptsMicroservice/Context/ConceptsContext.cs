using Microsoft.EntityFrameworkCore;

namespace ConceptsMicroservice.Models
{
    public class ConceptsContext : DbContext
    {
        public ConceptsContext(DbContextOptions<ConceptsContext> options): base(options){ }

        public DbSet<MetaData> MetaData { get; set; }
        public DbSet<Concept> Concepts { get; set; }
    }
}
