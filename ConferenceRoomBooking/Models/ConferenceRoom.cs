namespace ConferenceRoomBooking.Models
{
    public class ConferenceRoom
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int MaximumCapacity { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
