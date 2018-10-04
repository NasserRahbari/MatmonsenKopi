using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using ConceptsMicroservice.Models;
using Newtonsoft.Json;

namespace ConceptsMicroservice.Utilities
{
    public class FileDB : IFileDB
    {

        public string URL { get; set; } =
            "https://s3.eu-central-1.amazonaws.com/sindre-capgemini-static-resources/begrep_dump_as_json.csv";
        public List<Concept> ReadFromFile()
        {
            var returnValueOnError = new List<Concept>();

            try
            {
                using (var client = new HttpClient())
                {
                    var stringResult = client.GetStringAsync(URL).Result;
                    return JsonConvert.DeserializeObject<List<Concept>>(stringResult);
                }
            }
            catch (Exception)
            {
                return returnValueOnError;
            }
        }
    }
}
