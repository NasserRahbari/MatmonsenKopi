using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Services;


namespace ConceptsMicroservice.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ConceptController : ControllerBase
    {
        private readonly IConceptService _service;

        public ConceptController(IConceptService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public ActionResult<List<Concept>> SearchForConcepts([FromQuery]ConceptSearchFields query = null)
        {
            return _service.SearchForConcepts(query);
        }

        [HttpGet("{id}", Name = "GetConceptById")]
        public ActionResult<Concept> GetById(int id)
        {
            return _service.GetConceptById(id);
        }
    }
}
