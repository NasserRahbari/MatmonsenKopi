using System;
using System.Collections.Generic;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Repositories;
using ConceptsMicroservice.ViewModels;

namespace ConceptsMicroservice.Services
{
    public class ConceptService : IConceptService
    {
        private readonly IConceptRepository _conceptRepository;
        private readonly IMetadataRepository _metadataRepository;

        public ConceptService(IConceptRepository concept, IMetadataRepository meta)
        {
            _conceptRepository = concept;
            _metadataRepository = meta;
        }

        public List<Concept> SearchForConcepts(Dictionary<string, string> searchFields)
        {
            return _conceptRepository.SearchForConcepts(searchFields);
        }

        public Concept GetConceptById(int id)
        {
            return _conceptRepository.GetById(id);
        }

        /// <summary>
        /// Updates a concept.
        /// Will not delete metadata for concept, only set it to not active.
        /// </summary>
        /// <param name="newConceptVersion"></param>
        /// <returns>Viewmodel of the concept if success, or viewModel with errors and exceptions</returns>
        public ConceptViewModel UpdateConcept(Concept newConceptVersion)
        {
            var viewModel = new ConceptViewModel();
            var oldConceptVersion = GetConceptById(newConceptVersion.Id);

            // Concept does not exist in the database, so cannot update it.
            if (oldConceptVersion == null)
            {
                viewModel.Errors.Add("Concept", "Object does not exists.");
                return viewModel;
            }

            var newConceptHasMetadata = newConceptVersion.Metadata != null;
            var oldConceptHasMetadata = oldConceptVersion.Metadata != null;

            // Meta-object id is different from oldConcept-version's meta-object id.
            if (newConceptHasMetadata 
                && oldConceptHasMetadata 
                && newConceptVersion.Metadata.Id != oldConceptVersion.Metadata.Id)
            {
                viewModel.Errors.Add("Metadata", "Cannot assign different metadata object. Metadata must have original Id");
                return viewModel;
            }

            // Don't delete Metadata. Only set it to notActive
            if (!newConceptHasMetadata && oldConceptHasMetadata)
            {
                try
                {
                    newConceptVersion.Metadata = _metadataRepository.DeactivateMetadata(oldConceptVersion.Metadata.Id);
                    newConceptVersion.Metadata.Modified = DateTime.Now;
                }
                catch (System.InvalidOperationException e)
                {
                    viewModel.Exceptions.Add("UpdateMeta", e);
                    return viewModel;
                }
            }

            // Checks if any data has changed
            if (newConceptHasMetadata && newConceptVersion.Metadata.IsUpdated(oldConceptVersion.Metadata))
            {
                newConceptVersion.Metadata.Modified = DateTime.Now;
            }

            // Readonly fields
            newConceptVersion.Created = oldConceptVersion.Created;
            newConceptVersion.ExternalId = oldConceptVersion.ExternalId;
            
            try
            {
                viewModel.Concept = _conceptRepository.Update(newConceptVersion);
            }
            catch (System.InvalidOperationException e)
            {
                viewModel.Exceptions.Add("UpdateConcept", e);
            }
            
            return viewModel;
        }
    }
}
