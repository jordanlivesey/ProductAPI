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
            // some better status codes could be added but a NotFound will do for now
            HttpStatusCode statusCode = HttpStatusCode.NotFound;
            ProductModel response = null;
            try
            {
                response = await _repository.Create(model);

                if (response != null)
                {
                    statusCode = HttpStatusCode.OK;

                }

            } catch(Exception e)
            {
                statusCode = HttpStatusCode.InternalServerError;
            }

            return new RepositoryLogicResponse<ProductModel>()
            {
                StatusCode = statusCode,
                Response = response
            };
        }

        public override async Task<RepositoryLogicResponse<bool>> Delete(int id)
        {
            HttpStatusCode statusCode = HttpStatusCode.NotFound;

            try
            {
                await _repository.Delete(id);
            }
            catch (Exception e)
            {
                statusCode = HttpStatusCode.InternalServerError;
            }

            return new RepositoryLogicResponse<bool>()
            {
                StatusCode = HttpStatusCode.OK
            };
        }

        public override async Task<RepositoryLogicResponse<IEnumerable<ProductModel>>> Get()
        {
            // some better status codes could be added but a NotFound will do for now
            HttpStatusCode statusCode = HttpStatusCode.NotFound;
            IEnumerable<ProductModel> response = null;
            try
            {
                response = await _repository.Get();

                if (response != null)
                {
                    statusCode = HttpStatusCode.OK;

                }

            }
            catch (Exception e)
            {
                statusCode = HttpStatusCode.InternalServerError;
            }

            return new RepositoryLogicResponse<IEnumerable<ProductModel>>()
            {
                StatusCode = statusCode,
                Response = response
            };
        }

        public override async Task<RepositoryLogicResponse<ProductModel>> Get(int id)
        {
            // some better status codes could be added but a NotFound will do for now
            HttpStatusCode statusCode = HttpStatusCode.NotFound;
            ProductModel response = null;

            try
            {
                response = await _repository.Get(id);

                if (response != null)
                {
                    statusCode = HttpStatusCode.OK;

                }

            }
            catch (Exception e)
            {
                statusCode = HttpStatusCode.InternalServerError;
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
            HttpStatusCode statusCode = HttpStatusCode.NotFound;
            ProductModel response = null;

            try
            {
                response = await _repository.Update(model);

                if (response != null)
                {
                    statusCode = HttpStatusCode.OK;

                }

            }
            catch (Exception e)
            {
                statusCode = HttpStatusCode.InternalServerError;
            }

            return new RepositoryLogicResponse<ProductModel>()
            {
                StatusCode = statusCode,
                Response = response
            };
        }
    }
}
