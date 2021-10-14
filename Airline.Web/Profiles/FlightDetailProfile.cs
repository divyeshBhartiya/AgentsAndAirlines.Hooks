using Airline.Web.Dtos;
using Airline.Web.Models;
using AutoMapper;

namespace Airline.Web.Profiles
{
    public class FlightDetailProfile : Profile
    {
        public FlightDetailProfile()
        {
            //Source -> Target
            CreateMap<FlightDetail, FlightDetailReadDto>();
            CreateMap<FlightDetailCreateDto, FlightDetail>();
            CreateMap<FlightDetailUpdateDto, FlightDetail>();
        }
    }
}