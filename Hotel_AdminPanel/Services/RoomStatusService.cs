using Hotel_AdminPanel.Data;
using Hotel_AdminPanel.Models;
using Hotel_AdminPanel.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hotel_AdminPanel.Services
{
    public class RoomStatusService : IRoomStatusService
    {
        private readonly ApplicationDbContext _context;

        public RoomStatusService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<RoomStatus>> GetRoomStatusesAsync()
        {
            var roomStatuses = await _context.RoomStatuses.ToListAsync();
            return roomStatuses;
        }
    }
}
