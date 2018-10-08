using System;
using ConceptsMicroservice.Models.DTO;

namespace ConceptsMicroservice.Models
{
    public class ConceptDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Id { get; set; }
        public int ExternalId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Author { get; set; }
        public MetaDataDTO Metadata { get; set; } = null;


    }
}
