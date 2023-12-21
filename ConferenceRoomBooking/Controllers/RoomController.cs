using AutoMapper;
using ConferenceRoomBooking.Models;
using Data.Interfaces;
using Data.Models;
using ConferenceRoomBooking.ViewModels;
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

        public IActionResult ListAllRooms(int? maxCapacity)
        {
            var allRooms = _roomRepository.ListAll();

            if (maxCapacity is not null && maxCapacity > 0)
            {
                var roomsSuitableCapacity = allRooms.Where(room => room.MaximumCapacity >= maxCapacity).ToList();
                var roomModels = roomsSuitableCapacity.Select(room => _mapper.Map<ConferenceRoom>(room)).ToList();
                return View(new RoomListingViewModel() { ConferenceRooms = roomModels });
            }
            else
            {
                var roomModels = allRooms.Select(room => _mapper.Map<ConferenceRoom>(room)).ToList();
                return View(new RoomListingViewModel() { ConferenceRooms = roomModels });
            }
            
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
