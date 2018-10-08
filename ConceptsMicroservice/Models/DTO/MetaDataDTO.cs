using System;
using System.Collections.Generic;

namespace ConceptsMicroservice.Models.DTO
{
    public class MetaDataDTO
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Dictionary<string, object> Data { get; set; }
    }
}
