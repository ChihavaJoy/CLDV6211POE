using System.ComponentModel.DataAnnotations;
namespace EventEaseBookingApplication.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        public int EventID { get; set; }

        [Required]
        public int VenueID { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        public Event? Event { get; set; }// Navigation Property
        public Venue? Venue { get; set; } // Navigation Property
    }
}
