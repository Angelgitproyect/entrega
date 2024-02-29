using Core.Entities;
using Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{
    public interface IAdminInterfaces : IDisposable
    {
        ICarsRepository carsRepository { get; }
        ICityRepository cityRepository { get; }
        ILocationRentalRepository locationRentalRepository { get; }
        ILocationsRepository locationsRepository { get; }
        IUserRepository userRepository { get; }
        IVehicleRentalRepository vehicleRentalRepository { get; }
        IUtilsRepository utilsRepository { get; }
        IBaseRepository<LogApplication> logApplicationRepository { get; }
        void saveChange();
        Task saveChangeAsync();
    }
}
