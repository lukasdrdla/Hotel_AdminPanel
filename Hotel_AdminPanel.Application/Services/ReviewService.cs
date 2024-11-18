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
            try
            {
                _context.Reviews.Add(review);
                return _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Chyba při vytváření recenze.", ex);
            }
        }

        public async Task DeleteReviewAsync(int id)
        {
            var reviewToDelete = await _context.Reviews.FirstOrDefaultAsync(r => r.Id == id);
            if (reviewToDelete == null)
            {
                throw new NullReferenceException("Recenze nebyla nalezena.");
            }

            try
            {
                _context.Reviews.Remove(reviewToDelete);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Chyba při mazání recenze.", ex);
            }
        }


        public async Task<Review> GetReviewByIdAsync(int id)
        {
            var review = await _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(r => r.Id == id);
            return review;
        }

        public Task<List<Review>> GetReviewsAsync()
        {
            var reviews = _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .ToListAsync();
            return reviews;
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

        public async Task<List<Review>> GetRoomReviewsAsync(int roomId)
        {
            var review = await _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Where(r => r.RoomId == roomId)
                .ToListAsync();
            return review;
        }

        public async Task UpdateReviewAsync(Review review)
        {
            var existingReview = await _context.Reviews.FirstOrDefaultAsync(r => r.Id == review.Id);
            if (existingReview == null)
            {
                throw new NullReferenceException("Recenze nebyla nalezena.");
            }
            review.Id = existingReview.Id;
            review.CustomerId = existingReview.CustomerId;
            review.RoomId = existingReview.RoomId;
            review.Comment = existingReview.Comment;
            review.Rating = existingReview.Rating;

            try
            {
                _context.Reviews.Update(review);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Chyba při aktualizaci recenze.", ex);
            }

        }
    }
}
