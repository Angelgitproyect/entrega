using Core.Entities;
using Core.Interfaces.Repository;
using Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class LocationRentalService : BaseService<LocationRental>, ILocationRentalService
    {
        public LocationRentalService(IAdminInterfaces adminInterfaces) : base(adminInterfaces)
        {
        }

        public async Task<bool> Delete(LocationRental entity)
        {
            var result = await _adminInterfaces.locationRentalRepository.Delete(entity);
            await _adminInterfaces.saveChangeAsync();
            return result;
        }

        public async Task<LocationRental> Get(int id)
        {
            return await _adminInterfaces.locationRentalRepository.GetById(id);
        }

        public async Task<IEnumerable<LocationRental>> Get()
        {
            return await _adminInterfaces.locationRentalRepository.GetAll();
        }

        public async Task<LocationRental> Post(LocationRental entity)
        {
            var result = await _adminInterfaces.locationRentalRepository.Add(entity);
            await _adminInterfaces.saveChangeAsync();
            return result;
        }

        public async Task<LocationRental> Put(LocationRental entity)
        {
            var result = await _adminInterfaces.locationRentalRepository.UpdateAsync(entity);
            await _adminInterfaces.saveChangeAsync();
            return result;
        }
    }
}
