using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Services
{
    public interface IConceptService
    {
        List<ConceptDTO> SearchForConcepts(Dictionary<string, string> searchFields);
        ConceptDTO GetConceptById(int id);
    }
}
