using System;
using System.Collections.Generic;
using ConceptsMicroservice.Models;

namespace ConceptsMicroservice.ViewModels
{
    public class ConceptViewModel
    {
        public Concept Concept { get; set; }
        public Dictionary<string, string> Errors { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, Exception> Exceptions { get; set; } = new Dictionary<string, Exception>();

        public bool IsValid()
        {
            return Errors.Count == 0 && Exceptions.Count == 0;
        }
    }
}
