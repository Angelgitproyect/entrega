using Core.Entities;
using Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Infrastructure.Repositories
{
    public class CarsRepository(PruebaTecnicaContext contex) : BaseRepository<Cars>(contex), ICarsRepository
    {
        public async Task<IEnumerable<Cars>> VehicleAvailable(string neighborhood)
        {
        
            return await _entities.Where(x => 
                                         x.VehicleRental.Any(x => x.rented == false 
                                         && x.LocationRental.Any(x => 
                                         x.idLocationsNavigation.name.Equals(neighborhood)))).ToListAsync();
        }
    }
}
