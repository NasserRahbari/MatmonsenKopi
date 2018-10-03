using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Repositories
{
    public interface IConceptRepository
    {
        List<Concept> SearchForConcepts(ConceptSearchFields searchparams);
    }
}
