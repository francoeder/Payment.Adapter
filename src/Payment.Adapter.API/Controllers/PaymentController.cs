using Microsoft.AspNetCore.Mvc;
using Payment.Adapter.Domain.Contracts.Application;

namespace Payment.Adapter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> Pay([FromBody] Domain.Entities.Payment payment)
        {
            var result = await _paymentService.Pay(payment);

            return Ok(new
            {
                data = result,
                success = true
            });
        }
    }
}
