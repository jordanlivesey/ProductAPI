using Common.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Logic
{
    public class LogicResponse<T> : ILogicResponse<T>
    {
        public T Response { get; set; }
    }
}
