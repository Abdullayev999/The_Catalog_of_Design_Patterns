using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public interface IRepository<K,T>
    {
        public void Add(T item);
        public List<T> GetAll();
        public T Get(K key);
    }
}
