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
       public string Language { get; set; }
       public string SupportedLanguages { get; set; }
        
    }
}
