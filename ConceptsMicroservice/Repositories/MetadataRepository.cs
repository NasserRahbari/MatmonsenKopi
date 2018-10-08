using System.Collections.Generic;
using System.Linq;
using ConceptsMicroservice.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ConceptsMicroservice.Repositories
{
    public class MetadataRepository : IMetadataRepository
    {
        private readonly ConceptsContext _context;

        public MetadataRepository(ConceptsContext context)
        {
            _context = context;
        }
        public List<MetaData> GetAll()
        {
            return _context.MetaData.ToList();
        }

        public List<MetaData> SearchForMetadataByMetaKeyAndValue(string key, string value)
        {   
            // We want all metadata when key and value is null or empty
            if (string.IsNullOrWhiteSpace(key) && string.IsNullOrWhiteSpace(value))
            {
                return _context.MetaData
                    .ToList();
            }
            // We only want metadata which has a attribute on root level
            // TODO make dynamic by specifying levels...
            if (!string.IsNullOrWhiteSpace(key) && string.IsNullOrWhiteSpace(value))
            {
                return _context.MetaData
                    .FromSql($"SELECT * FROM {MetaData.TABLE_NAME} WHERE data->>'{key}' IS NOT NULL")
                    .ToList();
            }
            // We only want metadata which has the specific value at the specific attribute
            if (!string.IsNullOrWhiteSpace(key) && !string.IsNullOrWhiteSpace(value))
            {
                return _context.MetaData
                    .FromSql($"SELECT * FROM {MetaData.TABLE_NAME} WHERE data->>'{key}' = '{value}'")
                    .ToList();
            }
            
            return new List<MetaData>();
        }
    }
}
