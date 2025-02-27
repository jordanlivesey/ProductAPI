using Common.Logic;

namespace Common.Repository
{
    public class RepositoryLogicResponse<T> : LogicResponse<T>
    {
        public int StatusCode { get; set; }
    }
}
