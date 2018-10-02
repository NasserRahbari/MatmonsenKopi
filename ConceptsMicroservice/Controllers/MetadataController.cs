using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Services;

namespace ConceptsMicroservice.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MetadataController : ControllerBase
    {
        private readonly IMetadataService _service;
        public MetadataController(IMetadataService service)
        {
            _service = service;
        }


        [HttpGet]
        public ActionResult<List<Metadata>> GetMetadata()
        {
            var result = _service.GetMetadataItems();
            return result;
        }
    }
}
