using AutoMapper;
using ConferenceRoomBooking.Models;
using Data.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConferenceRoomBooking.Controllers
{
    public class RoomController : Controller
    {
        private readonly ILogger<RoomController> _logger;
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;

        public RoomController(
            ILogger<RoomController> logger, IRoomRepository repository, IMapper mapper)
        {
            _logger = logger;
            _roomRepository = repository;
            _mapper = mapper;
        }

        public IActionResult ListAllRooms()
        {
            var allRooms = _roomRepository.ListAll();
            var roomModels = allRooms.Select(room => _mapper.Map<ConferenceRoom>(room)).ToList();
            return View(roomModels);
        }

        public IActionResult RoomInfo(int id)
        {
            var room = _mapper.Map<ConferenceRoom>(_roomRepository.GetRoom(id));
            return View(room);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
