using AutoMapper;
using PerfectOnion.Core.PerfectOnion.Dtos;
using PerfectOnion.Core.PerfectOnion.Entities;

namespace PerfectOnion.Services.PerfectOnion.Configuration
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(o => o.Id, ext => ext.MapFrom(i => i.Id))
                .ReverseMap();
        }
    }
}