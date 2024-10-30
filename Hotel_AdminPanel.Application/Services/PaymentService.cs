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
        public async Task CreatePaymentAsync(Payment payment)
        {
            try
            {
                await _context.Payments.AddAsync(payment);
                await _context.SaveChangesAsync();

                var invoice = await _context.Invoices
                    .Include(i => i.Payments)
                    .FirstOrDefaultAsync(i => i.Id == payment.InvoiceId);

                if (invoice != null)
                {
                    invoice.IsPaid = _context.Payments.Any(p => p.InvoiceId == invoice.Id);
                    await _context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Chyba při vytváření platby.", ex);
            }
        }

        public async Task DeletePaymentAsync(int id)
        {
            var paymentToDelete = await _context.Payments.FirstOrDefaultAsync(p => p.Id == id);
            if (paymentToDelete == null)
            {
                throw new NullReferenceException("Platba nebyla nalezena.");
            }

            try
            {
                _context.Payments.Remove(paymentToDelete);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Chyba při mazání platby.", ex);
            }

        }

        public async Task<Payment> GetPaymentByIdAsync(int id)
        {
            var payment = await _context.Payments
                .Include(p => p.Invoice)
                .ThenInclude(i => i.Reservation)
                .ThenInclude(r => r.Customer)
                .FirstOrDefaultAsync(p => p.Id == id);

            return payment;
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

        public async Task UpdatePaymentAsync(Payment payment)
        {
            var existingPayment = await _context.Payments.FirstOrDefaultAsync(p => p.Id == payment.Id);
            if (existingPayment == null)
            {
                throw new NullReferenceException("Platba nebyla nalezena.");
            }

            try
            {
                existingPayment.InvoiceId = payment.InvoiceId;
                existingPayment.TotalAmount = payment.TotalAmount;
                existingPayment.PaymentDate = payment.PaymentDate;
                existingPayment.PaymentMethod = payment.PaymentMethod;
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Chyba při aktualizaci platby.", ex);
            }
        }
    }
}
