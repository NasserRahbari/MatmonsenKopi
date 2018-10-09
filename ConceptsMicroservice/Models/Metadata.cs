using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConceptsMicroservice.Models
{
    [Table("concept_metas", Schema = "public")]
    public class MetaData
    {
        public static readonly string TABLE_NAME = "concept_metas";
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("data", TypeName = "jsonb")]
        public string  Data { get; set; }
        [Column("created")]
        public DateTime Created { get; set; }
        [Column("modified")]
        public DateTime Modified { get; set; }
        [NotMapped]
        public Dictionary<string, object> Metas { get; set; }
    }
}
