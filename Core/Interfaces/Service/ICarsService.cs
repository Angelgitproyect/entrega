using Core.Dtos;
using Core.Entities;
using Microsoft.AspNetCore.Http;


namespace Core.Interfaces.Service
{
    public interface ICarsService : IBaseService<Cars>
    {
        Task<IEnumerable<Cars>> VehicleAvailable(SearchVehicleDto searchVehicleDto, IHttpContextAccessor _accessor);
    }
}
