using Common.Interfaces.Repository;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Common.Repository
{
    public class RepositoryLogger<Key, Model, Controller> : RepositoryDecorator<IRepository<Key, Model>>, IRepository<Key, Model> where Model : class, IRepositoryModel<Key>
    {
        private ILogger _logger { get; }
        public RepositoryLogger(IRepository<Key, Model> repository, ILogger<Controller> logger) : base(repository)
        {
            _logger = logger;
        }

        public async Task<Model> Create(Model model)
        {
            string method = "Create";
            var sw = TimerStart(method);

            try
            {
                return await Repository.Create(model);
            }
            catch (Exception ex)
            {
                _logger.LogError("repository", method, ex);
                throw;
            }
            finally
            {
                TimerFinish(method, sw);
            }
        }

        public async Task Delete(Key id)
        {
            string method = "Delete";
            var sw = TimerStart(method);

            try
            {
                await Repository.Delete(id);
            }
            catch (Exception ex)
            {
                _logger.LogError("repository", method, ex);
                throw;
            }
            finally
            {
                TimerFinish(method, sw);
            }
        }

        public async Task<IEnumerable<Model>> Get()
        {
            string method = "GetAll";
            var sw = TimerStart(method);

            try
            {
                return await Repository.Get();
            }
            catch (Exception ex)
            {
                _logger.LogError("repository", method, ex);
                throw;
            }
            finally
            {
                TimerFinish(method, sw);
            }
        }

        public async Task<Model> Get(Key id)
        {
            string method = "Get";
            var sw = TimerStart(method);

            try
            {
                return await Repository.Get(id);
            }
            catch (Exception ex)
            {
                _logger.LogError("repository", method, ex);
                throw;
            }
            finally
            {
                TimerFinish(method, sw);
            }
        }

        public async Task<Model> Update(Model model)
        {
            string method = "Update";
            var sw = TimerStart(method);

            try
            {
                return await Repository.Update(model);
            }
            catch (Exception ex)
            {
                _logger.LogError("repository", method, ex);
                throw;
            }
            finally
            {
                TimerFinish(method, sw);
            }
        }
        public async Task Save()
        {
            string method = "Save";
            var sw = TimerStart(method);

            try
            {
                await Repository.Save();
            }
            catch (Exception ex)
            {
                _logger.LogError("repository", method, ex);
                throw;
            }
            finally
            {
                TimerFinish(method, sw);
            }
        }

        private Stopwatch TimerStart(string methodName)
        {
            string type = typeof(Model).Name;

            _logger.LogInformation($"Repository event call for method: {methodName}");
            Stopwatch sw = null;
            sw = new Stopwatch();
            sw.Start();

            return sw;
        }

        private void TimerFinish(string methodName, Stopwatch sw)
        {
            string type = typeof(Model).Name;

            if (sw != null)
            {
                sw.Stop();
            }

            _logger.LogInformation($"Repository event call finished for for method: {methodName} in {sw.Elapsed}");
        }
    }
}
