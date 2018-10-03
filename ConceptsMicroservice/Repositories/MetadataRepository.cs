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

        public List<Metadata> SearchForMetadataInCategory(string categoryName, string term)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Name == categoryName);
            if (category == null)
                return new List<Metadata>();

            return _context.Metadata
                .Where(x => x.CategoryId == category.Id && x.Code.Contains(term))
                .ToList();
        }
    }
}
