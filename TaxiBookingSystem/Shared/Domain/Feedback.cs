namespace TaxiBookingSystem.Shared.Domain
{
    public class Feedback : BaseDomainModel
    {
        public int Rating { get; set; }
        public string FeedbackDescription { get; set; }
    }
}