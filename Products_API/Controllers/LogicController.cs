using Common.Interfaces.Logic;
using Common.Interfaces.Repository;
using Common.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Products_API.Controllers
{
    public abstract class LogicController<Key, Model> : ControllerBase where Model : IRepositoryModel<Key>
    {
        protected IRepositoryLogicLayer<Key, Model, RepositoryLogicResponse<Model>> _logic { get; }
        public LogicController(IRepositoryLogicLayer<Key, Model, RepositoryLogicResponse<Model>> logic)
        {
            _logic = logic;
        }
    }
}
