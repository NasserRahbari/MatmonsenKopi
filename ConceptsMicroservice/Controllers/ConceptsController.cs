using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using ConceptsMicroservice.Models;
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
        public ActionResult<List<ConceptDTO>> SearchForConcepts([FromQuery]Dictionary<string, string> query = null)
        {
            return _service.SearchForConcepts(query);
        }

        [HttpGet("{id}", Name = "GetConceptById")]
        public ActionResult<ConceptDTO> GetById(int id)
        {
            return _service.GetConceptById(id);
        }
        
    }
}
