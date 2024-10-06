using Hotel_AdminPanel.Models;

namespace Hotel_AdminPanel.Services.Interfaces
{
    public interface IRoomService
    {
        Task<ICollection<Room>> GetRooomsAsync();
        Task<Room> GetRoomByIdAsync(int id);
        Task CreateRoomAsync(Room room);
        Task UpdateRoomAsync(Room room);
        Task DeleteRoomAsync(int id);

        Task<List<RoomType>> GetRoomTypesAsync();
        Task<List<RoomStatus>> GetRoomStatusesAsync();
        Task UpdateRoomStatusAsync(int roomId, int statusId);

    }
}
