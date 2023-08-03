using System.ComponentModel.DataAnnotations;

namespace GubaFleet.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        [Required]
        public String Name { get; set; }
    }
}
