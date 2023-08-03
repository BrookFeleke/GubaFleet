using System.ComponentModel.DataAnnotations;

namespace GubaFleet.Models
{
    public class SparePart
    {
        [Key]
        public int SparePartId { get; set; }
        [Required]
        public string SparePartName { get; set; }
        [Required]
        public String SparePartNumber { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
