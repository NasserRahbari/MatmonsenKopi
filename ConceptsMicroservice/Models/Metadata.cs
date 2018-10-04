using System.Collections.Generic;

namespace ConceptsMicroservice.Models
{
    public class Metadata
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ConceptMeta> Concepts { get; set; }
    }
}
