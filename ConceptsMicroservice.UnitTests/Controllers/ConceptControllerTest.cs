using System.Collections.Generic;
using ConceptsMicroservice.Controllers;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Services;
using FakeItEasy;
using Xunit;

namespace ConceptsMicroservice.UnitTests.Controllers
{
    
    public class ConceptControllerTest
    {
        private readonly IConceptService _service;
        private readonly ConceptController _controller;
        private readonly List<ConceptItem> _concepts;
        

        public ConceptControllerTest()
        {
            _service = A.Fake<IConceptService>();
            _controller = new ConceptController(_service);

            _concepts = new List<ConceptItem>
            {
                new ConceptItem{Title = "TestTitle"},
                new ConceptItem{Title = "Another test"},
            };
        }

        [Fact]
        public void SearchForConcepts_Returns_Empty_List_When_Service_Does_Not_Find_any_Concepts()
        {
            A.CallTo(() => _service.SearchForConcepts(null)).Returns(new List<ConceptItem>());

            var result = _controller.SearchForConcepts();
            Assert.Empty(result.Value);
        }

        [Fact]
        public void SearchForConcepts_Returns_List_Of_Concepts_From_Service()
        {
            A.CallTo(() => _service.SearchForConcepts(null)).Returns(_concepts);

            var result = _controller.SearchForConcepts();
            Assert.Equal(result.Value.Count, _concepts.Count);
        }
    }
}
