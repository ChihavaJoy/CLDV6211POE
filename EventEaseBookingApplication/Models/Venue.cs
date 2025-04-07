using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EventEaseBookingApplication.Models
{
    [Table("Venue")] // <- This tells EF to use the table named 'Venue'

    public class Venue
    {
        [Key]
        public int VenueID { get; set; }

        [Required]
        public string? VenueName { get; set; }

        [Required]
        public string? Location { get; set; }

        [Required]
     
        public int Capacity { get; set; }

        public string? ImageURL { get; set; }

        public List<Booking> Bookings { get; set; } = new();// Navigation Property 
    }
}
