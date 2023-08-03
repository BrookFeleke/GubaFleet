using System.ComponentModel.DataAnnotations;

namespace GubaFleet.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [Required]
        public string PlateNumber { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String ChassisNumber { get; set; }
        public int GroupId { get; set; }
        public int DriverId { get; set; }
    }
}
