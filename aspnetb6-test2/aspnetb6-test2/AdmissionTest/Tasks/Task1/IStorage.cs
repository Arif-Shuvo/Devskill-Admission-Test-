using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IStorage<T> where T: class, new()
    {
        int Count { get; set; }
        void Add(T item);
        void Remove(T item);
        T Get(int index);
    }
}
