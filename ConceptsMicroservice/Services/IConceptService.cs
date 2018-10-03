using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Services
{
    public interface IConceptService
    {
        List<Concept> SearchForConcepts(ConceptSearchFields searchFields);
    }
}
