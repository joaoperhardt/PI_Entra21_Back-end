using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;
using PI_Entra21_Back_end.Entity;
using PI_Entra21_Back_end.Validator;


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
        public async Task<IActionResult> Add(UserDTO user)
        {
            var validator = new CadastroValidator();

            var result = validator.Validate(user);

            var error = result.Errors.Select(e => e.ErrorMessage);

            if (!result.IsValid)
            {
                return BadRequest(error);
            }

            await _userRepository.Add(user);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _userRepository.GetById(id));
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LogIn(UserLoginDTO user)
        {
            try
            {
                return Ok(await _userRepository.LogIn(user));
            }
            catch (Exception ex)
            {
                return Unauthorized("Usuário ou senha invalidos");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserUpdateDTO user)
        {
            await _userRepository.Update(user);
            return Ok(user);
        }
    }
}
