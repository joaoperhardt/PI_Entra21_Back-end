using Microsoft.AspNetCore.Mvc;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;
using PI_Entra21_Back_end.Repository;

namespace PI_Entra21_Back_end.Controllers
{

    [ApiController]
    [Route("payment")]
    public class PaymentMethodController : ControllerBase
    {
        private readonly IpaymentmethodRepository _paymentRepository;

        public PaymentMethodController(IpaymentmethodRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Add(PaymentDTO payment)
        {
            await _paymentRepository.Add(payment);
            return Ok();
        }




    }
}
