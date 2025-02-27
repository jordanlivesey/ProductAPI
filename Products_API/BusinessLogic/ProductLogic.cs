using Common.Interfaces.Logic;
using Common.Interfaces.Repository;
using Common.Repository;
using Products_API.Models;

namespace Products_API.BusinessLogic
{
    public class ProductLogic : RepositoryLogicLayer<int, ProductModel>
    {
        public ProductLogic(IRepository<int, ProductModel> repository) : base(repository)
        {
        }

        public override Task<RepositoryLogicResponse<ProductModel>> Create(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public override Task Delete(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public override Task<RepositoryLogicResponse<IEnumerable<ProductModel>>> Get()
        {
            throw new NotImplementedException();
        }

        public override Task<RepositoryLogicResponse<ProductModel>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public override Task Save()
        {
            throw new NotImplementedException();
        }

        public override Task<RepositoryLogicResponse<IEnumerable<ProductModel>>> Update(ProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
