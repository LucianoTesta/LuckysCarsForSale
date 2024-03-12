using System.ComponentModel.DataAnnotations;

namespace LuckysCarsForSale.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        public int CarYear { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Submodel { get; set; }

        public string CarZipCode { get; set; }

        public List<Quote> Quotes { get; set; }

        public List<StatusHistory> StatusHistory { get; set; }
    }
}
