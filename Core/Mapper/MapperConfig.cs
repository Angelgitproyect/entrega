using AutoMapper;
using Core.Dtos;
using Core.Entities;

namespace Core.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig() {
            CreateMap<Cars, CarsDto>()
                .ForMember(x => x.plate, s => s.MapFrom(x => x.plate))
                .ForMember(x => x.plateCity, s => s.MapFrom(o => o.plateCity))
                .ForMember(x => x.brand, s => s.MapFrom(x => x.brand)).ReverseMap();

            CreateMap<User, UserDto>()
              .ForMember(x => x.name, s => s.MapFrom(x => x.name))
              .ForMember(x => x.dni, s => s.MapFrom(o => o.dni)).ReverseMap();

            CreateMap<VehicleRental, VehicleRentalDto>()
                .ForMember(x => x.idCar, s => s.MapFrom(x => x.idCar))
                .ForMember(x => x.idUser, s => s.MapFrom(o => o.idUser))
                .ForMember(x => x.rented, s => s.MapFrom(x => x.rented)).ReverseMap();

            CreateMap<LocationRental, LocationRentalDto>()
               .ForMember(x => x.idVehicleRental, s => s.MapFrom(x => x.idVehicleRental))
               .ForMember(x => x.idLocations, s => s.MapFrom(o => o.idLocations)).ReverseMap();
        }   
    }
}
