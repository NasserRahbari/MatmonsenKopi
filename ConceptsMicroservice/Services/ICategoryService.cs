using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Services
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
