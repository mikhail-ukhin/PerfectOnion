using AutoMapper;
using PerfectOnion.Core.PerfectOnion.Dtos;
using PerfectOnion.Core.PerfectOnion.Entities;

namespace PerfectOnion.Services.Configuration
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Order, OrderDto>();
        }
    }
}