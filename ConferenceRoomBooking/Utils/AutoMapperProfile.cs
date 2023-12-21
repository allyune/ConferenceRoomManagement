using AutoMapper;
using ConferenceRoomBooking.Models;
using DtbModels =  Data.Models;


public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<DtbModels.Room, ConferenceRoom>().ReverseMap();
        CreateMap<DtbModels.Booking, Booking>().ReverseMap();
    }
}
