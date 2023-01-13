using SqlSugarWin.Service;
using SqlSugarWin.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SqlSugarWin
{
    public partial class frmMain : Form
    {
        public static SysUserService sysUserService;
        public static int total;
        public static int pageNum;
        public static int pageSize;
        public frmMain()
        {
            /// <summary>
            /// 初始化值
            /// </summary>
            /// 
            InitializeComponent();
            sysUserService = new SysUserService();
            pageNum = 1;
            pageSize = 2;
            total = sysUserService.GetCount();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            /// <summary>
            ///初始化加载
            /// </summary>
            /// 
            ShowDBUpload();
        }

        public void ShowDBUpload()
        {
            var num = sysUserService.GetCount();
            var item = DBInvoke<object>.GetDBStatus();
            this.labTopic.Text = Convert.ToString(item);
            this.labTopic.ForeColor = Color.White;
            this.labOnLineNum.Text = string.Format(@"在线-{0}-人", Convert.ToString(num));
            var sysUserDataList = sysUserService.OperateSYSUser();
            var queryByPage = sysUserService.QueryByPage(pageNum, pageSize, total);
            this.dgvSysUser.DataSource = queryByPage;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pageNum = 1;
            // 首页初始化值
            labCurrentPage.Text = Convert.ToString(pageNum);
            ChangeCurrentValue(labCurrentPage.Text);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            // 尾页初始化值
            // 总数/页大小：两种情况①整除②存在余数；判断等于或大于零
            // 1、取整，存在余数+1
            int temp = total / pageSize;
            if (temp == 0)
            {
                labCurrentPage.Text = Convert.ToString(temp);
                ChangeCurrentValue(labCurrentPage.Text);
            }
            else if (total % pageSize > 0)
            {
                labCurrentPage.Text = Convert.ToString(temp + 1);
                ChangeCurrentValue(labCurrentPage.Text);
            }
        }

        private void btnPreiousPage_Click(object sender, EventArgs e)
        {
            // 上一页
            var temp = int.Parse(labCurrentPage.Text);
            if (temp > 1)
            {
                var currentPage = int.Parse(labCurrentPage.Text) - 1;
                labCurrentPage.Text = Convert.ToString(currentPage);
                ChangeCurrentValue(labCurrentPage.Text);
            }
            else
            {
                MessageBox.Show("第一页");
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            // 下一页
            // 总页数-（当前页*页大小） > 0
            var temp = int.Parse(labCurrentPage.Text);
            if ((total - (temp * pageSize)) > 0)
            {
                var currentPage = int.Parse(labCurrentPage.Text) + 1;
                labCurrentPage.Text = Convert.ToString(currentPage);
                ChangeCurrentValue(labCurrentPage.Text);
            }
            else
            {
                MessageBox.Show("最后一页");
            }
        }
        #region[事件触发后初始值发生改变]
        public void ChangeCurrentValue(string value)
        {
            // 点击触发后页码发生变化，重新赋值给接口调用
            var ret = int.Parse(value);
            var queryByPage = sysUserService.QueryByPage(ret, pageSize, total);
            this.dgvSysUser.DataSource = queryByPage;
        }
        #endregion
    }
}
