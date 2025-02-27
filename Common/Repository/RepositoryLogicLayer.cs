using Common.Interfaces.Logic;
using Common.Interfaces.Repository;

namespace Common.Repository
{
    public abstract class RepositoryLogicLayer<Key, Model> : 
        IRepositoryLogicLayer<Key, Model, RepositoryLogicResponse<Model>> where Model : IRepositoryModel<Key>
    {
        protected IRepository<Key,Model> _repository { get; }

        public RepositoryLogicLayer(IRepository<Key, Model> repository)
        {
            _repository = repository;
        }

        public abstract Task<RepositoryLogicResponse<Model>> Create(Model model);
        public abstract Task<RepositoryLogicResponse<bool>> Delete(Key id);
        public abstract Task<RepositoryLogicResponse<IEnumerable<Model>>> Get();
        public abstract Task<RepositoryLogicResponse<Model>> Get(Key id);
        public abstract Task<RepositoryLogicResponse<Model>> Update(Model model);
        public abstract Task Save();
    }
}
