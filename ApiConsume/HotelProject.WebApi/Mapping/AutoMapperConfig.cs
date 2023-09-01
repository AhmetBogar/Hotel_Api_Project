using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            // Reversemap komutuyla yukarıdaki şekilde tersine de mapleme işlemi yapmamıza gerek kalmıyor.
            CreateMap<UpdateRoomDto, Room>().ReverseMap();

        }
    }
}
