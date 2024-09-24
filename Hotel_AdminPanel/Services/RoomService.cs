using Hotel_AdminPanel.Data;
using Hotel_AdminPanel.Models;
using Hotel_AdminPanel.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hotel_AdminPanel.Services
{
    public class RoomService : IRoomService
    {

        private readonly ApplicationDbContext _context;

        public RoomService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<Room> CreateRoomAsync(Room room)
        {
            var newRoom = new Room
            {
                RoomNumber = room.RoomNumber,
                RoomType = room.RoomType,
                Price = room.Price,
                Description = room.Description,
            };

            await _context.Rooms.AddAsync(newRoom);
            await _context.SaveChangesAsync();
            return newRoom;



        }

        public async Task DeleteRoomAsync(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                throw new Exception("Room not found");
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

        }

        public async Task<Room> GetRoomByIdAsync(int id)
        {
            var room = await _context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.RoomStatus)
                .FirstOrDefaultAsync(r => r.Id == id);
            if (room == null) {
                throw new Exception("Room not found");
            }
            return room;
        }

        public async Task<List<Room>> GetRooomsAsync()
        {
            var rooms = await _context.Rooms.
                Include(r => r.RoomType)
                .Include(r => r.RoomStatus)
                .ToListAsync();
            return rooms;
        }

        public async Task<Room> UpdateRoomAsync(Room room)
        {
            var existingRoom = await _context.Rooms.FindAsync(room.Id);
            if (existingRoom == null)
            {
                throw new Exception("Room not found");
            }

            existingRoom.RoomNumber = room.RoomNumber;
            existingRoom.RoomType = room.RoomType;
            existingRoom.Price = room.Price;
            existingRoom.Description = room.Description;
            

            await _context.SaveChangesAsync();
            return existingRoom;


        }
    }
}
