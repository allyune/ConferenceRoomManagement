using ConferenceRoomBooking.Models;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConferenceRoomBooking.Controllers
{
    public class RoomController : Controller
    {
        private readonly ILogger<RoomController> _logger;
        private readonly IRoomRepository _roomRepository;

        public RoomController(
            ILogger<RoomController> logger, IRoomRepository repository)
        {
            _logger = logger;
            _roomRepository = repository;
        }

        public IActionResult ListAllRooms()
        {
            var allRooms = _roomRepository.ListAllRooms();
            return View(allRooms);
        }

        public IActionResult RoomInfo()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
