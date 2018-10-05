using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Models.DTO;
using ConceptsMicroservice.Services;


namespace ConceptsMicroservice.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ConceptController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IConceptService _service;

        public ConceptController(IConceptService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult<List<ConceptDTO>> SearchForConcepts([FromQuery]ConceptSearchFields query = null)
        {
            return _mapper.Map<List<Concept>, List<ConceptDTO>>(_service.SearchForConcepts(query));
        }

        [HttpGet("{id}", Name = "GetConceptById")]
        public ActionResult<Concept> GetById(int id)
        {

            //var concept = _mapper.Map<Concept, ConceptDTO>(_service.GetConceptById(id));
            return _service.GetConceptById(id);
        }

        /*
         *
         * var c = _service.GetConceptById(id);
            var metas = new List<MetadataDTO>();
            foreach (var m in c.Metadata)
            {
                metas.Add(_mapper.Map<Metadata, MetadataDTO>(m.Metadata));
            }

            var concept = _mapper.Map<Concept, ConceptDTO>(c);
            concept.Metadata = metas;
            return concept;
         */
    }
}
