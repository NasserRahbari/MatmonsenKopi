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
        private readonly IConceptRepository _conceptRepository;
        private readonly IMetadataRepository _metaRepository;
        private readonly List<Concept> _conceptsInDatabase;

        public ConceptServiceTest()
        {
            _metaRepository = A.Fake<IMetadataRepository>();
            _conceptRepository = A.Fake<IConceptRepository>();
            _service = new ConceptService(_conceptRepository, _metaRepository);
        }

        #region Search

        [Fact]
        public void SearchForConcepts_Returns_All_Concepts_Dict_Is_Empty()
        {
            Assert.True(false, "Not implemented");
        }
        [Fact]
        public void SearchForConcepts_Returns_Only_Concepts_With_Specific_Meta()
        {
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void SearchForConcepts_Returns_Empty_List_When_No_Concepts_Exists_With_Specified_Meta()
        {
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void SearchForConcepts_Returns_Empty_List_If_No_Concepts_Exists()
        {
            Assert.True(false, "Not implemented");
        }


        #endregion
        

        #region No concepts exists in database

        [Fact]
        public void SearchForConcepts_Returns_Empty_List_When_No_Concepts_exists()
        {
            A.CallTo(() => _conceptRepository.SearchForConcepts(A.Fake<Dictionary<string, string>>()))
                .Returns(default(List<Concept>));

            var searchResults = _service.SearchForConcepts(new Dictionary<string, string>());
            Assert.Empty(searchResults);
        }

        #endregion
    }
}
