using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConceptsMicroservice.Models
{
    [Table("concepts", Schema = "public")]
    public class Concept
    {
        public static readonly string TABLE_NAME = "concepts";
        [Column("title")]
        public string Title { get; set; }
        [Column("content")]
        public string Content { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("externalId")]
        public int ExternalId { get; set; }
        [Column("created")]
        public DateTime Created { get; set; }
        [Column("modified")]
        public DateTime Modified { get; set; }
        [Column("author")]
        public string Author { get; set; }
        [Column("metadataId")]
        public int MetadataId { get; set; }
        public MetaData Metadata { get; set; } = null;


    }
}
