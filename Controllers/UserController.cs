using Microsoft.AspNetCore.Mvc;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;

namespace PI_Entra21_Back_end.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(UserLoginDTO user)
        {
            try
            {
                return Ok(await _userRepository.Login(user));
            }
            catch (Exception ex)
            {
                return Unauthorized("E-mail ou senha inválidos");
            }

        }
    }
}
