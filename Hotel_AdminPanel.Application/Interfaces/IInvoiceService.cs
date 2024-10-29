using Hotel_AdminPanel.Domain.Entities;

namespace Hotel_AdminPanel.Application.Interfaces
{
    public interface IInvoiceService
    {
        Task<List<Invoice>> GetInvoicesAsync();
        Task<Invoice> GetInvoiceByIdAsync(int id);
        Task CreateInvoiceAsync(Invoice invoice);
        Task UpdateInvoiceAsync(Invoice invoice);
        Task DeleteInvoiceAsync(int id);

        Task<bool> CheckIfInvoiceExistsForReservation(int reservationId);
        Task<List<Invoice>> GetInvoiceByReservationIdAsync(int reservationId);


    }
}
