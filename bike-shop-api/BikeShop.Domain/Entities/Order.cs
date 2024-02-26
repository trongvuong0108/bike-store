namespace BikeShop.Domain.Entities
{
    public class Order
    {
        public DateTime Create { get; set; } = DateTime.Now;
        public DateTime Update { get; set; } = DateTime.Now;
    }
}
