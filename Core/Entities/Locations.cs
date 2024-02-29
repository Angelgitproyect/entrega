
namespace Core.Entities
{
    public class Locations : BaseEntity
    {
        public required int idCity { get; set; }
        public required string name { get; set; }
        public required Decimal latitud { get; set; }
        public required Decimal longitude { get; set; }
        public virtual City? idCityNavigation { get; set; }
        public virtual ICollection<LocationRental>? LocationRental { get; set; }
    }
}
