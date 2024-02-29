using Core.Entities;
using Core.Interfaces.Repository;
using Core.Interfaces.Service;
using Persistence.DataContext;

namespace Infrastructure.Repositories
{
    public class AdminInterfaces : IAdminInterfaces
    {
        public PruebaTecnicaContext _context;
        public AdminInterfaces(PruebaTecnicaContext context)
        {
            _context = context;
        }
        private readonly ICarsRepository _carsRepository;
        private readonly ICityRepository _cityRepository;
        private readonly ILocationRentalRepository _locationRentalRepository;
        private readonly ILocationsRepository _locationsRepository;
        private readonly IUserRepository _userRepository;
        private readonly IVehicleRentalRepository _vehicleRentalRepository;
        private readonly IUtilsRepository _utilsRepository;
        private readonly IBaseRepository<LogApplication> _logApplicationRepository;

        public ICarsRepository carsRepository => _carsRepository ?? new CarsRepository(_context);

        public ICityRepository cityRepository => _cityRepository ?? new CityRepository(_context);

        public ILocationRentalRepository locationRentalRepository => _locationRentalRepository ?? new LocationRentalRepository(_context);

        public ILocationsRepository locationsRepository => _locationsRepository ?? new LocationsRepository(_context);

        public IUserRepository userRepository => _userRepository ?? new UserRepository(_context);

        public IVehicleRentalRepository vehicleRentalRepository => _vehicleRentalRepository ?? new VehicleRentalRepository(_context);

        public IBaseRepository<LogApplication> logApplicationRepository => _logApplicationRepository ?? new LogApplicationRepository(_context);

        public IUtilsRepository utilsRepository => _utilsRepository ?? new UtilsRepository();

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void saveChange()
        {
            _context.SaveChanges();
        }
        public async Task saveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
