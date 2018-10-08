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
        public ActionResult<List<MetaData>> GetMetadata()
        {
            var result = _service.GetMetadataItems();
            return result;
        }

        [HttpGet]
        [Route("autocomplete")]
        public ActionResult<List<MetaData>> GetMetaForAutocomplete([FromQuery] string category, [FromQuery] string term)
        {
            // Spør etter feks ?category=nn&term=ny
            // Vil da finne alle metadata som er av category language og contains "ny"
            return _service.SearchForMetadataInCategory(category, term);
        }
    }
}
