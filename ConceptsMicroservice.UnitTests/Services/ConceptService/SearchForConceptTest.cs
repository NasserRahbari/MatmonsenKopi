﻿using System.Collections.Generic;
using ConceptsMicroservice.Models;
using Xunit;
using FakeItEasy;

namespace ConceptsMicroservice.UnitTests.Services
{
    public class SearchForConceptTest : ConceptServiceTest
    {
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
        public void SearchForConcepts_Returns_Empty_List_When_No_Concepts_Exists()
        {
            A.CallTo(() => ConceptRepository.SearchForConcepts(A.Fake<Dictionary<string, string>>()))
                .Returns(default(List<Concept>));

            var searchResults = Service.SearchForConcepts(new Dictionary<string, string>());
            Assert.Empty(searchResults);
        }
        #endregion
    }
}
