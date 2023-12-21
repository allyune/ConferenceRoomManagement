using AutoMapper;
using ConferenceRoomBooking.Models;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceRoomBooking.Controllers;

public class BookingsController : Controller
{
    private readonly IBookingRepository _bookingRepository;
    private readonly IMapper _mapper;

    public BookingsController(IBookingRepository bookingRepository, IMapper mapper)
    {
        _bookingRepository = bookingRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult Details(string code)
    {
        if (code is null)
        {
            return View();
        }

        var booking = _mapper.Map<Booking>(_bookingRepository.Get(code));
        return View(booking);
    }
}
