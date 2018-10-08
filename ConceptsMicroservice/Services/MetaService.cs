using System.Collections.Generic;
using AutoMapper;
using ConceptsMicroservice.Models.DTO;
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

        public List<MetaDataDTO> GetMetadataItems()
        {
            return _mapper.Map<List<MetaDataDTO>>(_metadataRepository.GetAll());
        }

        public List<MetaDataDTO> SearchForMetadataInCategory(string key, string value)
        {
            return _mapper.Map<List<MetaDataDTO>>(_metadataRepository.SearchForMetadataByMetaKeyAndValue(key, value));
        }
    }
}
