using Hotel_AdminPanel.Models;

namespace Hotel_AdminPanel.Services.Interfaces
{
    public interface IRoomService
    {
        Task<List<Room>> GetRooomsAsync();
        Task<Room> GetRoomByIdAsync(int id);
        Task<Room> CreateRoomAsync(Room room);
        Task<Room> UpdateRoomAsync(Room room);
        Task DeleteRoomAsync(int id);

    }
}
