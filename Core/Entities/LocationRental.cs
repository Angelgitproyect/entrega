
namespace Core.Entities
{
    public class LocationRental : BaseEntity
    { 
        public int idVehicleRental { get; set; } 
        public int idLocations { get; set; } 
        public virtual VehicleRental? idVehiclerentalNavigation { get; set; }
        public virtual Locations? idLocationsNavigation { get; set; }
    }
}
