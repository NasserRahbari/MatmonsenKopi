using System.Collections.Generic;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Repositories;

namespace ConceptsMicroservice.Services
{
    public class ConceptService : IConceptService
    {
        private readonly IConceptRepository _conceptRepository;
        private readonly IMetadataRepository _metadataRepository;

        public ConceptService(IConceptRepository concept, IMetadataRepository meta)
        {
            _conceptRepository = concept;
            _metadataRepository = meta;
        }

        public List<Concept> SearchForConcepts(Dictionary<string, string> searchFields)
        {
            return _conceptRepository.SearchForConcepts(searchFields);
        }

        public Concept GetConceptById(int id)
        {
            return _conceptRepository.GetById(id);
        }

        public Concept UpdateConcept(Concept c)
        {
            if (c.Metadata == null)
            {
               // _metadataRepository.DeactivateMetadata(c.MetadataId);
              //  c.MetadataId = -1;
            }

            return _conceptRepository.Update(c);
        }
    }
}
