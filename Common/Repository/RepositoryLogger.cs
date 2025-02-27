using Common.Interfaces.Repository;
using Microsoft.Extensions.Logging;

namespace Common.Repository
{
    public class RepositoryLogger<Key, Model, Controller> : RepositoryDecorator<IRepository<Key, Model>>, IRepository<Key, Model> where Model : class, IRepositoryModel<Key>
    {
        private ILogger _logger { get; }
        public RepositoryLogger(IRepository<Key, Model> repository, ILogger<Controller> logger) : base(repository)
        {
            _logger = logger;
        }

        public Task<Model> Create(Model model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Key id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Model>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Model> Get(Key id)
        {
            throw new NotImplementedException();
        }

        public Task<Model> Update(Model model)
        {
            throw new NotImplementedException();
        }
        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}
