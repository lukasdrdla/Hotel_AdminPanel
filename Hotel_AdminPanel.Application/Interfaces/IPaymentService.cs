using Hotel_AdminPanel.Domain.Entities;


namespace Hotel_AdminPanel.Application.Interfaces
{
    public interface IPaymentService
    {
        Task<List<Payment>> GetPaymentsAsync();
        Task<Payment> GetPaymentByIdAsync(string id);
        Task CreatePaymentAsync(Payment payment);
        Task UpdatePaymentAsync(Payment payment);
        Task DeletePaymentAsync(string id);

        Task<List<Payment>> GetPaymentsByReservationIdAsync(int reservationId);
    }
}
