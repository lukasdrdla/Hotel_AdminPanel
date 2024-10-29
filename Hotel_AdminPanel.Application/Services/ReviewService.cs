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
    public class ReviewService : IReviewService
    {
        private readonly ApplicationDbContext _context;

        public ReviewService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task CreateReviewAsync(Review review)
        {
            throw new NotImplementedException();
        }

        public Task DeleteReviewAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task<Review> GetReviewByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Review>> GetReviewsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Review>> GetReviewsByCustomerIdAsync(int customerId)
        {
            var reviews = _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Where(r => r.CustomerId == customerId)
                .ToListAsync();

            return reviews;
        }

        public Task UpdateReviewAsync(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
