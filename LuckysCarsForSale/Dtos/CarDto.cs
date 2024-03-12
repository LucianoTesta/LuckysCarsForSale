namespace LuckysCarsForSale.Dtos
{
    public class CarDTO
    {
        public int CarYear { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Submodel { get; set; }
        public string CarLocation { get; set; }
        public string CurrentBuyerName { get; set; }
        public decimal? CurrentQuote { get; set; }
        public string CurrentStatus { get; set; }
        public DateTime? StatusDate { get; set; }
    }
}
