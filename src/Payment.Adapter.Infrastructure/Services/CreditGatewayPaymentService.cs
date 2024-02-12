using Payment.Adapter.Domain.Contracts.Infrastructure;

namespace Payment.Adapter.Infrastructure.Services
{
    public class CreditGatewayPaymentService : IPaymentGatewayService
    {
        public async Task<string> HandlePayment(Domain.Entities.Payment payment)
        {
            var message = $"A payment worth {payment.Amount} was sent to the Credit Payment SA";
            return await Task.FromResult(message);
        }
    }
}
