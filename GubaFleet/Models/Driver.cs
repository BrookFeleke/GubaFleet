using System.ComponentModel.DataAnnotations;

namespace GubaFleet.Models
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String LicenseNumber { get; set; }
        public String ContactInformation { get; set; }
    }
}
