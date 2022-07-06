namespace Product_Management_Microservice.Model
{
    public class AppProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
       public string Make { get; set; }
        public string Model { get; set; }
        public double Cost { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
