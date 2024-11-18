using Hotel_AdminPanel.Domain.Entities;


namespace Hotel_AdminPanel.Application.Interfaces
{
    public interface IPaymentService
    {
        Task<List<Payment>> GetPaymentsAsync();
        Task<Payment> GetPaymentByIdAsync(int id);
        Task CreatePaymentAsync(Payment payment);
        Task UpdatePaymentAsync(Payment payment);
        Task DeletePaymentAsync(int id);

        Task<List<Payment>> GetPaymentsByReservationIdAsync(int reservationId);
    }
}
