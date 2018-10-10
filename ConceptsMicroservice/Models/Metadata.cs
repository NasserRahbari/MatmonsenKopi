using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ConceptsMicroservice.Models
{
    [Table("concept_metas", Schema = "public")]
    public class MetaData
    {
        public static readonly string TABLE_NAME = "concept_metas";

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("data", TypeName = "jsonb")]
        [JsonIgnore]
        public string  Data { get; set; }

        [Column("created")]
        public DateTime Created { get; set; }

        [Column("modified")]
        public DateTime Modified { get; set; }

        [Column("isActive")]
        public bool IsActive { get; set; }

        [NotMapped]
        [JsonProperty("data")]
        // Property which represents the meta json object.
        // Without this, the Data would just be returned as a string, and not json
        public Dictionary<string, object> Metas {
            get => JsonConvert.DeserializeObject<Dictionary<string, object>>(Data ?? string.Empty);
            set => this.Data = JsonConvert.SerializeObject(value);
        }

        public bool IsUpdated(MetaData other)
        {
            if (other == null)
                return false;

            var changedData = !string.IsNullOrEmpty(Data) && Data.Equals(other.Data);
            var toggledActive = IsActive != other.IsActive;

            return changedData || toggledActive;
        }
    }
}
