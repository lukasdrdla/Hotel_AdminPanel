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
                Image = room.Image,
                RoomNumber = room.RoomNumber,
                RoomTypeId = room.RoomTypeId,
                RoomStatusId = room.RoomStatusId,
                Price = room.Price,
                MaxAdults = room.MaxAdults,
                MaxChildren = room.MaxChildren,
                Description = room.Description
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

        public async Task<List<RoomStatus>> GetRoomStatusesAsync()
        {
            var roomStatuses = await _context.RoomStatuses.ToListAsync();
            return roomStatuses;
        }

        public async Task<List<RoomType>> GetRoomTypesAsync()
        {
            var roomTypes = await _context.RoomTypes.ToListAsync();
            return roomTypes;
        }

        public async Task<ICollection<Room>> GetRooomsAsync()
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
            existingRoom.RoomTypeId = room.RoomTypeId;
            existingRoom.RoomStatusId = room.RoomStatusId;
            existingRoom.Price = room.Price;
            existingRoom.MaxAdults = room.MaxAdults;
            existingRoom.MaxChildren = room.MaxChildren;
            existingRoom.Description = room.Description;

            await _context.SaveChangesAsync();
            return existingRoom;


        }
    }
}
