using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class RepositoryDecorator<T> : IRepositoryDecorator<T>
    {
        public T Repository { get; }

        public RepositoryDecorator(T repository)
        {
            Repository = repository;
        }
    }
}
