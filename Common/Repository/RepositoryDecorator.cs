using Common.Interfaces.Repository;

namespace Common.Repository
{
    public class RepositoryDecorator<T> : IRepositoryDecorator<T>
    {
        public T Repository { get; }

        public RepositoryDecorator(T repository)
        {
            Repository = repository;
        }
    }
}
