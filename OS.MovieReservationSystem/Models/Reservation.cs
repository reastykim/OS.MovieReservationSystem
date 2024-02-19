namespace OS.MovieReservationSystem.Models
{
    public class Reservation(Customer customer, Screening screening, Money fee, int audienceCount)
    {
        public Customer Customer { get; } = customer;
        public Screening Screening { get; } = screening;
        public Money Fee { get; } = fee;
        public int AudienceCount { get; } = audienceCount;
    }
}
