using Microsoft.EntityFrameworkCore;
using Products_API.Models;
using Products_API.Repositories.Base;
using Products_EF.Contexts;
using Products_EF.Entites;

namespace Products_API.Repositories
{
    public class ProductRepository : RepositoryBase<int, ProductModel>
    {
        public ProductRepository(ProductsContext dbContext) : base(dbContext)
        {
        }
        public override async Task<IEnumerable<ProductModel>> Get()
        {
            var products = await DbContext.Products.ToListAsync();
            if (products == null) return null;

            return products.Select(product => new ProductModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock
            }).ToList();
        }

        public override async Task<ProductModel> Get(int id)
        {
            var product = await DbContext.Products.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (product == null) return null;

            return new ProductModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock
            };
        }

        public override async Task<ProductModel> Create(ProductModel model)
        {
            var product = new Product()
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                Stock = model.Stock,
            };

            await DbContext.Products.AddAsync(product);

            return new ProductModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock
            };
        }

        public override async Task Delete(int id)
        {
            var product = await DbContext.Products.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (product == null) return;
        }

        
        public override async Task<ProductModel> Update(ProductModel model)
        {
            var product = await DbContext.Products.Where(x => x.Id == model.Id).FirstOrDefaultAsync();
            if (product == null) return null;

            product.Name = model.Name;
            product.Price = model.Price;
            product.Stock = model.Stock;

            return model;
        }

        public override async Task Save()
        {
            await DbContext.SaveChangesAsync();
        }
    }
}
