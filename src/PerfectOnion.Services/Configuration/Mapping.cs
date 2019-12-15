using AutoMapper;
using PerfectOnion.Core.PerfectOnion.Entities;
using PerfectOnion.Services.Shopping.Dtos;

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