using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
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
