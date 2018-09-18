using System.Collections.Generic;
using System.Linq;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Utilities;

namespace ConceptsMicroservice.Repositories
{
    public class ConceptRepositoryFromFileDatabase : IConceptRepository
    {
        private readonly IFileDB _fileDB;

        public ConceptRepositoryFromFileDatabase(IFileDB db)
        {
            _fileDB = db;
        }

        public List<ConceptItem> SearchForConcepts(ConceptSearchFields searchFields)
        {
            var concepts = _fileDB.ReadFromFile();
            if (searchFields == null)
                return concepts;

            if (!string.IsNullOrWhiteSpace(searchFields.Title))
                concepts = concepts
                    .Where(i => i.Title != null)
                    .Where(i => i.Title.ToLower().Contains(searchFields.Title.ToLower()))
                    .ToList();

            if (!string.IsNullOrWhiteSpace(searchFields.Language))
                concepts = concepts
                    .Where(i => i.Language != null)
                    .Where(i => i.Language.ToLower().Contains(searchFields.Language.ToLower()))
                    .ToList();

            return concepts;
        }
    }
}
