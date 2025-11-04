namespace MikroservisStock.Cargo.Entites
{
    public class CargoDetail
    {
        public int CargoDetailId { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public string SenderCity { get; set; }
        public string ReceiverCity { get; set; }
        public decimal Price { get; set; }
        public List<CargoProcess> CargoProcesses { get; set; }
    }
}
