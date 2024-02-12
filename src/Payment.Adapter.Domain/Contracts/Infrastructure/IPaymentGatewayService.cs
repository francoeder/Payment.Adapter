namespace Payment.Adapter.Domain.Contracts.Infrastructure
{
    public interface IPaymentGatewayService
    {
        Task<string> HandlePayment(Entities.Payment payment);
    }
}
