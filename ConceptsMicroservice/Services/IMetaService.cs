using System;
using System.Collections.Generic;
using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.Services
{
    public interface IMetadataService
    {
        List<Metadata> GetMetadataItems();
    }
}
