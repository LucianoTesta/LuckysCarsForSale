using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LuckysCarsForSale.Models
{
    public class Quote
    {
        [Key]
        public int QuoteId { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }

        [ForeignKey("Buyer")]
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }

        public decimal Amount { get; set; }

        public bool IsCurrent { get; set; }
    }
}
