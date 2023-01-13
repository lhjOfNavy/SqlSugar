namespace SqlSugarWin
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labTopic = new System.Windows.Forms.Label();
            this.tlpCanvas = new System.Windows.Forms.TableLayoutPanel();
            this.panelDB = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPreiousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.labCurrentPage = new System.Windows.Forms.Label();
            this.dgvSysUser = new System.Windows.Forms.DataGridView();
            this.labOnLineNum = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SysUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpCanvas.SuspendLayout();
            this.panelDB.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labTopic
            // 
            this.labTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTopic.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labTopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTopic.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTopic.Location = new System.Drawing.Point(-3, 1);
            this.labTopic.Name = "labTopic";
            this.labTopic.Size = new System.Drawing.Size(989, 104);
            this.labTopic.TabIndex = 0;
            this.labTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpCanvas
            // 
            this.tlpCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCanvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpCanvas.ColumnCount = 2;
            this.tlpCanvas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.55409F));
            this.tlpCanvas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.44591F));
            this.tlpCanvas.Controls.Add(this.panelDB, 0, 0);
            this.tlpCanvas.Location = new System.Drawing.Point(-3, 108);
            this.tlpCanvas.Name = "tlpCanvas";
            this.tlpCanvas.RowCount = 2;
            this.tlpCanvas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCanvas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCanvas.Size = new System.Drawing.Size(989, 545);
            this.tlpCanvas.TabIndex = 1;
            // 
            // panelDB
            // 
            this.panelDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDB.Controls.Add(this.tableLayoutPanel1);
            this.panelDB.Controls.Add(this.dgvSysUser);
            this.panelDB.Controls.Add(this.labOnLineNum);
            this.panelDB.Location = new System.Drawing.Point(3, 3);
            this.panelDB.Name = "panelDB";
            this.panelDB.Size = new System.Drawing.Size(672, 266);
            this.panelDB.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnFirst, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLast, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPreiousPage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNextPage, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labCurrentPage, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(172, 224);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 37);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.Location = new System.Drawing.Point(3, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(59, 31);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "首页";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.Location = new System.Drawing.Point(263, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(61, 31);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = "尾页";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPreiousPage
            // 
            this.btnPreiousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreiousPage.Location = new System.Drawing.Point(68, 3);
            this.btnPreiousPage.Name = "btnPreiousPage";
            this.btnPreiousPage.Size = new System.Drawing.Size(59, 31);
            this.btnPreiousPage.TabIndex = 2;
            this.btnPreiousPage.Text = "《";
            this.btnPreiousPage.UseVisualStyleBackColor = true;
            this.btnPreiousPage.Click += new System.EventHandler(this.btnPreiousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.Location = new System.Drawing.Point(198, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(59, 31);
            this.btnNextPage.TabIndex = 3;
            this.btnNextPage.Text = "》";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // labCurrentPage
            // 
            this.labCurrentPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCurrentPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labCurrentPage.Location = new System.Drawing.Point(133, 0);
            this.labCurrentPage.Name = "labCurrentPage";
            this.labCurrentPage.Size = new System.Drawing.Size(59, 37);
            this.labCurrentPage.TabIndex = 4;
            this.labCurrentPage.Text = "1";
            this.labCurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSysUser
            // 
            this.dgvSysUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSysUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSysUser.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSysUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSysUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SysUserName,
            this.Code,
            this.LoginName,
            this.LoginPwd,
            this.Role,
            this.CreateOn});
            this.dgvSysUser.Location = new System.Drawing.Point(3, 28);
            this.dgvSysUser.Name = "dgvSysUser";
            this.dgvSysUser.RowHeadersVisible = false;
            this.dgvSysUser.RowHeadersWidth = 51;
            this.dgvSysUser.RowTemplate.Height = 27;
            this.dgvSysUser.Size = new System.Drawing.Size(664, 175);
            this.dgvSysUser.TabIndex = 1;
            // 
            // labOnLineNum
            // 
            this.labOnLineNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labOnLineNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labOnLineNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOnLineNum.Location = new System.Drawing.Point(-1, 0);
            this.labOnLineNum.Name = "labOnLineNum";
            this.labOnLineNum.Size = new System.Drawing.Size(672, 25);
            this.labOnLineNum.TabIndex = 0;
            this.labOnLineNum.Text = "在线人数";
            this.labOnLineNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "序号";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // SysUserName
            // 
            this.SysUserName.DataPropertyName = "SysUserName";
            this.SysUserName.HeaderText = "姓名";
            this.SysUserName.MinimumWidth = 6;
            this.SysUserName.Name = "SysUserName";
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "编码";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            // 
            // LoginName
            // 
            this.LoginName.DataPropertyName = "LoginName";
            this.LoginName.HeaderText = "登录名";
            this.LoginName.MinimumWidth = 6;
            this.LoginName.Name = "LoginName";
            // 
            // LoginPwd
            // 
            this.LoginPwd.DataPropertyName = "LoginPwd";
            this.LoginPwd.HeaderText = "登录密码";
            this.LoginPwd.MinimumWidth = 6;
            this.LoginPwd.Name = "LoginPwd";
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "角色";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            // 
            // CreateOn
            // 
            this.CreateOn.DataPropertyName = "CreateOn";
            this.CreateOn.HeaderText = "创建时间";
            this.CreateOn.MinimumWidth = 6;
            this.CreateOn.Name = "CreateOn";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.tlpCanvas);
            this.Controls.Add(this.labTopic);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpCanvas.ResumeLayout(false);
            this.panelDB.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labTopic;
        private System.Windows.Forms.TableLayoutPanel tlpCanvas;
        private System.Windows.Forms.Panel panelDB;
        private System.Windows.Forms.Label labOnLineNum;
        private System.Windows.Forms.DataGridView dgvSysUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPreiousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label labCurrentPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SysUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateOn;
    }
}

