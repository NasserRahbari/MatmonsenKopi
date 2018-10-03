namespace ConceptsMicroservice.Models
{
    public class ConceptMeta
    {
        public int Id { get; set; }
        public int ConceptId { get; set; }
        public ConceptItem Concept { get; set; }
        public int MetadataId { get; set; }
        public Metadata Metadata { get; set; }

    }
}
