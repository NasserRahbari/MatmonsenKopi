using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ConceptsMicroservice.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NpgsqlTypes;

namespace ConceptsMicroservice.Repositories
{
    public class MetadataRepository : IMetadataRepository
    {
        private readonly ConceptsContext _context;
        private readonly string _metaTableName;
        public MetadataRepository(ConceptsContext context)
        {
            _context = context;
            _metaTableName = MetaData.TABLE_NAME;
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
                    .FromSql("SELECT * FROM concept_metas WHERE data->>@data IS NOT NULL", new Npgsql.NpgsqlParameter("data", key))
                    .ToList();
            }
            // We only want metadata which has the specific value at the specific attribute
            if (!string.IsNullOrWhiteSpace(key) && !string.IsNullOrWhiteSpace(value))
            {
                return _context.MetaData
                    .FromSql("SELECT * FROM concept_metas WHERE data->>@data = @value",
                            new Npgsql.NpgsqlParameter("data", key), 
                            new Npgsql.NpgsqlParameter("value", value))
                    .ToList();
            }
            
            return new List<MetaData>();
        }

        public bool DeactivateMetadata(int id)
        {
            var meta = _context.MetaData.FirstOrDefault(x => x.Id == id);
            if (meta == null)
                return true;

            meta.IsActive = false;
            _context.MetaData.Update(meta);

            return _context.SaveChanges() == 1;
        }
    }
}
