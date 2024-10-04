using Hotel_AdminPanel.Data;
using Hotel_AdminPanel.Models;
using Hotel_AdminPanel.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hotel_AdminPanel.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ApplicationDbContext _context;

        public ReservationService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Reservation> CreateReservationAsync(Reservation reservation)
        {
            var newReservation = new Reservation
            {
                CustomerId = reservation.CustomerId,
                RoomId = reservation.RoomId,
                CheckIn = reservation.CheckIn,
                CheckOut = reservation.CheckOut,
                TotalPrice = reservation.TotalPrice,
                MealPlanId = reservation.MealPlanId,
                ReservationStatusId = reservation.ReservationStatusId,
                Adults = reservation.Adults,
                Children = reservation.Children,
                SpecialRequest = reservation.SpecialRequest

            };

            await _context.Reservations.AddAsync(newReservation);
            await _context.SaveChangesAsync();
            return newReservation;


        }

        public Task DeleteReservationAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MealPlan>> GetMealPlansAsync()
        {
            var mealPlans = await _context.MealPlans.ToListAsync();
            return mealPlans;
        }

        public Task<Reservation> GetReservationByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Reservation>> GetReservationsAsync()
        {
            var reservations = await _context.Reservations
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Include(r => r.MealPlan)
                .Include(r => r.ReservationStatus)
                .ToListAsync();
            return reservations;
        }

        public async Task<List<ReservationStatus>> GetReservationStatusesAsync()
        {
            var reservationStatuses = await _context.ReservationStatuses.ToListAsync();
            return reservationStatuses;
        }

        public async Task<bool> IsRoomAvailableAsync(int roomId, DateTime checkIn, DateTime checkOut)
        {
            // Získejte všechny rezervace pro daný pokoj
            var reservations = await _context.Reservations
                .Where(r => r.RoomId == roomId)
                .ToListAsync();

            // Zkontrolujte, zda je pokoj obsazen v daném období
            return reservations.All(reservation =>
                reservation.CheckOut <= checkIn || reservation.CheckIn >= checkOut);
        }

        public Task<Reservation> UpdateReservationAsync(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public async Task<List<string>> GetUnavailableDatesForRoomAsync(int roomId)
        {
            // Získání rezervací pro zvolený pokoj
            var reservations = await _context.Reservations
                .Where(r => r.RoomId == roomId)
                .ToListAsync();

            // Předpokládáme, že každá rezervace má CheckIn a CheckOut
            var unavailableDates = new List<string>();

            foreach (var reservation in reservations)
            {
                var checkInDate = reservation.CheckIn.Date;
                var checkOutDate = reservation.CheckOut.Date;

                // Přidání každého dne mezi CheckIn a CheckOut do seznamu nedostupných dat
                for (var date = checkInDate; date < checkOutDate; date = date.AddDays(1))
                {
                    unavailableDates.Add(date.ToString("yyyy-MM-dd")); // Přidejte datum v požadovaném formátu
                }
            }

            return unavailableDates;
        }
    }
}
