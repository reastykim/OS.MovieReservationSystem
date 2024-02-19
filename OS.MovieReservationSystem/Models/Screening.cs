namespace OS.MovieReservationSystem.Models
{
    public class Screening(Movie movie, int sequence, DateTime whenScreened)
    {
        public Movie Movie { get; } = movie;
        public int Sequence { get; } = sequence;
        public DateTime WhenScreened { get; } = whenScreened;
    }
}
