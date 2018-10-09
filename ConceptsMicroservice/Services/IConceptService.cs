using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Services
{
    public interface IConceptService
    {
        List<Concept> SearchForConcepts(Dictionary<string, string> searchFields);
        Concept GetConceptById(int id);
        Concept UpdateConcept(Concept c);
    }
}
