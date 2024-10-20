using Hotel_AdminPanel.Application.Interfaces;
using Hotel_AdminPanel.Domain.Entities;
using Hotel_AdminPanel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Hotel_AdminPanel.Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly ApplicationDbContext _context;

        public RoomService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task CreateRoomAsync(Room room)
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



        }

        public async Task CreateRoomStatusAsync(RoomStatus roomStatus)
        {
            var newRoomStatus = new RoomStatus
            {
                Status = roomStatus.Status
            };


            await _context.RoomStatuses.AddAsync(newRoomStatus);
            await _context.SaveChangesAsync();

        }

        public async Task CreateRoomTypeAsync(RoomType roomType)
        {
            var newRoomType = new RoomType
            {
                Type = roomType.Type
            };

            await _context.RoomTypes.AddAsync(newRoomType);
            await _context.SaveChangesAsync();

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

        public async Task DeleteRoomStatusAsync(int id)
        {
            var roomStatus = await _context.RoomStatuses.FindAsync(id);

            if (roomStatus == null)
            {
                throw new Exception("Room status not found");
            }

            _context.RoomStatuses.Remove(roomStatus);
            await _context.SaveChangesAsync();


        }

        public async Task DeleteRoomTypeAsync(int id)
        {
            var roomType = await _context.RoomTypes.FindAsync(id);
            if (roomType == null)
            {
                throw new Exception("Room type not found");
            }

            _context.RoomTypes.Remove(roomType);
            await _context.SaveChangesAsync();
        }

        public async Task<Room> GetRoomByIdAsync(int id)
        {
            var room = await _context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.RoomStatus)
                .FirstOrDefaultAsync(r => r.Id == id);
            if (room == null)
            {
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

        public async Task<List<Room>> GetRooomsAsync()
        {
            var rooms = await _context.Rooms.
                Include(r => r.RoomType)
                .Include(r => r.RoomStatus)
                .ToListAsync();
            return rooms;
        }

        public async Task UpdateRoomAsync(Room room)
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

        }

        public async Task UpdateRoomStatusAsync(int roomId, int statusId)
        {
            var room = await _context.Rooms.FindAsync(roomId);
            if (room == null)
            {
                throw new Exception("Room not found");
            }

            room.RoomStatusId = statusId;
            await _context.SaveChangesAsync();


        }

        public async Task UpdateRoomStatusBySettingsAsync(RoomStatus roomStatus)
        {
            var exisingRoomStatus = await _context.RoomStatuses.FindAsync(roomStatus.Id);

            if (exisingRoomStatus == null)
            {
                throw new Exception("Room status not found");
            }

            exisingRoomStatus.Status = roomStatus.Status;

            await _context.SaveChangesAsync();

        }

        public async Task UpdateRoomTypeAsync(RoomType roomType)
        {
            var existingRoomType = await _context.RoomTypes.FindAsync(roomType.Id);
            if (existingRoomType == null)
            {
                throw new Exception("Room type not found");
            }

            existingRoomType.Type = roomType.Type;

            await _context.SaveChangesAsync();


        }
    }
}
