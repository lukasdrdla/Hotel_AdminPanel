using Hotel_AdminPanel.Application.Interfaces;
using Hotel_AdminPanel.Domain.Entities;
using Hotel_AdminPanel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Hotel_AdminPanel.Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ApplicationDbContext _context;

        public ReservationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> IsRoomAvailableAsync(int roomId, DateTime checkIn, DateTime checkOut)
        {
            var reservations = await _context.Reservations
                .Where(r => r.RoomId == roomId &&
                            (r.CheckIn < checkOut && r.CheckOut > checkIn))
                .ToListAsync();

            return !reservations.Any();
        }



        public async Task CreateReservationAsync(Reservation reservation)
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
                SpecialRequest = reservation.SpecialRequest,
                AdminNote = reservation.AdminNote,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Guests = reservation.Guests

            };

            await _context.Reservations.AddAsync(newReservation);
            await _context.SaveChangesAsync();


        }


        public async Task<List<MealPlan>> GetMealPlansAsync()
        {
            var mealPlans = await _context.MealPlans.ToListAsync();
            return mealPlans;
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



        public async Task<Reservation> GetReservationByIdAsync(int id)
            {
            var reservation = await _context.Reservations
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Include(r => r.MealPlan)
                .Include(r => r.ReservationStatus).FirstOrDefaultAsync(r => r.Id == id);

            return reservation;

        }

        public Task UpdateReservationAsync(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteReservationAsync(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);

            if (reservation == null)
            {
                throw new InvalidOperationException("Reservation not found");
            }
            else
            {
                _context.Reservations.Remove(reservation);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<List<Reservation>> GetReservationsByCustomerIdAsync(int customerId)
        {
            var reservations = await _context.Reservations
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Include(r => r.MealPlan)
                .Include(r => r.ReservationStatus)
                .Where(r => r.CustomerId == customerId)
                .ToListAsync();
            return reservations;
        }

        public async Task<List<DateTime>> GetOccupiedDatesForRoomAsync(int roomId)
        {
            var reservations = await _context.Reservations
                .Where(r => r.RoomId == roomId)
                .ToListAsync();

            var occupiedDates = new List<DateTime>();

            foreach (var reservation in reservations)
            {
                var dates = Enumerable.Range(0, (int)(reservation.CheckOut - reservation.CheckIn).TotalDays)
                    .Select(i => reservation.CheckIn.AddDays(i))
                    .ToList();

                occupiedDates.AddRange(dates);
            }

            return occupiedDates;

        }

        public Task CreateMealPlanAsync(MealPlan mealPlan)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateMealPlanAsync(MealPlan mealPlan)
        {
            var exisitngMealPlan = await _context.MealPlans.FirstOrDefaultAsync(mp => mp.Id == mealPlan.Id);

            if (exisitngMealPlan == null)
            {
                throw new InvalidOperationException("Meal Plan not found");
            }

            else
            {
                exisitngMealPlan.Name = mealPlan.Name;
                exisitngMealPlan.Price = mealPlan.Price;

                await _context.SaveChangesAsync();

            }
        }

        public async Task DeleteMealPlanAsync(int id)
        {
            var mealPlan = await _context.MealPlans.FindAsync(id);
            if (mealPlan == null)
            {
                throw new InvalidOperationException("Meal Plan not found");
            }
            else
            {
                _context.MealPlans.Remove(mealPlan);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Guest>> GetGuestsByReservationIdAsync(int reservationId)
        {
            var guests = await _context.Guests
                .Where(g => g.ReservationId == reservationId)
                .ToListAsync();
            return guests;
        }


        public async Task<List<int>> GetMonthlyReservations()
        {
            var reservationsByMonth = new List<int>(new int[12]); // seznam o délce 12 pro každý měsíc
            var reservations = await _context.Reservations.ToListAsync();

            foreach (var reservation in reservations)
            {
                int month = reservation.CreatedAt.Month - 1; // měsíce v DateTime začínají od 1, proto odečítáme 1
                reservationsByMonth[month]++;
            }

            return reservationsByMonth;
        }

        public Task CreateReservationStatusAsync(ReservationStatus reservationStatus)
        {
            var newReservationStatus = new ReservationStatus
            {
                Name = reservationStatus.Name
            };

            _context.ReservationStatuses.Add(newReservationStatus);
            return _context.SaveChangesAsync();

        }

        public async Task UpdateReservationStatusAsync(ReservationStatus reservationStatus)
        {
            var existingReservationStatus = await _context.ReservationStatuses.FirstOrDefaultAsync(rs => rs.Id == reservationStatus.Id);

            if (existingReservationStatus == null)
            {
                throw new InvalidOperationException("Reservation Status not found");
            }
            else
            {
                existingReservationStatus.Name = reservationStatus.Name;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteReservationStatusAsync(int id)
        {
            var reservationStatus = await _context.ReservationStatuses.FindAsync(id);

            if (reservationStatus == null)
            {
                throw new InvalidOperationException("Reservation Status not found");
            }
            else
            {
                _context.ReservationStatuses.Remove(reservationStatus);
                await _context.SaveChangesAsync();

            }
        }
    }
}
