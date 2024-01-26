using Microsoft.AspNetCore.Mvc;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;
using PI_Entra21_Back_end.Validator;

namespace PI_Entra21_Back_end.Controllers
{
    [ApiController]
    [Route("cadastro")]
    public class CadastroUserController : ControllerBase
    {
      private readonly ICadastroUserRepository _userRepository;
        public CadastroUserController(ICadastroUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CadastroUserDTO user)
        {
            await _userRepository.Add(user);
            var validator = new CadastroValidator();

            var result = validator.Validate(user);

            var error = result.Errors.Select(e => e.ErrorMessage);

            if (!result.IsValid)
            {
                return BadRequest(error);
            }

            return Ok();
        }

    }
}
