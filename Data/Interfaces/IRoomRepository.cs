using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IRoomRepository
    {
        public List<Room> ListAll();
        public Room GetRoom(int id);
    }
}
