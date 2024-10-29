using Hotel_AdminPanel.Application.Interfaces;
using Hotel_AdminPanel.Domain.Entities;
using Hotel_AdminPanel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Hotel_AdminPanel.Application.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly ApplicationDbContext _context;

        public PaymentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task CreatePaymentAsync(Payment payment)
        {
            throw new NotImplementedException();
        }

        public Task DeletePaymentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Payment> GetPaymentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Payment>> GetPaymentsAsync()
        {
            var payments = await _context.Payments
                .Include(p => p.Invoice)
                .ThenInclude(i => i.Reservation)
                .ThenInclude(r => r.Customer)
                .ToListAsync();
            return payments;
        }

        public Task UpdatePaymentAsync(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}
