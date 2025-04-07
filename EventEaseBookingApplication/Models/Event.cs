using System.ComponentModel.DataAnnotations;
namespace EventEaseBookingApplication.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [Required]
        public string ?EventName { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        public string? Description { get; set; }

        [Required]
        public int? VenueID { get; set; } // Nullable for pre-assigned venue

        public Venue ?Venue { get; set; } // Navigation Property
        public List<Booking> Bookings { get; set; } =new();// Navigation Property
    }
}
