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
        public ActionResult<List<MetaData>> GetMetadata([FromQuery] string key, [FromQuery] string value)
        {
                // Spør etter feks ?key=language&value=nn
                // Vil da finne alle metadata som er av category language og contains "ny"
                // TODO add contains
                return _service.SearchForMetadataInCategory(key, value);
        }
    }
}
