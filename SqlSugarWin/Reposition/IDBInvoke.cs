using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarWin.Utils
{
    public interface IDBInvoke<T> where T : class, new()
    {
        int Count(Expression<Func<T, bool>> where);
    }
}
