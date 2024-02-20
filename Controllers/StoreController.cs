using Microsoft.AspNetCore.Mvc;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;
using PI_Entra21_Back_end.Validator;

namespace PI_Entra21_Back_end.Controllers
{
    [ApiController]
    [Route("store")]
    public class StoreController : ControllerBase
    {
      private readonly IStoreRepository _storeRepository;
        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddStore(StoreDTO store)
        {
            await _storeRepository.AddStore(store);
            var validator = new StoreValidator();

            var result = validator.Validate(store);

            var error = result.Errors.Select(e => e.ErrorMessage);

            if (!result.IsValid)
            {
                return BadRequest(error);
            }

            return Ok();
        }

    }
}
