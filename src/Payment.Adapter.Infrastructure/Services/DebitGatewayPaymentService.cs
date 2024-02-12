using Payment.Adapter.Domain.Contracts.Infrastructure;

namespace Payment.Adapter.Infrastructure.Services
{
    public class DebitGatewayPaymentService : IPaymentGatewayService
    {
        public async Task<string> HandlePayment(Domain.Entities.Payment payment)
        {
            var message = $"A payment worth {payment.Amount} was sent to the Debit Payment SA";
            return await Task.FromResult(message);
        }
    }
}
