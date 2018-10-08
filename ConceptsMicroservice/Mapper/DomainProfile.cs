using System.Collections.Generic;
using AutoMapper;
using ConceptsMicroservice.Models;
using ConceptsMicroservice.Models.DTO;
using Newtonsoft.Json;

namespace ConceptsMicroservice.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<MetaData, MetaDataDTO>()
                .ForMember(dest => dest.Data,
                    opts => opts.MapFrom(src => JsonConvert.DeserializeObject<Dictionary<string, object>>(src.Data)));
            CreateMap<Concept, ConceptDTO>();
        }
    }
}
