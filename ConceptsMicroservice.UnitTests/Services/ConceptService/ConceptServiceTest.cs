using ConceptsMicroservice.Repositories;
using ConceptsMicroservice.Services;
using FakeItEasy;

namespace ConceptsMicroservice.UnitTests.Services
{
    public class ConceptServiceTest
    {

        protected readonly IConceptService Service;
        protected readonly IConceptRepository ConceptRepository;
        protected readonly IMetadataRepository MetaRepository;

        public ConceptServiceTest()
        {
            MetaRepository = A.Fake<IMetadataRepository>();
            ConceptRepository = A.Fake<IConceptRepository>();
            Service = new ConceptsMicroservice.Services.ConceptService(ConceptRepository, MetaRepository);
        }
    }
}
