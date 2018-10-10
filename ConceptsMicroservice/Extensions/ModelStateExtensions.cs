using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ConceptsMicroservice.Extensions
{
    public static class ModelStateExtensions
    {
        

        public static void AddModelError(this ModelStateDictionary modelState, string key, string value)
        {
            modelState.TryAddModelError(key, value);
        }

        public static void AddModelError(this ModelStateDictionary modelState, Dictionary<string, string> errors)
        {
            foreach (var key in errors.Keys)
            {
                modelState.AddModelError(key, errors[key]);
            }
        }

        public static void AddModelExceptionError(this ModelStateDictionary modelState, string key, Exception value)
        {
            modelState.TryAddModelException(key, value);
        }

        public static void AddModelExceptionError(this ModelStateDictionary modelState, Dictionary<string, Exception> errors)
        {
            foreach (var key in errors.Keys)
            {
                modelState.AddModelExceptionError(key, errors[key]);
            }
        }
    }
}
