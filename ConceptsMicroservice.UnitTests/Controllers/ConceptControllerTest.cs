using System;
using System.Collections.Generic;
using ConceptsMicroservice.Controllers;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Services;
using ConceptsMicroservice.ViewModels;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace ConceptsMicroservice.UnitTests.Controllers
{
    
    public class ConceptControllerTest
    {
        private readonly IConceptService _service;
        private readonly ConceptController _controller;
        private readonly List<Concept> _concepts;
        private readonly Concept _concept;

        public ConceptControllerTest()
        {
            _service = A.Fake<IConceptService>();
            _controller = new ConceptController(_service);
            _concept = new Concept
            {
                Title = "Title",
                Author = "Author",
                Content = "Content",
                Created = DateTime.Now,
                Modified = DateTime.Now,
                Metadata = new MetaData
                {
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    Data = "Data"
                }
            };
            _concepts = new List<Concept>
            {
                new Concept{Title = "TestTitle"},
                new Concept{Title = "Another test"},
            };
        }

        #region Update
        [Fact]
        public void UpdateConcept_Returns_400_When_Concept_Is_Null()
        {
            var result = _controller.UpdateConcept(null);
            var badRequest = result.Result as BadRequestObjectResult;

            Assert.Null(result.Value);
            Assert.Equal(400, badRequest.StatusCode);
        }
        [Fact]
        public void UpdateConcept_Returns_400_On_ModelState_Error()
        {
            _controller.ModelState.TryAddModelError("error", "error");
            var result = _controller.UpdateConcept(new Concept{Title = null});
            var badRequest = result.Result as BadRequestObjectResult;

            Assert.Null(badRequest.Value);
            Assert.Equal(400, badRequest.StatusCode);
        }

        [Fact]
        public void UpdateConcept_Returns_200_On_Successful_Update()
        {
            A.CallTo(() => _service.UpdateConcept(_concept))
                .Returns(new ConceptViewModel {Concept = new Concept()});
            var result = _controller.UpdateConcept(_concept);
            var ok = result.Result as OkObjectResult;

            Assert.NotNull(ok.Value);
            Assert.Equal(200, ok.StatusCode);
        }

        [Fact]
        public void UpdateConcept_Returns_400_If_ViewModel_Contains_Errors()
        {
            A.CallTo(() => _service.UpdateConcept(A<Concept>._))
                .Returns(new ConceptViewModel { Errors = new Dictionary<string, string>{{ "error" , "error"} }});

            var result = _controller.UpdateConcept(_concept);
            var badRequest = result.Result as BadRequestObjectResult;

            Assert.Null(result.Value);
            Assert.Equal(400, badRequest.StatusCode);
        }
        [Fact]
        public void UpdateConcept_Returns_400_If_ViewModel_Contains_Exceptions()
        {
            A.CallTo(() => _service.UpdateConcept(A<Concept>._))
                .Returns(new ConceptViewModel { Exceptions = new Dictionary<string, Exception> { { "error", new Exception() } } });

            var result = _controller.UpdateConcept(_concept);
            var badRequest = result.Result as BadRequestObjectResult;

            Assert.Null(result.Value);
            Assert.Equal(400, badRequest.StatusCode);
        }
        #endregion

        #region Search
        [Fact]
        public void SearchForConcepts_Returns_Empty_List_When_Service_Does_Not_Find_any_Concepts()
        {
            A.CallTo(() => _service.SearchForConcepts(null)).Returns(new List<Concept>());

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
        #endregion
    }
}
