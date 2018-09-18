using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Utilities
{
    public interface IFileDB
    {
        string DbFilePath { get; set; }
        List<ConceptItem> ReadFromFile();
    }
}
