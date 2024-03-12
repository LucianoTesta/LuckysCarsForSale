using System.ComponentModel.DataAnnotations;

namespace LuckysCarsForSale.Models
{
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }

        public string BuyerName { get; set; }

        public string BuyerZipCode { get; set; }

        public List<Quote> Quotes { get; set; }
    }
}
