using Common.Interfaces.Logic;
using Common.Interfaces.Repository;
using Common.Repository;
using Microsoft.AspNetCore.Http;
using Products_API.Models;
using System.Net;

namespace Products_API.BusinessLogic
{
    public class ProductLogic : RepositoryLogicLayer<int, ProductModel>
    {
        public ProductLogic(IRepository<int, ProductModel> repository) : base(repository)
        {
        }

        public override async Task<RepositoryLogicResponse<ProductModel>> Create(ProductModel model)
        {
            var response = await _repository.Create(model);
            // some better status codes could be added but a NotFound will do for now
            HttpStatusCode statusCode = HttpStatusCode.NotFound;

            if(response != null)
            {
                statusCode = HttpStatusCode.OK;
                
            }

            return new RepositoryLogicResponse<ProductModel>()
            {
                StatusCode = statusCode,
                Response = response
            };
        }

        public override async Task<RepositoryLogicResponse<bool>> Delete(int id)
        {
            await _repository.Delete(id);

            return new RepositoryLogicResponse<bool>()
            {
                StatusCode = HttpStatusCode.OK
            };
        }

        public override async Task<RepositoryLogicResponse<IEnumerable<ProductModel>>> Get()
        {
            var response = await _repository.Get();

            // some better status codes could be added but a NotFound will do for now
            HttpStatusCode statusCode = HttpStatusCode.NotFound;

            if (response != null)
            {
                statusCode = HttpStatusCode.OK;

            }

            return new RepositoryLogicResponse<IEnumerable<ProductModel>>()
            {
                StatusCode = statusCode,
                Response = response
            };
        }

        public override async Task<RepositoryLogicResponse<ProductModel>> Get(int id)
        {
            var response = await _repository.Get(id);

            // some better status codes could be added but a NotFound will do for now
            HttpStatusCode statusCode = HttpStatusCode.NotFound;

            if (response != null)
            {
                statusCode = HttpStatusCode.OK;

            }

            return new RepositoryLogicResponse<ProductModel>()
            {
                StatusCode = statusCode,
                Response = response
            };
        }

        public override async Task Save()
        {
            await _repository.Save();
        }

        public override async Task<RepositoryLogicResponse<ProductModel>> Update(ProductModel model)
        {
            var response = await _repository.Update(model);
            // some better status codes could be added but a NotFound will do for now
            HttpStatusCode statusCode = HttpStatusCode.NotFound;

            if (response != null)
            {
                statusCode = HttpStatusCode.OK;

            }

            return new RepositoryLogicResponse<ProductModel>()
            {
                StatusCode = statusCode,
                Response = response
            };
        }
    }
}
