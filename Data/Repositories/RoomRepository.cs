using Data.Interfaces;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public RoomRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public Room? GetRoom(int id)
        {
            return _dbContext.Rooms
                .Include(r => r.Bookings)
                .Where(r => r.Id == id)
                .FirstOrDefault();
        }

        public List<Room> ListAll()
        {
            return _dbContext.Rooms.ToList();
        }
    }
}
