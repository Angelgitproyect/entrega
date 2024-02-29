
using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class CarsDto : BaseDto
    {
        [Required]
        public required string plate { get; set; }
        [Required]
        public required string plateCity { get; set; }
        [Required]
        public required string brand { get; set; }
    }
}
