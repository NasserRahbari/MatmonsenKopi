using System.Collections.Generic;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.ViewModels;

namespace ConceptsMicroservice.Services
{
    public interface IConceptService
    {
        List<Concept> SearchForConcepts(Dictionary<string, string> searchFields);
        Concept GetConceptById(int id);
        ConceptViewModel UpdateConcept(Concept newConceptVersion);
    }
}
