namespace Common.Interfaces.Repository
{
    public interface IRepositoryDecorator<T>
    {
        T Repository { get; }
    }
}
