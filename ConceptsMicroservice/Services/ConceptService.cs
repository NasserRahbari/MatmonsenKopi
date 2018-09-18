using System.Collections.Generic;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Repositories;

namespace ConceptsMicroservice.Services
{
    public class ConceptService : IConceptService
    {
        private readonly IConceptRepository _conceptRepository;

        public ConceptService(IConceptRepository repo)
        {
            _conceptRepository = repo;
        }

        public List<ConceptItem> SearchForConcepts(ConceptSearchFields searchFields)
        {
            return _conceptRepository.SearchForConcepts(searchFields);
        }
    }
}
