using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Models;
using Unicom.DB.Service;

namespace Unicom.DB.Controller
{
    internal class RoomController
    {
        private readonly RoomService _roomService;

        public RoomController()
        {
            _roomService = new RoomService();
        }

        public List<Room> GetAllRooms() => _roomService.GetAll();

        public void AddRoom(Room room) => _roomService.Add(room);

        public void UpdateRoom(Room room) => _roomService.Update(room);

        public void DeleteRoom(int roomId) => _roomService.Delete(roomId);
    }
}
