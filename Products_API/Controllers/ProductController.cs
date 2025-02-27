using Azure;
using Azure.Core;
using Common.Interfaces.Logic;
using Common.Interfaces.Repository;
using Common.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Products_API.Models;
using Products_EF.Contexts;
using Products_EF.Entites;
using System.Net;

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

            if (response.StatusCode != (int)HttpStatusCode.OK)
            {
                return this.StatusCode(response.StatusCode);
            }

            return Ok(response.Response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _logic.Get(id);

            if(response.StatusCode != (int) HttpStatusCode.OK)
            {
                return this.StatusCode(response.StatusCode); 
            }

            return Ok(response.Response);
        }

        [HttpPost()]
        public async Task<IActionResult> Create(ProductModel model)
        {
            var response = await _logic.Create(model);
            await _logic.Save();

            if (response.StatusCode != (int)HttpStatusCode.OK)
            {
                return this.StatusCode(response.StatusCode);
            }

            return Ok(response.Response); 
        }

        [HttpPut()]
        public async Task<IActionResult> Put(ProductModel model)
        {
            var response = await _logic.Update(model);
            await _logic.Save();

            if (response.StatusCode != (int)HttpStatusCode.OK)
            {
                return this.StatusCode(response.StatusCode);
            }

            return Ok(response.Response);
        }


        [HttpDelete()]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _logic.Delete(id);
            await _logic.Save();

            if (response.StatusCode != (int)HttpStatusCode.OK)
            {
                return this.StatusCode(response.StatusCode);
            }

            return Ok();
        }
    }
}
