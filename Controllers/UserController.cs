using Microsoft.AspNetCore.Mvc;
using PI_Entra21_Back_end.Contracts.Repository;

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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _userRepository.GetById(id));
        }
    }
}
