namespace Common.Interfaces.Repository
{
    public interface IRepository<Key, Model> where Model : IRepositoryModel<Key>
    {
        Task<IEnumerable<Model>> Get();
        Task<Model> Get(Key id);
        Task<Model> Create(Model model);
        Task<Model> Update(Model model);
        Task Delete(Key id);
        Task Save();
    }
}
