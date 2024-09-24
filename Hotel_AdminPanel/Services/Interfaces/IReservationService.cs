using Hotel_AdminPanel.Models;

namespace Hotel_AdminPanel.Services.Interfaces
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetReservationsAsync();
        Task<Reservation> GetReservationByIdAsync(int id);
        Task<Reservation> CreateReservationAsync(Reservation reservation);
        Task<Reservation> UpdateReservationAsync(Reservation reservation);
        Task DeleteReservationAsync(int id);
    }
}
