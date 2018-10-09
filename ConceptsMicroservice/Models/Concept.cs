using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NJsonSchema.Annotations;

namespace ConceptsMicroservice.Models
{
    [Table("concepts", Schema = "public")]
    public class Concept
    {
        public static readonly string TABLE_NAME = "concepts";

        [Column("title")]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Column("content")]
        [Required(ErrorMessage = "Content is required")]
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
        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        [ForeignKey("metadataId")]
        public MetaData Metadata { get; set; } = null;

    }
}
