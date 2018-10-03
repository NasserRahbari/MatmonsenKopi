using System;
using System.Collections.Generic;
using System.Linq;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly ConceptsContext _context;
        public CategoryRepository(ConceptsContext context)
        {
            _context = context;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList<Category>();
        }

        public List<Category> SearchForCategory(string name)
        {
            throw new NotImplementedException();
        }
    }
}
