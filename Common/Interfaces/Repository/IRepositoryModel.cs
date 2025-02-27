namespace Common.Interfaces.Repository
{
    public interface IRepositoryModel<Key>
    {
        Key Id { get; set; }
    }
}
