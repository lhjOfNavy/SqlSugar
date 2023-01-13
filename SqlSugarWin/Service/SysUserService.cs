using SqlSugar;
using SqlSugarWin.Model;
using SqlSugarWin.Reposition;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarWin.Service
{
    public  class SysUserService
    {
        public SysUserRepository sysUserRepository;

        public SysUserService()
        {
            sysUserRepository = new SysUserRepository();
        }
        public int GetCount()
        {
            var exp = Expressionable.Create<SysUser>();
            return sysUserRepository.Count(exp.ToExpression());
        }

        #region[操作用户]
        public List<SysUser> OperateSYSUser()
        {
            return sysUserRepository.GetAllData();
        }

        public List<SysUser> QueryByPage(int pageNumber, int pageSize, int total)
        {
            var list = sysUserRepository.QueryByPage(pageNumber, pageSize, total);
            return list;
        }
        #endregion
    }
}
