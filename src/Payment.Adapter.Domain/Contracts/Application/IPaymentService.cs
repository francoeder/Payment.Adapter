namespace Payment.Adapter.Domain.Contracts.Application
{
    public interface IPaymentService
    {
        Task<string> Pay(Entities.Payment payment);
    }
}
