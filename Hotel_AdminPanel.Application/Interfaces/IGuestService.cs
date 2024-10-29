using Hotel_AdminPanel.Domain.Entities;

namespace Hotel_AdminPanel.Application.Interfaces
{
    public interface IGuestService
    {
        Task<List<Guest>> GetGuestsAsync();
        Task<Guest> GetGuestAsync(int id);
        Task<Guest> CreateGuestAsync(Guest guestDto);
        Task UpdateGuestAsync(Guest guestDto);
        Task DeleteGuestAsync(int id);
    }
}
