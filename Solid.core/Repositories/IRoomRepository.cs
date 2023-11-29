using Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IRoomRepository
    {
        List<Rooms> GetRooms();

        Rooms GetByIdRoom(int idRoom);

        Rooms AddRoom(Rooms room);

        Rooms UpdateRoom(int idRoom, Rooms room);

        void DeleteRoom(int idRoom);
    }
}
