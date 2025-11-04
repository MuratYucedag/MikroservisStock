namespace MikroservisStock.Cargo.Entites
{
    public class CargoProcess
    {
        public int CargoProcessId { get; set; }
        public string Description { get; set; }
        public DateTime ProcessDate { get; set; }
        public string ProcessTime { get; set; }
        public int CargoDetailId { get; set; }
        public CargoDetail CargoDetail { get; set; }
    }
}
