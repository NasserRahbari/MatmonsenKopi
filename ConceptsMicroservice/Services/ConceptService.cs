using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Web;
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

        public List<Concept> SearchForConcepts(ConceptSearchFields searchFields)
        {
            return _conceptRepository.SearchForConcepts(searchFields);
        }
    }
}
