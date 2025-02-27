using Common.Interfaces.Logic;
using Common.Logic;
using System.Net;

namespace Common.Repository
{
    public class RepositoryLogicResponse<T> : LogicResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
    }
}
