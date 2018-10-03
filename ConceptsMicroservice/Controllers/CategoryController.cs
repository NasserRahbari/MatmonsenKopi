using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Services;

namespace ConceptsMicroservice.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Category>> GetCategories()
        {
            var result = _service.GetCategories();
            return result;
        }
    }
}
