using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Core.Interfaces
{
    public interface IUpdatableRepo<T> : IRepo<T> where T : class
    {
        T Update(T item);
    }
}
