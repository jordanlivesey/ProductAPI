namespace Common.Interfaces.Repository
{
    public interface IRepository<Key, Model> where Model : IRepositoryModel<Key>
    {
        Task<IEnumerable<Model>> Get();
        Task<Model> Get(Key id);
        Task<IEnumerable<Model>> Create(Model model);
        Task<IEnumerable<Model>> Update(Model model);
        Task Delete(Model model);
        Task Save();
    }
}
