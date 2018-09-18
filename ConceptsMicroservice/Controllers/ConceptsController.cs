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
        public ActionResult<List<ConceptItem>> SearchForConcepts([FromQuery]ConceptSearchFields searchField = null)
        {
            return _service.SearchForConcepts(searchField);
        }
    }
}
