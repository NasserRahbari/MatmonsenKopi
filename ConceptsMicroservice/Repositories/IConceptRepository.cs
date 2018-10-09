using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Repositories
{
    public interface IConceptRepository
    {
        List<Concept> SearchForConcepts(Dictionary<string, string> searchParams);
        Concept GetById(int id);
        Concept Update(Concept updated);
    }
}
