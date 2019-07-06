using AutoMapper;
using PerfectOnion.Core.Entities;
using PerfectOnion.Service.Dtos;

namespace PerfectOnion.Service.Configuration
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Order, OrderDto>();
        }
    }
}