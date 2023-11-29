using Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IRoomsService
    {
        List<Rooms> GetRooms();
        Rooms GetById(int id);
        Rooms AddRoom(Rooms room);
        Rooms UpdateRoom(Rooms room, int id);
        void DeleteRoom(int id);
    }
}
