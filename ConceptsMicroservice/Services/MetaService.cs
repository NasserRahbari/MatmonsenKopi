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

        public List<MetaData> GetMetadataItems()
        {
            return _metadataRepository.GetAll();
        }

        public List<MetaData> SearchForMetadataInCategory(string key, string value)
        {
            return _metadataRepository.SearchForMetadataByMetaKeyAndValue(key, value);
        }
    }
}
