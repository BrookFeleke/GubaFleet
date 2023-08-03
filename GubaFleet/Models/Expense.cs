using System.ComponentModel.DataAnnotations;

namespace GubaFleet.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public String Description { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public String Category { get; set; }
    }
}
