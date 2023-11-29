using Hotel.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class RoomsRepository : IRoomRepository
    {
        private readonly DataContext _context;

        public RoomsRepository(DataContext context)
        {
            _context = context;
        }
        public Rooms AddRoom(Rooms room)
        {
            _context.roomList.Add(room);
            return room;
        }

        public void DeleteRoom(int idRoom)
        {
            _context.roomList.Remove(_context.roomList.Find(u => u.idRoom == idRoom));

        }

        public Rooms GetByIdRoom(int idRoom)
        {
            return _context.roomList.Find(u => u.idRoom == idRoom);

        }

        public List<Rooms> GetRooms()
        {
            return _context.roomList;
        }

        public Rooms UpdateRoom(int idRoom, Rooms room)
        {
            var updateRoom = _context.roomList.Find(r => r.idRoom == idRoom);
            if (updateRoom != null)
            {
                updateRoom.IsFilled = room.IsFilled;
                updateRoom.numOfBeds = room.numOfBeds;
                updateRoom.idRoom=room.idRoom;
                return updateRoom;
            }
            return null;
        }
    }
}
