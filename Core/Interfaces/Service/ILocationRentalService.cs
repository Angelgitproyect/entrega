using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Service
{
    public interface ILocationRentalService : IBaseService<LocationRental>
    {
        Task<bool> Delete(LocationRental entity);
        Task<LocationRental> Get(int id);
        Task<IEnumerable<LocationRental>> Get();
        Task<LocationRental> Post(LocationRental entity);
        Task<LocationRental> Put(LocationRental entity);
    }
}
