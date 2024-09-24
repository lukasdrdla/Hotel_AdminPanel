using Hotel_AdminPanel.Models;

namespace Hotel_AdminPanel.Services.Interfaces
{
    public interface IRoomTypeService
    {
        Task<List<RoomType>> GetAllRoomTypesAsync();
    }
}
