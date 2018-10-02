using System.Collections.Generic;
using System.Linq;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Repositories
{
    public class MetadataRepository : IMetadataRepository
    {
        private readonly ConceptsContext _context;

        public MetadataRepository(ConceptsContext context)
        {
            _context = context;
        }
        public List<Metadata> GetAll()
        {
            return _context.Metadata.ToList<Metadata>();
        }

        public List<Metadata> SearchForMetadataInCategory(string category, string term)
        {
            return new List<Metadata>();
        }
    }
}
