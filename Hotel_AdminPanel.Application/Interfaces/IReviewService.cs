using Hotel_AdminPanel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Application.Interfaces
{
    public interface IReviewService
    {
        Task<List<Review>> GetReviewsAsync();
        Task<Review> GetReviewByIdAsync(int id);
        Task CreateReviewAsync(Review review);
        Task UpdateReviewAsync(Review review);
        Task DeleteReviewAsync(int id);

        Task<List<Review>> GetReviewsByCustomerIdAsync(int customerId);
        Task<List<Review>> GetRoomReviewsAsync(int roomId);
    }
}
