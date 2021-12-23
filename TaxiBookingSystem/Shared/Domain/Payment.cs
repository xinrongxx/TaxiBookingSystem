using System;

namespace TaxiBookingSystem.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public float Amount { get; set; }
        public string Type { get; set; }
    }
}