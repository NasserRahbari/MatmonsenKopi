using System.Collections.Generic;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Repositories;

namespace ConceptsMicroservice.Services
{
    public class MetadataService : IMetadataService
    {
        private readonly IMetadataRepository _metadataRepository;

        public MetadataService(IMetadataRepository metadataRepository)
        {
            _metadataRepository = metadataRepository;
        }

        public List<Metadata> GetMetadataItems()
        {
            return _metadataRepository.GetAll();
        }

        public List<Metadata> SearchForMetadataInCategory(string category, string term)
        {
            return _metadataRepository.SearchForMetadataInCategory(category, term);
        }
    }
}
