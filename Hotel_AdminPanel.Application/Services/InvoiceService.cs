using Hotel_AdminPanel.Application.Interfaces;
using Hotel_AdminPanel.Domain.Entities;
using Hotel_AdminPanel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Hotel_AdminPanel.Application.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly ApplicationDbContext _context;

        public InvoiceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CheckIfInvoiceExistsForReservation(int reservationId)
        {
            return await _context.Invoices.AnyAsync(i => i.ReservationId == reservationId);
        }


        public async Task CreateInvoiceAsync(Invoice invoice)
        {
            try
            {
                await _context.Invoices.AddAsync(invoice);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // Zpracování výjimek při ukládání do databáze
                // Můžete logovat chybu nebo ji přehodit s podrobnostmi
                throw new Exception("Chyba při ukládání faktury do databáze.", ex);
            }

        }

        public async Task DeleteInvoiceAsync(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                throw new Exception("Faktura nebyla nalezena.");
            }

            _context.Invoices.Remove(invoice);
            await _context.SaveChangesAsync();

        }

        public Task<Invoice> GetInvoiceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Invoice>> GetInvoiceByReservationIdAsync(int reservationId)
        {
            var invoices = await _context.Invoices
                .Where(i => i.ReservationId == reservationId)
                .ToListAsync();
            return invoices;

        }

        public async Task<List<Invoice>> GetInvoicesAsync()
        {
            var invoices = await _context.Invoices
                .Include(i => i.Reservation)
                .ThenInclude(r => r.Customer)
                .ToListAsync();
            return invoices;
        }

        public Task UpdateInvoiceAsync(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
