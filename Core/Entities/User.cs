using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User : BaseEntity
    {
        public required string name { get; set; }
        public required long dni { get; set; }
        public virtual ICollection<VehicleRental>? VehicleRental { get; set; }
    }
}
