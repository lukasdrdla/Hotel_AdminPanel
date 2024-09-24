using Hotel_AdminPanel.Models;

namespace Hotel_AdminPanel.Services.Interfaces
{
    public interface IRoomStatusService
    {
        Task<List<RoomStatus>> GetRoomStatusesAsync();
    }
}
