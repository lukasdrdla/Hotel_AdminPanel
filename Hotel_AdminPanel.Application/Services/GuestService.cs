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
    public class GuestService : IGuestService
    {
        private readonly ApplicationDbContext _context;

        public GuestService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Guest> CreateGuestAsync(Guest guestDto)
        {
            try
            {
                await _context.Guests.AddAsync(guestDto);
                await _context.SaveChangesAsync();
                return guestDto;


            }
            catch (Exception)
            { 
                throw new Exception("Error creating guest");
            }

        }

        public Task DeleteGuestAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Guest> GetGuestAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Guest>> GetGuestsAsync()
        {
            var guests = await _context.Guests.ToListAsync();
            return guests;

        }

        public Task UpdateGuestAsync(Guest guestDto)
        {
            throw new NotImplementedException();
        }
    }
}
