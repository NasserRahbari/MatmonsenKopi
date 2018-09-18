using System;
using System.Collections.Generic;
using System.IO;
using ConceptsMicroservice.Models;
using Newtonsoft.Json;

namespace ConceptsMicroservice.Utilities
{
    public class FileDB : IFileDB
    {

        public string DbFilePath { get; set; } = @"Resources/Files/begrep_dump_as_json.csv";
        public List<ConceptItem> ReadFromFile()
        {
            var returnValueOnError = new List<ConceptItem>();

            try
            {
                using (var reader = new StreamReader(DbFilePath))
                {
                    string conceptsObjectsJSON = null;

                    try
                    {
                        conceptsObjectsJSON = reader.ReadToEnd();
                    }
                    catch (Exception)
                    {
                        return returnValueOnError;
                    }

                    return string.IsNullOrWhiteSpace(conceptsObjectsJSON)
                        ? returnValueOnError
                        : JsonConvert.DeserializeObject<List<ConceptItem>>(conceptsObjectsJSON);
                }

            }
            catch (Exception)
            {
                return returnValueOnError;
            }
        }
    }
}
