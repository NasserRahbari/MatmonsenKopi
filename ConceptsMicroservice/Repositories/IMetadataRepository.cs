using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Repositories
{
    public interface IMetadataRepository
    {
        List<MetaData> GetAll();
        List<MetaData> SearchForMetadataByMetaKeyAndValue(string key, string value);
        MetaData DeactivateMetadata(int id);
    }
}
