﻿using System.Collections.Generic;
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
            string sqlQuery = "SELECT c.\"Id\", c.\"Title\", c.\"Content\", " +
                              "c.\"ExternalId\", c.\"Created\", c.\"Updated\"," +
                              " c.\"Author\", c.\"StatusId\" " +
                              "FROM \"Concepts\" c" +
                              " WHERE c.\"Id\" in (SELECT map.\"ConceptId\" FROM" +
                              " \"ConceptMetas\" map WHERE map.\"MetadataId\" in " +
                              "( SELECT m.\"Id\" FROM \"Metadata\" m WHERE m.\"Code\" " +
                              "IN" + CreateIN_String (searchFields) + " )) " + 
                              "OR LOWER(c.\"Title\") LIKE LOWER( '%" + searchFields.Title + "%')";
            var concepts = _context.Concepts
                .Include(collection => collection.Metadata)
                .ThenInclude(collectionItem => collectionItem.Metadata)
                .FromSql(sqlQuery).ToList();
  
            return concepts;
        }

        public Concept GetById(int id)
        {
            return _context.Concepts
                .Include(x => x.Metadata)
                .FirstOrDefault(x => x.Id == id);
        }

        private string CreateIN_String(ConceptSearchFields searchFields)
        {
            string result = "";
            result = " ('" + searchFields.Language + "', '" + searchFields.Subject + "')"; //", '" + searchFields.Title + "')";
            return result;
        }
    }
}
