using System.Collections.Generic;

namespace ConceptsMicroservice.Models
{
    public class ConceptItem
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public long Id { get; set; }
        public long ExternalId { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public string Author { get; set; }
        public PublishingStatus StatusId { get; set; }
        public ICollection<Metadata> Metadatas { get; set; }


    }
}
