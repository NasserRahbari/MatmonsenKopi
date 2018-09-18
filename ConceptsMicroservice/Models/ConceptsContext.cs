using Microsoft.EntityFrameworkCore;

namespace ConceptsMicroservice.Models
{
    public class ConceptsContext : DbContext
    {
        public ConceptsContext(DbContextOptions<ConceptsContext> options)
            : base(options)
        {
        }

        public DbSet<ConceptItem> ConceptsItems { get; set; }
    }
}
