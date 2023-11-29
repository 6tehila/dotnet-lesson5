using Hotel.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class RoomsService : IRoomsService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomsService(IRoomRepository userRepository)
        {
            _roomRepository = userRepository;
        }

        public Rooms AddRoom(Rooms room)
        {
            return _roomRepository.AddRoom(room);
        }

        public void DeleteRoom(int id)
        {
            _roomRepository.DeleteRoom(id);
        }

        public Rooms GetById(int id)
        {
            return _roomRepository.GetByIdRoom(id);
        }

        public List<Rooms> GetRooms()
        {
            return _roomRepository.GetRooms();
        }

        public Rooms UpdateRoom(Rooms room, int id)
        {
            return _roomRepository.UpdateRoom(id,room);
        }

    }
}
