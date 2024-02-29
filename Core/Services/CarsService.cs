using Core.Dtos;
using Core.Entities;
using Core.Interfaces.Repository;
using Core.Interfaces.Service;
using Microsoft.AspNetCore.Http;

namespace Core.Services
{
    public class CarsService : BaseService<Cars>, ICarsService
    {
        public CarsService(IAdminInterfaces adminInterfaces) : base(adminInterfaces)
        {
        }

        public async Task<IEnumerable<Cars>> VehicleAvailable(SearchVehicleDto searchVehicleDto, IHttpContextAccessor _accessor)
        {
            try
            {
                var jsondata = await _adminInterfaces.utilsRepository.GetCoordinateInformation(searchVehicleDto.latitud, searchVehicleDto.longitude);
                string neighborhood = jsondata.RootElement.GetProperty("address").GetProperty("suburb").GetString();

                return await _adminInterfaces.carsRepository.VehicleAvailable(neighborhood);
            }
            catch (Exception e)
            {
                throw;
            }

        }

    }
}
