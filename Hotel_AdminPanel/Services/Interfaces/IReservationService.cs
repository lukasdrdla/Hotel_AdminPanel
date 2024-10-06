using Hotel_AdminPanel.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_AdminPanel.Services.Interfaces
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetReservationsAsync();
        Task<Reservation> GetReservationByIdAsync(int id);
        Task CreateReservationAsync(Reservation reservation);
        Task UpdateReservationAsync(Reservation reservation);
        Task DeleteReservationAsync(int id);
        Task<List<MealPlan>> GetMealPlansAsync();
        Task<List<ReservationStatus>> GetReservationStatusesAsync();

        //GetUnavailableDatesForRoomAsync
        Task<bool> IsRoomAvailableAsync(int roomId, DateTime checkIn, DateTime checkOut);
        Task<List<string>> GetUnavailableDatesForRoomAsync(int roomId);




    }
        
}
