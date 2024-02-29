using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Service
{
    public interface IVehicleRentalService : IBaseService<VehicleRental>
    {
        Task<bool> Delete(VehicleRental entity);
        Task<VehicleRental> Get(int id);
        Task<IEnumerable<VehicleRental>> Get();
        Task<VehicleRental> Post(VehicleRental entity);
        Task<VehicleRental> Put(VehicleRental entity);
    }
}
