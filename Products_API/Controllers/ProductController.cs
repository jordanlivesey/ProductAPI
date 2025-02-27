using Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Products_API.Models;
using Products_EF.Contexts;
using Products_EF.Entites;

namespace Products_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : RepositoryController<int, ProductModel>
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, IRepository<int, ProductModel> repo) : base(repo)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.Get());
        }
    }
}
