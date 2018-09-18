using System.Collections.Generic;
using System.Linq;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Repositories;
using ConceptsMicroservice.Utilities;
using FakeItEasy;
using Xunit;

namespace ConceptsMicroservice.UnitTests.Repositories
{
    public class ConceptRepositoryFromFileDatabaseTest
    {
        

        private IFileDB _db;
        private readonly IConceptRepository _repository;
        private readonly List<ConceptItem> _conceptsInDatabase;

        public ConceptRepositoryFromFileDatabaseTest()
        {
            _db = A.Fake<IFileDB>();
            _repository = new ConceptRepositoryFromFileDatabase(_db);
            _conceptsInDatabase = new List<ConceptItem>
            {
                new ConceptItem{Title = "TestTitle"},
                new ConceptItem{Title = "Another test"},
                new ConceptItem{Title = "I am a concept"},
            };

            A.CallTo(() => _db.ReadFromFile()).Returns(_conceptsInDatabase);
        }

        [Fact]
        public void SearchForConcepts_Returns_All_Concepts_If_No_SearchFields_Is_Specified()
        {
            var searchResult = _repository.SearchForConcepts(new ConceptSearchFields());
            
            Assert.Equal(_conceptsInDatabase.Count, searchResult.Count);
        }

        [Fact]
        public void SearchForConcepts_Returns_All_Concepts_If_SearchFields_Is_Null()
        {
            var searchResult = _repository.SearchForConcepts(null);

            Assert.Equal(_conceptsInDatabase.Count, searchResult.Count); 
        }

        [Fact]
        public void SearchForConcepts_Returns_Empty_List_Of_Concepts_If_No_Match_With_SearchFields()
        {
            var searchResult = _repository.SearchForConcepts(new ConceptSearchFields{Title = "No match"});

            Assert.Empty(searchResult);
        }

        [Fact]
        public void SearchForConcepts_Returns_List_Of_Concepts_If_Found_Match_With_SearchFields()
        {
            const string term = "test";

            var searchResult = _repository.SearchForConcepts(new ConceptSearchFields { Title = term });
            var resultsInMockDb = _conceptsInDatabase.Count(x => x.Title.ToLower().Contains(term.ToLower()));
            Assert.Equal(resultsInMockDb, searchResult.Count);
        }

    }
}
