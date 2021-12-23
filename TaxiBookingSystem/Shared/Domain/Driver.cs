using System;
using System.Collections.Generic;

namespace TaxiBookingSystem.Shared.Domain
{
    public class Driver : BaseDomainModel
    {
        public string Name { get; set; }
        public int ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public float AvgRating { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}