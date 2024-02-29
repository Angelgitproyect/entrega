using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cars : BaseEntity
    {
        public required string plate { get; set; }
        public required string plateCity { get; set; }
        public required string brand { get; set; }
        public virtual ICollection<VehicleRental>? VehicleRental { get; set; }
    }
}
