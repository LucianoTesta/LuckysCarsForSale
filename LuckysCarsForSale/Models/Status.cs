using System.ComponentModel.DataAnnotations;

namespace LuckysCarsForSale.Models
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }

        public string StatusName { get; set; }

        public List<StatusHistory> StatusHistory { get; set; }
    }
}
