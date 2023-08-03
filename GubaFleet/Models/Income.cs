using System.ComponentModel.DataAnnotations;

namespace GubaFleet.Models
{
    public class Income
    {
        [Key]
        public int IncomeId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public String Description { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public String Category { get; set; }
    }
}
