using Microsoft.EntityFrameworkCore;

namespace ConceptsMicroservice.Models
{
    public class ConceptsContext : DbContext
    {
        public ConceptsContext(DbContextOptions<ConceptsContext> options)
        : base(options)
        { }

    public DbSet<ConceptItem> Concepts { get; set; }
        public DbSet<Metadata> Metadata { get; set; }
    }
}
