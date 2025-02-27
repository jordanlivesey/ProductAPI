using Common.Interfaces.Logic;

namespace Common.Logic
{
    public class LogicResponse<T> : ILogicResponse<T>
    {
        public T Response { get; set; }
    }
}
