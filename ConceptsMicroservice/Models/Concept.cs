using System.Collections.Generic;

namespace ConceptsMicroservice.Models
{
    public class Concept
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Id { get; set; }
        public int ExternalId { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public string Author { get; set; }
        public PublishingStatus Status { get; set; }
        public int StatusId { get; set; }
        public ICollection<ConceptMeta> Metadata { get; set; }


    }
}
