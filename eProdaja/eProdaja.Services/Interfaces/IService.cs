using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.Interfaces
{
    public interface IService<T>
    {
        Task<List<T>> Get();
        Task<T> GetById(int id);
    }
}
