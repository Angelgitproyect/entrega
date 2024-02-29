namespace Core.Entities
{
    public class VehicleRental : BaseEntity
    {
        public int idCar { get; set; }
        public int idUser { get; set; }
        public  bool rented { get; set; }
        public virtual Cars? idCarsNavigation { get; set; }
        public virtual User? idUserNavigation { get; set; }

        public virtual ICollection<LocationRental>? LocationRental { get; set; }
    }
}
