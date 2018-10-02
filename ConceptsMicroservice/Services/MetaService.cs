using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
