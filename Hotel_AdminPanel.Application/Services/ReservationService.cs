using Hotel_AdminPanel.Application.Interfaces;
using Hotel_AdminPanel.Domain.Entities;
using Hotel_AdminPanel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                SpecialRequest = reservation.SpecialRequest

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

        public Task DeleteReservationAsync(int id)
        {
            throw new NotImplementedException();
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
                exisitngMealPlan.Plan = mealPlan.Plan;
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
    }
}
