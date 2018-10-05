using System;
using System.Collections.Generic;
using System.Linq;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Utilities;
using Microsoft.EntityFrameworkCore;

namespace ConceptsMicroservice.Repositories
{
    public class ConceptRepositoryFromFileDatabase : IConceptRepository
    {
        //private readonly IFileDB _fileDB;
        private readonly ConceptsContext _context;
        public ConceptRepositoryFromFileDatabase(ConceptsContext context) //IFileDB db)
        {
            //_fileDB = db;
            _context = context;
        }

        public List<Concept> SearchForConcepts(ConceptSearchFields searchFields)
        {
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
        }

        public Concept GetById(int id)
        {
            var concept  = _context.Concepts
                .Include(x => x.Metadata)
                .FirstOrDefault(x => x.Id == id);


            return concept;
        }

        private string CreateIN_String(ConceptSearchFields searchFields)
        {
            string result;
            if (string.IsNullOrEmpty(searchFields.Language) && string.IsNullOrEmpty(searchFields.Subject))
            {
                result = "";
            }
            else
            {
                result = " ('" + searchFields.Language + "', '" + searchFields.Subject +
                         "')";
            }

            return result;
        }
    }
}
