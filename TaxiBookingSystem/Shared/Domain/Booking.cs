using System;

namespace TaxiBookingSystem.Shared.Domain
{
    public class Booking : BaseDomainModel 
    {
        public string PickupPoint { get; set; }
        public string DropoffPoint { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int FeedbackId { get; set; }
        public virtual Feedback Feedback { get; set; }
        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
    }
}