using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConceptsMicroservice.Models
{
    [Table("concept_metas", Schema = "public")]
    public class MetaData
    {
        public static readonly string TABLE_NAME = "concept_metas";
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "jsonb")]
        public string  Data { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
