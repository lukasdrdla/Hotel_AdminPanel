using Hotel_AdminPanel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Application.Interfaces
{
    public interface IRoomService
    {
        Task<List<Room>> GetRooomsAsync();
        Task<Room> GetRoomByIdAsync(int id);
        Task CreateRoomAsync(Room room);
        Task UpdateRoomAsync(Room room);
        Task DeleteRoomAsync(int id);

        //RoomType
        Task<List<RoomType>> GetRoomTypesAsync();
        Task CreateRoomTypeAsync(RoomType roomType);
        Task UpdateRoomTypeAsync(RoomType roomType);
        Task DeleteRoomTypeAsync(int id);

        //RoomStatus
        Task<List<RoomStatus>> GetRoomStatusesAsync();
        Task CreateRoomStatusAsync(RoomStatus roomStatus);
        Task DeleteRoomStatusAsync(int id);
        Task UpdateRoomStatusBySettingsAsync(RoomStatus roomStatus);
        Task UpdateRoomStatusAsync(int roomId, int statusId);
    }
}
