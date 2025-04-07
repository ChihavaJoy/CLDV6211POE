using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace EventEaseBookingApplication.Models
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
            
            public DbSet<Venue> Venues { get; set; }
            public DbSet<Event> Event { get; set; }
            public DbSet<Booking> Booking { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Prevent double bookings (same venue + event)
            modelBuilder.Entity<Booking>()
                .HasIndex(b => new { b.VenueID, b.EventID })
                .IsUnique();

            // Prevent deleting a Venue if it has associated Bookings
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Venue)
                .WithMany(v => v.Bookings)
                .HasForeignKey(b => b.VenueID)
                .OnDelete(DeleteBehavior.Restrict);

            // Prevent deleting an Event if it has associated Bookings
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Event)
                .WithMany(e => e.Bookings)
                .HasForeignKey(b => b.EventID)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
