using Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Products_API.Controllers
{
    public abstract class RepositoryController<Key, Model> : ControllerBase where Model : IRepositoryModel<Key>
    {
        protected IRepository<Key, Model> _repository { get; }

        public RepositoryController(IRepository<Key, Model> repository)
        {
            _repository = repository;
        }
    }
}
