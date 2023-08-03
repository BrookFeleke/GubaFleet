using System.ComponentModel.DataAnnotations;

namespace GubaFleet.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        [Required]
        public int VehicleId { get; set; }
        [Required]
        public int DriverId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public String BookingStatus { get; set; }
        [Required]
        public String PaymentStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public String Remarks { get; set; }
    }
}
