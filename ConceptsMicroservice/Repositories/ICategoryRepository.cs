using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        List<Category> SearchForCategory(string name);
    }
}
