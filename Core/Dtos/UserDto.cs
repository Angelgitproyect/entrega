using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class UserDto
    {
        [Required]
        public required string name { get; set; }
        [Required]
        public required long dni { get; set; }
    }
}
