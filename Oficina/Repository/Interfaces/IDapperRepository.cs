using Oficina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Repository.Interfaces
{
    public interface IDapperRepository
    {
        int Execute(string sql, object param);
        IEnumerable<T> Query<T>(string sql);
        IEnumerable<T> Query<T>(string sql, object param);
    }
}
