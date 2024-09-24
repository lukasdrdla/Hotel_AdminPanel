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

            };

            await _context.Reservations.AddAsync(newReservation);
            await _context.SaveChangesAsync();
            return newReservation;


        }

        public Task DeleteReservationAsync(int id)
        {
            throw new NotImplementedException();
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
                .ToListAsync();
            return reservations;
        }

        public Task<Reservation> UpdateReservationAsync(Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}
