using Payment.Adapter.Domain.Contracts.Infrastructure;

namespace Payment.Adapter.Infrastructure.Configuration
{
    public class ServiceFactoryResolver
    {
        public delegate IPaymentGatewayService PaymentGatewayServiceResolver(string paymentMethod);
    }
}
