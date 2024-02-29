using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class LocationRentalDto
    {
        [Required]
        public int idVehicleRental { get; set; }
        [Required]
        public int idLocations { get; set; }
    }
}
