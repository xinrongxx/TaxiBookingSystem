namespace TaxiBookingSystem.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ContactNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}