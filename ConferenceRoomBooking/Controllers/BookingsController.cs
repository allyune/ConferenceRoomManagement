using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceRoomBooking.Controllers;

public class BookingsController : Controller
{
    private readonly IBookingRepository _bookingRepository;

    public BookingsController(IBookingRepository bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }

    [HttpGet]
    public IActionResult Details(string code)
    {
        if (code is null)
        {
            return View();
        }

        return View(_bookingRepository.Get(code));
    }
}
