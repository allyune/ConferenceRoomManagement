using Data.Models;

namespace Data.Interfaces;

public interface IBookingRepository
{
    IEnumerable<Booking> GetAll();
    Booking? Get(string code);
}
