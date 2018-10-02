using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Services
{
    public interface IMetadataService
    {
        List<Metadata> GetMetadataItems();
        List<Metadata> SearchForMetadataInCategory(string category, string term);
    }
}
