using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Test_DataAccess;
using Test_BusinessService.ServiceObjects;

namespace Test_BusinessService
{
    public class MappingProfile : Profile
{
        public MappingProfile() {
            CreateMap<PropertySO, Property>()
                .ForMember(dest => dest.Id, source => source.MapFrom(source => source.Id == null ? Guid.NewGuid() : source.Id))
                .ReverseMap();
        }
}
}
