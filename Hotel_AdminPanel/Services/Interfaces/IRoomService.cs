using Hotel_AdminPanel.Models;

namespace Hotel_AdminPanel.Services.Interfaces
{
    public interface IRoomService
    {
        Task<ICollection<Room>> GetRooomsAsync();
        Task<Room> GetRoomByIdAsync(int id);
        Task<Room> CreateRoomAsync(Room room);
        Task<Room> UpdateRoomAsync(Room room);
        Task DeleteRoomAsync(int id);

        Task<List<RoomType>> GetRoomTypesAsync();
        Task<List<RoomStatus>> GetRoomStatusesAsync();

    }
}
