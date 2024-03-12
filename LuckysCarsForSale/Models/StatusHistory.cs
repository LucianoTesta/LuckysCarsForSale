using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LuckysCarsForSale.Models
{
    public class StatusHistory
    {
        [Key]
        public int StatusHistoryId { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }

        [ForeignKey("Status")]
        public int StatusId { get; set; }
        public Status Status { get; set; }

        public DateTime StatusDate { get; set; }
    }
}
