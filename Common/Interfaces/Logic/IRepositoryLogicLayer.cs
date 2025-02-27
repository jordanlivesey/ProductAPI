using Common.Interfaces.Repository;
using Common.Repository;

namespace Common.Interfaces.Logic
{
    public interface IRepositoryLogicLayer<Key, Model, Response> : ILogicLayer<Response, Model> where Response : ILogicResponse<Model> where Model : IRepositoryModel<Key>
    {
        public Task<RepositoryLogicResponse<Model>> Create(Model model);
        public Task Delete(Model model);
        public Task<RepositoryLogicResponse<IEnumerable<Model>>> Get();
        public Task<RepositoryLogicResponse<Model>> Get(Key id);
        public Task<RepositoryLogicResponse<IEnumerable<Model>>> Update(Model model);
        public Task Save();
    }
}
