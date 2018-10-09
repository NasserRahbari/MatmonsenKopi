using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Services
{
    public interface IMetadataService
    {
        List<MetaData> GetMetadataItems();
        List<MetaData> SearchForMetadataInCategory(string category, string term);
    }
}
