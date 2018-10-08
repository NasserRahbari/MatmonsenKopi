using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConceptsMicroservice.Models
{
    [Table("concepts", Schema = "public")]
    public class Concept
    {
        public static readonly string TABLE_NAME = "concepts";
        public string Title { get; set; }
        public string Content { get; set; }
        public int Id { get; set; }
        public int ExternalId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Author { get; set; }
        public int MetadataId { get; set; }
        public MetaData Metadata { get; set; } = null;


    }
}
