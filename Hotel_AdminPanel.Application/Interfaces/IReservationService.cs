﻿using Hotel_AdminPanel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Application.Interfaces
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetReservationsAsync();
        Task<Reservation> GetReservationByIdAsync(int id);
        Task CreateReservationAsync(Reservation reservation);
        Task UpdateReservationAsync(Reservation reservation);
        Task DeleteReservationAsync(int id);

        //Guests
        Task<List<Guest>> GetGuestsByReservationIdAsync(int reservationId);
        Task DeleteGuestAsync(int id);

        //MealPlan
        Task<List<MealPlan>> GetMealPlansAsync();
        Task CreateMealPlanAsync(MealPlan mealPlan);
        Task UpdateMealPlanAsync(MealPlan mealPlan);
        Task DeleteMealPlanAsync(int id);

        //reservationStatus
        Task<List<ReservationStatus>> GetReservationStatusesAsync();
        Task CreateReservationStatusAsync(ReservationStatus reservationStatus);
        Task UpdateReservationStatusAsync(ReservationStatus reservationStatus);
        Task DeleteReservationStatusAsync(int id);



        Task<List<Reservation>> GetReservationsByCustomerIdAsync(int customerId);
        Task<bool> IsRoomAvailableAsync(int roomId, DateTime checkIn, DateTime checkOut);
        Task<List<DateTime>> GetOccupiedDatesForRoomAsync(int roomId);


        Task<int[]> GetReservationsByMonthAsync();
    }
}
