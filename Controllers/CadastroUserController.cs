using Microsoft.AspNetCore.Mvc;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;

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
            return Ok();
        }

    }
}
