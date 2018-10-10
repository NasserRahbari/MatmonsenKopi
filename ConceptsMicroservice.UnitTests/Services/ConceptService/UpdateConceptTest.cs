using System;
using System.Linq;
using ConceptsMicroservice.Models;
using Xunit;
using FakeItEasy;

namespace ConceptsMicroservice.UnitTests.Services.ConceptService
{
    public class UpdateConceptTest : ConceptServiceTest
    {

        private readonly MetaData _oldMeta;
        private readonly MetaData _newMeta;

        private readonly int _conceptId;
        private readonly Concept _oldConcept;
        private readonly Concept _newConcept;

        public UpdateConceptTest() : base()
        {
            _conceptId = 1;

            _oldMeta = new MetaData { Id = 1 };
            _newMeta = new MetaData { Id = 2 };

            _oldConcept = new Concept { Id = _conceptId, Metadata = _oldMeta, Title ="Old title" };
            _newConcept = new Concept { Id = _conceptId, Metadata = _oldMeta, Title = "New title" };


            A.CallTo(() => ConceptRepository.GetById(_conceptId)).Returns(_oldConcept);
        }
        

        [Fact]
        public void Update_Also_Updates_Meta()
        {
            A.CallTo(() => ConceptRepository.Update(A<Concept>._)).Returns(_newConcept);
            _oldConcept.Metadata = _newConcept.Metadata;

            const string changedMeta = "newData";
            _newConcept.Metadata.Data = changedMeta;

            var viewModel = Service.UpdateConcept(_newConcept);
            Assert.Equal(viewModel.Concept.Metadata.Data, changedMeta);
            Assert.NotEqual(viewModel.Concept.Title, _oldConcept.Title);
        }

        [Fact]
        public void Update_Updates_Concept()
        {
            A.CallTo(() => ConceptRepository.Update(A<Concept>._)).Returns(_newConcept);
            _oldConcept.Metadata = _newConcept.Metadata;
            
            var viewModel = Service.UpdateConcept(_newConcept);
            Assert.NotEqual(viewModel.Concept.Title, _oldConcept.Title);
        }

        [Fact]
        public void Update_Sets_Meta_To_Not_Active_If_Meta_Null()
        {
            A.CallTo(() => MetaRepository.DeactivateMetadata(A<int>._)).Returns(new MetaData{IsActive = false});
            A.CallTo(() => ConceptRepository.Update(A<Concept>._)).Returns(_newConcept);

            _newConcept.Metadata = null;

            var viewModel = Service.UpdateConcept(_newConcept);
            Assert.True(viewModel.IsValid());
            Assert.NotNull(viewModel.Concept);
            Assert.False(viewModel.Concept.Metadata.IsActive);
        }

        [Fact]
        public void Update_Is_Not_Success_Or_Valid_If_Meta_Has_Different_Id_Then_In_The_Old_Version()
        {
            _newConcept.Metadata = _newMeta;
            var viewModel = Service.UpdateConcept(_newConcept);
            Assert.Equal(viewModel.Errors.Keys.FirstOrDefault(), "Metadata");
            Assert.Null(viewModel.Concept);
        }

        [Fact]
        public void Update_New_Concept_Results_In_Error()
        {
            A.CallTo(() => ConceptRepository.GetById(_conceptId)).Returns(null);

            var viewModel = Service.UpdateConcept(_newConcept);

            Assert.Equal(viewModel.Errors.Keys.FirstOrDefault(), "Concept");
            Assert.Null(viewModel.Concept);
        }

        [Fact]
        public void Update_Does_Not_Change_ReadOnlyField_ExternalId()
        {
            A.CallTo(() => ConceptRepository.Update(A<Concept>._)).Returns(_newConcept);

            _oldConcept.ExternalId = 1;
            _newConcept.ExternalId = 2;

            var viewModel = Service.UpdateConcept(_newConcept);

            Assert.NotNull(viewModel.Concept);
            Assert.Equal(viewModel.Concept.ExternalId, _oldConcept.ExternalId);
        }
        [Fact]
        public void Update_Does_Not_Change_ReadOnlyField_Created()
        {
            var changedDateTime = DateTime.Today.AddDays(-1);
            _newConcept.Created = changedDateTime;
            var oldConcept = new Concept{Created = DateTime.Today};

            A.CallTo(() => ConceptRepository.Update(_newConcept)).Returns(oldConcept);

            var viewModel = Service.UpdateConcept(_newConcept);

            Assert.Equal(viewModel.Concept.Created, oldConcept.Created);
            Assert.NotEqual(viewModel.Concept.Created, changedDateTime);
        }
        [Fact]
        public void Update_Changes_Concept_Modified()
        {
            var conceptFromDatabase = new Concept { Modified = DateTime.Today };
            _newConcept.Modified = conceptFromDatabase.Modified.AddDays(-1);

            A.CallTo(() => ConceptRepository.Update(_newConcept)).Returns(conceptFromDatabase);

            var viewModel = Service.UpdateConcept(_newConcept);
            
            Assert.Equal(viewModel.Concept.Modified, conceptFromDatabase.Modified);
        }

        [Fact]
        public void Update_Changes_Meta_Modified_If_Meta_Was_Modified()
        {
            var conceptFromDatabase = new Concept { Metadata = new MetaData { Modified = DateTime.Today } };
            _newConcept.Metadata.Modified = conceptFromDatabase.Metadata.Modified.AddDays(-1);

            A.CallTo(() => ConceptRepository.Update(_newConcept)).Returns(conceptFromDatabase);

            var viewModel = Service.UpdateConcept(_newConcept);

            Assert.Equal(viewModel.Concept.Metadata.Modified, conceptFromDatabase.Metadata.Modified);
        }

        [Fact]
        public void Update_Does_Not_Change_Meta_Modified_If_Meta_Was_Not_Modified()
        {
            var now = DateTime.Now;
            _newConcept.Metadata.Modified = now;

            A.CallTo(() => ConceptRepository.Update(_newConcept)).Returns(_newConcept);

            var viewModel = Service.UpdateConcept(_newConcept);

            Assert.Equal(viewModel.Concept.Metadata.Modified, now);
        }

        [Fact]
        public void Update_Returns_Error_When_Repo_Throws_Exception()
        {
            A.CallTo(() => ConceptRepository.Update(A<Concept>._)).Throws<InvalidOperationException>();
            var viewModel = Service.UpdateConcept(A.Fake<Concept>());
            Assert.NotEmpty(viewModel.Exceptions);
        }
    }
}
