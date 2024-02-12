using Microsoft.Extensions.DependencyInjection;
using Payment.Adapter.Infrastructure.Constants;
using Payment.Adapter.Infrastructure.Services;
using static Payment.Adapter.Infrastructure.Configuration.ServiceFactoryResolver;

namespace Payment.Adapter.Infrastructure.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<CreditGatewayPaymentService>();
            services.AddTransient<DebitGatewayPaymentService>();

            services.AddScoped<PaymentGatewayServiceResolver>(serviceProvider => paymentMethod =>
            {
                return paymentMethod switch
                {
                    PaymentMethods.Credit => serviceProvider.GetService<CreditGatewayPaymentService>(),
                    PaymentMethods.Debit => serviceProvider.GetService<DebitGatewayPaymentService>(),
                    _ => serviceProvider.GetService<DebitGatewayPaymentService>()
                };
            });

            return services;
        }
    }

}
