using Microsoft.AspNetCore.Mvc;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;

namespace PI_Entra21_Back_end.Controllers
{
    [ApiController]
    [Route("anuncio")]
    public class CadastroAnuncioController : ControllerBase
    {
        private readonly ICadastroAnuncioRepository _cadastroAnuncioRepository;

        public CadastroAnuncioController(ICadastroAnuncioRepository cadastroRepository)
        {
            _cadastroAnuncioRepository = cadastroRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            throw new NotImplementedException();
        } 
        [HttpGet("{id}")]
        public async Task GetById()
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public async Task<IActionResult> Add(CadastroAnuncioDTO anuncio)
        {
            await _cadastroAnuncioRepository.Add(anuncio);
            return Ok();
        }
        [HttpPut]
        public async Task Update()
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        public async Task Delete()
        {
            throw new NotImplementedException();
        }
    }
}
