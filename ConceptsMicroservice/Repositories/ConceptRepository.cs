using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ConceptsMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace ConceptsMicroservice.Repositories
{
    public class ConceptRepository : IConceptRepository
    {
        private readonly ConceptsContext _context;
        public ConceptRepository(ConceptsContext context)
        {
            _context = context;
        }

        public List<Concept> SearchForConcepts(Dictionary<string, string> searchFields)
        {/*
            string metaIn = CreateIN_String(searchFields);
            string whenMetaExits = "";
            if (!String.IsNullOrEmpty(metaIn))
            {
                whenMetaExits = "c.\"Id\" in (SELECT map.\"ConceptId\" FROM" +
                                " \"ConceptMetas\" map WHERE map.\"MetadataId\" in " +
                                "( SELECT m.\"Id\" FROM \"Metadata\" m WHERE m.\"Code\" " +
                                "IN" + metaIn + " )) AND";
            }
            string sqlQuery = "SELECT c.\"Id\", c.\"Title\", c.\"Content\", " +
                              "c.\"ExternalId\", c.\"Created\", c.\"Updated\"," +
                              " c.\"Author\", c.\"StatusId\" " +
                              "FROM \"Concepts\" c" +
                              " WHERE " +
                               whenMetaExits +
                              " LOWER(c.\"Title\") LIKE LOWER( '%" + searchFields.Title + "%')";
            var concepts = _context.Concepts
                //.Include(collection => collection.Metadata)
                //.ThenInclude(collectionItem => collectionItem.Metadata)
                .FromSql(sqlQuery).ToList();
  
            return concepts;
            */
            var builder = new StringBuilder();
            var args = new object[searchFields.Count];
            var argIndex = 0;
       
            foreach (var key in searchFields.Keys)
            {
                builder.Append($" @{key}");
                args[argIndex] = searchFields[key];
                argIndex++;
            }

            
            return _context.Concepts
                .Include(x => x.Metadata)
                //.FromSql("SELECT * FROM concepts WHERE title LIKE %@title%", new Npgsql.NpgsqlParameter("title", "Mask"))
                .ToList();
        }

        public Concept GetById(int id)
        {
            return _context.Concepts
                .Include(x => x.Metadata)
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == id);
        }
        public Concept Update(Concept updated)
        {
           var concept = _context.Concepts.Update(updated);
            concept.Entity.Modified = DateTime.Now;

            _context.SaveChanges();
            return concept.Entity;
        }
    }
}
