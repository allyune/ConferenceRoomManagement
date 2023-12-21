using ConferenceRoomBooking.Models;

namespace ConferenceRoomBooking.ViewModels
{
    public class RoomListingViewModel
    {
        public List<ConferenceRoom> ConferenceRooms { get; set; }
        public int MaxCapacitySelected { get; set; } = 1;
    }
}
