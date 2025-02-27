using Common.Interfaces.Logic;
using Common.Interfaces.Repository;
using Common.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Products_API.Models;
using Products_EF.Contexts;
using Products_EF.Entites;

namespace Products_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : LogicController<int, ProductModel>
    {
        public ProductController(IRepositoryLogicLayer<int, ProductModel, RepositoryLogicResponse<ProductModel>> repo) : base(repo)
        {
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            var response = await _logic.Get();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _logic.Get(id);
            return Ok(response);
        }

        [HttpPost()]
        public async Task<IActionResult> Create(ProductModel model)
        {
            var response = await _logic.Create(model);
            await _logic.Save();

            return Ok(response);
        }

        [HttpPut()]
        public async Task<IActionResult> Put(ProductModel model)
        {
            var response = await _logic.Update(model);
            await _logic.Save();

            return Ok(response);
        }


        [HttpDelete()]
        public async Task<IActionResult> Delete(ProductModel model)
        {
            await _logic.Delete(model);
            await _logic.Save();
            return Ok();
        }
    }
}
