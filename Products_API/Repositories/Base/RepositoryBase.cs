﻿using Common.Interfaces;
using Products_EF.Contexts;

namespace Products_API.Repositories.Base
{
    public abstract class RepositoryBase<Key, Model> : IRepository<Key, Model> where Model : IRepositoryModel<Key>
    {
        protected ProductsContext DbContext { get; set; }

        public RepositoryBase(ProductsContext dbContext)
        {
            DbContext = dbContext;
        }

        public abstract Task<IEnumerable<Model>> Create(Model model);

        public abstract Task Delete(Model model);

        public abstract Task<IEnumerable<Model>> Get();

        public abstract Task<Model> Get(Key id);

        public abstract Task<IEnumerable<Model>> Update(Model model);

        public abstract Task Save();
    }
}
