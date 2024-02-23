using Microsoft.AspNetCore.Mvc;
using PI_Entra21_Back_end.Contracts.Repository;

namespace PI_Entra21_Back_end.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _productRepository.GetById(id));
        }
    }
}
