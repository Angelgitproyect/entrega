using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class City : BaseEntity
    {
        public required string name { get; set; }
        public virtual ICollection<Locations>? Locations { get; set; }
    }
}
