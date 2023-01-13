using SqlSugar;
using SqlSugarWin.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SqlSugarWin.Utils
{
    /// <summary>
    /// 为上层逻辑提供数据支持
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// 
    public class DBInvoke<T> : IDBInvoke<T> where T : class, new()
    {
        public static string stringValue = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

        public static SqlSugarScope Context = new SqlSugarScope(new ConnectionConfig()
        {
            //连接符字串
            //ConnectionString = ConfigUtils.ConnectionString,
            ConnectionString = stringValue,
            //数据库类型
            DbType = SqlSugar.DbType.SqlServer,
            //从特性读取主键和自增列信息
            InitKeyType = InitKeyType.Attribute,
            //不设成true要手动close
            IsAutoCloseConnection = true
        });

        public DBInvoke() { }

        public static bool GetDBStatus()
        {
            bool ret = false;
            if (Context != null)
            {
                ret = true;
            }
            return ret;
        }
        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int Count(Expression<Func<T, bool>> where)
        {
            return Context.Queryable<T>().Count(where);
        }

        ///<summary>
        /// operate sqlsugar method
        /// </summary>
        /// 
        #region[sqlsugar操作]
        // 无条件获取全部数据
        public List<T> GetAllData()
        {
            return Context.SqlQueryable<T>(
                "SELECT s.Id,s.Name SysUserName,s.Code,s.LoginName,s.LoginPwd,s.Role,s.CreateOn FROM sysUser AS s"
                ).ToList();
        }

        // 查询分页
        public List<SysUser> QueryByPage(int pageNumber, int pageSize, int total)
        {
            var list = Context.SqlQueryable<SysUser>(
                "SELECT s.Id,s.Name SysUserName,s.Code,s.LoginName,s.LoginPwd,s.Role,s.CreateOn FROM sysUser AS s")
                .OrderBy("Id ASC")
                .ToPageList(pageNumber, pageSize, ref total);
            return list;
        }
        #endregion
    }
}
