using Core.Entities;
using Core.Interfaces.Repository;
using Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace Core.Services
{
    public class VehicleRentalService : BaseService<VehicleRental>, IVehicleRentalService
    {
        public VehicleRentalService(IAdminInterfaces adminInterfaces) : base(adminInterfaces)
        {
        }

        public async Task<bool> Delete(VehicleRental entity)
        {
            var result = await _adminInterfaces.vehicleRentalRepository.Delete(entity);
            await _adminInterfaces.saveChangeAsync();
            return result;
        }

        public async Task<VehicleRental> Get(int id)
        {
            return await _adminInterfaces.vehicleRentalRepository.GetById(id);
        }

        public async Task<IEnumerable<VehicleRental>> Get()
        {
            return await _adminInterfaces.vehicleRentalRepository.GetAll();
        }

        public async Task<VehicleRental> Post(VehicleRental entity)
        {
           var result = await _adminInterfaces.vehicleRentalRepository.Add(entity);
            await _adminInterfaces.saveChangeAsync();
            return result;
        }

        public async Task<VehicleRental> Put(VehicleRental entity)
        {
            var result = await _adminInterfaces.vehicleRentalRepository.UpdateAsync(entity);
            await _adminInterfaces.saveChangeAsync();
            return result;
        }
    }
}
