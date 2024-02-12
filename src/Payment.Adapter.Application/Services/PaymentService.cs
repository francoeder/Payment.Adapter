using Microsoft.AspNetCore.Http;
using Payment.Adapter.Domain.Contracts.Application;
using Payment.Adapter.Domain.Contracts.Infrastructure;
using Payment.Adapter.Infrastructure.Constants;
using static Payment.Adapter.Infrastructure.Configuration.ServiceFactoryResolver;

namespace Payment.Adapter.Application.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentGatewayService _paymentGatewayService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PaymentService(
            PaymentGatewayServiceResolver paymentGatewayResolver,
            IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _httpContextAccessor.HttpContext.Request.Headers
                .TryGetValue(HeaderItems.PaymentMethod, out var paymentMethod);
            _paymentGatewayService = paymentGatewayResolver(paymentMethod);
        }

        public async Task<string> Pay(Domain.Entities.Payment payment)
        {
            return await _paymentGatewayService.HandlePayment(payment);
        }
    }
}
