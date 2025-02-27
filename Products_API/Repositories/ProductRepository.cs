using Products_API.Models;
using Products_API.Repositories.Base;
using Products_EF.Contexts;

namespace Products_API.Repositories
{
    public class ProductRepository : RepositoryBase<int, ProductModel>
    {
        public ProductRepository(ProductsContext dbContext) : base(dbContext)
        {
        }

        public override Task<IEnumerable<ProductModel>> Create(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public override Task Delete(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<ProductModel>> Get()
        {
            throw new NotImplementedException();
        }

        public override Task<ProductModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public override Task Save()
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<ProductModel>> Update(ProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
