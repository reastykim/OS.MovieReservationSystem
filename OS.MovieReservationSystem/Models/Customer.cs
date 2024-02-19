namespace OS.MovieReservationSystem.Models
{
    public class Customer(string id, string name)
    {
        public string Id { get; } = id;
        public string Name { get; } = name;
    }
}
