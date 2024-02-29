using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class VehicleRentalDto
    {
        [Required]
        public int idCar { get; set; }
        [Required]
        public int idUser { get; set; }
        [Required]
        public bool rented { get; set; }
    }
}
