using System.Collections.Generic;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Repositories;
using ConceptsMicroservice.Services;
using Xunit;
using FakeItEasy;

namespace ConceptsMicroservice.UnitTests.Services
{
    public class ConceptServiceTest
    {

        private readonly IConceptService _service;
        private ConceptSearchFields _noSearchFields;
        private readonly IConceptRepository _conceptRepository;
        private readonly List<ConceptItem> _conceptsInDatabase;

        public ConceptServiceTest()
        {
            _conceptRepository = A.Fake<IConceptRepository>();
            _service = new ConceptService(_conceptRepository);
            _noSearchFields = new ConceptSearchFields();
            _conceptsInDatabase = new List<ConceptItem>
            {
                new ConceptItem{Title = "TestTitle"},
                new ConceptItem{Title = "Another test"},
            };
        }

        #region Searchfields

        [Fact]
        public void SearchForConcepts_Returns_All_Concepts_When_No_SearchFields_Is_Specified()
        {
            A.CallTo(() => _conceptRepository.SearchForConcepts(_noSearchFields))
                .Returns(_conceptsInDatabase);

            var conceptsFromService = _service.SearchForConcepts(_noSearchFields);
            Assert.Equal(conceptsFromService.Count, _conceptsInDatabase.Count);
        }

        [Fact]
        public void SearchForConcepts_Returns_All_Concepts_When_SearchFields_Is_null()
        {
            _noSearchFields = null;
            A.CallTo(() => _conceptRepository.SearchForConcepts(_noSearchFields))
                .Returns(_conceptsInDatabase);


            var conceptsFromService = _service.SearchForConcepts(_noSearchFields);
            Assert.Equal(conceptsFromService.Count, _conceptsInDatabase.Count);
        }

        [Fact]
        public void SearchForConcepts_Returns_Empty_List_When_No_Concepts_Could_Be_Found_With_SearchFields()
        {
            A.CallTo(() => _conceptRepository.SearchForConcepts(new ConceptSearchFields { Title = "Not exists" }))
                .Returns(default(List<ConceptItem>));

            var searchResults = _service.SearchForConcepts(_noSearchFields);
            Assert.Empty(searchResults);
        }
        

        #endregion

        #region No concepts exists in database

        [Fact]
        public void SearchForConcepts_Returns_Empty_List_When_No_Concepts_exists()
        {
            A.CallTo(() => _conceptRepository.SearchForConcepts(A.Fake<ConceptSearchFields>()))
                .Returns(default(List<ConceptItem>));

            var searchResults = _service.SearchForConcepts(_noSearchFields);
            Assert.Empty(searchResults);
        }

        #endregion
    }
}
