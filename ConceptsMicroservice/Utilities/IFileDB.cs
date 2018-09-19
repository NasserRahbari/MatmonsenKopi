using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Utilities
{
    public interface IFileDB
    {
        string URL { get; set; }
        List<ConceptItem> ReadFromFile();
    }
}
