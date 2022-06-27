namespace eShop.API.Presentler.Contracts
{
    public class NewProductContract
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string PictureUrl { get; set; }
        public double Mark { get; set; }
    }
}
