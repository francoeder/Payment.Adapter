using Microsoft.Extensions.DependencyInjection;
using Payment.Adapter.Application.Services;
using Payment.Adapter.Domain.Contracts.Application;

namespace Payment.Adapter.Application.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPaymentService, PaymentService>();
            return services;
        }
    }
}
