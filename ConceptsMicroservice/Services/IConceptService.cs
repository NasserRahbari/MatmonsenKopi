using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Services
{
    public interface IConceptService
    {
        List<ConceptItem> SearchForConcepts(ConceptSearchFields searchFields);
    }
}
