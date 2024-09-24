using Hotel_AdminPanel.Data;
using Hotel_AdminPanel.Models;
using Hotel_AdminPanel.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hotel_AdminPanel.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly ApplicationDbContext _context;

        public RoomTypeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<RoomType>> GetAllRoomTypesAsync()
        {
            var roomTypes = await _context.RoomTypes.ToListAsync();
            return roomTypes;
        }
    }
}
