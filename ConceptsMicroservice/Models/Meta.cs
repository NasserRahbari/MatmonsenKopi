
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;

namespace ConceptsMicroservice.Models
{
    public class MetaData
    {
        public string  Value { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
