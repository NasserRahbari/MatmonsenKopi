using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Repositories
{
    public interface IMetadataRepository
    {
        List<Metadata> GetAll();
        List<Metadata> SearchForMetadataInCategory(string category, string term);
    }
}
