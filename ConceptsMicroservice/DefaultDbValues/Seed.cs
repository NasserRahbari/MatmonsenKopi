using System.Collections.Generic;
using System.IO;
using ConceptsMicroservice.Models;
using Newtonsoft.Json;

namespace ConceptsMicroservice.DefaultDbValues
{
    public class Seed
    {
        private static string GetPath(string file)
        {
            return Path.Join("DefaultDbValues", file);
        }

        public static List<Concept> SeedConcept()
        {
            try
            {
                var fileStream = new FileStream(GetPath("concepts.json"), FileMode.Open);
                using (var reader = new StreamReader(fileStream))
                {
                    return JsonConvert.DeserializeObject<List<Concept>>(reader.ReadToEnd());
                }
            }
            catch
            {
                return new List<Concept>();
            }
        }

        public static List<PublishingStatus> SeedPublishedStatus()
        {
            try
            {
                var fileStream = new FileStream(GetPath("publishedStatus.json"), FileMode.Open);
                using (var reader = new StreamReader(fileStream))
                {
                    return JsonConvert.DeserializeObject<List<PublishingStatus>>(reader.ReadToEnd());
                }
            }
            catch
            {
                return new List<PublishingStatus>();
            }
        }

        public static List<Metadata> SeedMeta()
        {
            try
            {
                var fileStream = new FileStream(GetPath("meta.json"), FileMode.Open);
                using (var reader = new StreamReader(fileStream))
                {
                    return JsonConvert.DeserializeObject<List<Metadata>>(reader.ReadToEnd());
                }
            }
            catch
            {
                return new List<Metadata>();
            }

        }

        public static List<ConceptMeta> SeedConceptMetas()
        {
            try
            {
                var fileStream = new FileStream(GetPath("metaconcepts.json"), FileMode.Open);
                using (var reader = new StreamReader(fileStream))
                {
                    return JsonConvert.DeserializeObject<List<ConceptMeta>>(reader.ReadToEnd());
                }
            }
            catch
            {
                return new List<ConceptMeta>();
            }
        }

        public static List<Category> SeedCategories()
        {
            try
            {
                var fileStream = new FileStream(GetPath("categories.json"), FileMode.Open);
                using (var reader = new StreamReader(fileStream))
                {
                    return JsonConvert.DeserializeObject<List<Category>>(reader.ReadToEnd());
                }
            }
            catch
            {
                return new List<Category>();
            }
        }
    }
}
