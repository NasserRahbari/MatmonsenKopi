using System.Collections.Generic;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Models.DTO;

namespace ConceptsMicroservice.Services
{
    public interface IMetadataService
    {
        List<MetaDataDTO> GetMetadataItems();
        List<MetaDataDTO> SearchForMetadataInCategory(string category, string term);
    }
}
