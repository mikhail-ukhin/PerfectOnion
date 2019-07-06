using AutoMapper;
using PerfectOnion.Core.Entities;
using PerfectOnion.Services.Dtos;

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