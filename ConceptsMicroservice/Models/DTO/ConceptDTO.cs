using System.Collections.Generic;
using ConceptsMicroservice.Models.DTO;

namespace ConceptsMicroservice.Models
{
    public class ConceptDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Id { get; set; }
        public string Author { get; set; }
        public PublishingStatus Status { get; set; }
        public ICollection<ConceptMetaDTO> Metadata { get; set; }
        //public List<MetadataDTO> Metadata { get; set; }


    }
}
