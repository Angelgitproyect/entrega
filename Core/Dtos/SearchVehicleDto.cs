
using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class SearchVehicleDto
    {
        [Required]
        public required decimal latitud { get; set; }
        [Required]
        public required decimal longitude { get; set; }
    }
}
