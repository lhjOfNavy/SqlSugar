using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarWin.Model
{
    public class SysUser
    {
        [SugarColumn(IsPrimaryKey = true)]
        public Guid? Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string SysUserName { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 登录账号
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateOn { get; set; }
    }
    public class SysUserUpdatPwd : SysUser
    {
        /// <summary>
        /// 修改密码
        /// </summary>
        public string NewLoginPwd { get; set; }
    }
}
