using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Repositories
{
    public interface IMetadataRepository
    {
        List<Metadata> GetAll();

    }
}
