using System.Collections.Generic;
using AutoMapper;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Repositories;

namespace ConceptsMicroservice.Services
{
    public class MetadataService : IMetadataService
    {
        private readonly IMetadataRepository _metadataRepository;
        private readonly IMapper _mapper;
        public MetadataService(IMetadataRepository metadataRepository, IMapper mapper)
        {
            _metadataRepository = metadataRepository;
            _mapper = mapper;
        }

        public List<MetaData> GetMetadataItems()
        {
            return _mapper.Map<List<MetaData>>(_metadataRepository.GetAll());
        }

        public List<MetaData> SearchForMetadataInCategory(string key, string value)
        {
            return _mapper.Map<List<MetaData>>(_metadataRepository.SearchForMetadataByMetaKeyAndValue(key, value));
        }
    }
}
