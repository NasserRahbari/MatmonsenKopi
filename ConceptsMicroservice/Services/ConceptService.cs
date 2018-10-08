using System.Collections.Generic;
using AutoMapper;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Repositories;

namespace ConceptsMicroservice.Services
{
    public class ConceptService : IConceptService
    {
        private readonly IConceptRepository _conceptRepository;
        private readonly IMapper _mapper;

        public ConceptService(IConceptRepository repo, IMapper mapper)
        {
            _conceptRepository = repo;
            _mapper = mapper;
        }

        public List<ConceptDTO> SearchForConcepts(Dictionary<string, string> searchFields)
        {
            return _mapper.Map<List<ConceptDTO>>(_conceptRepository.SearchForConcepts(searchFields));
        }

        public ConceptDTO GetConceptById(int id)
        {
            return _mapper.Map<ConceptDTO>(_conceptRepository.GetById(id));
        }
    }
}
