using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Services;
using ConceptsMicroservice.Extensions;

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
        public ActionResult<List<Concept>> SearchForConcepts([FromQuery]Dictionary<string, string> query = null)
        {
            return _service.SearchForConcepts(query);
        }

        [HttpGet("{id}", Name = "GetConceptById")]
        public ActionResult<Concept> GetById(int id)
        {
            return _service.GetConceptById(id);
        }

        [HttpPut]
        public ActionResult<Concept> UpdateConcept(Concept c)
        {
            if (!ModelState.IsValid)
                return ValidationProblem(ModelState);

            var viewModel = _service.UpdateConcept(c);
            if (viewModel.IsValid())
                return NoContent();

            ModelState.AddModelError(viewModel.Errors);
            ModelState.AddModelExceptionError(viewModel.Exceptions);
            return ValidationProblem(ModelState);
        }
    }
}
