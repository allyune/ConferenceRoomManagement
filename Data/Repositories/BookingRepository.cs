using Data.Interfaces;
using Data.Models;

namespace Data.Repositories;

public class BookingRepository : IBookingRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public BookingRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public Booking? Get(string code)
    {
        return _applicationDbContext.Bookings.SingleOrDefault(b => b.Code == code);
    }

    public IEnumerable<Booking> GetAll()
    {
        return _applicationDbContext.Bookings;
    }
}
