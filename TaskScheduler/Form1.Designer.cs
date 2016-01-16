namespace TaskScheduler
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.exe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rule = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ok = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开启任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "exe文件|*.exe|bat文件|*.bat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enable,
            this.exe,
            this.message,
            this.rule,
            this.ok});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(462, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // enable
            // 
            this.enable.HeaderText = "可用";
            this.enable.Name = "enable";
            this.enable.Visible = false;
            this.enable.Width = 40;
            // 
            // exe
            // 
            this.exe.DataPropertyName = "exe";
            this.exe.HeaderText = "程序";
            this.exe.Name = "exe";
            this.exe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // message
            // 
            this.message.DataPropertyName = "message";
            this.message.HeaderText = "描述";
            this.message.Name = "message";
            this.message.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.message.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.message.Width = 200;
            // 
            // rule
            // 
            this.rule.DataPropertyName = "rule";
            this.rule.HeaderText = "执行时间";
            this.rule.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.rule.Name = "rule";
            this.rule.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ok
            // 
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ok.HeaderText = "确定";
            this.ok.Name = "ok";
            this.ok.Text = "确定";
            this.ok.UseColumnTextForButtonValue = true;
            this.ok.Width = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开启任务ToolStripMenuItem,
            this.关闭任务ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开启任务ToolStripMenuItem
            // 
            this.开启任务ToolStripMenuItem.Name = "开启任务ToolStripMenuItem";
            this.开启任务ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.开启任务ToolStripMenuItem.Text = "开启任务";
            this.开启任务ToolStripMenuItem.Click += new System.EventHandler(this.开启任务ToolStripMenuItem_Click);
            // 
            // 关闭任务ToolStripMenuItem
            // 
            this.关闭任务ToolStripMenuItem.Name = "关闭任务ToolStripMenuItem";
            this.关闭任务ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.关闭任务ToolStripMenuItem.Text = "关闭任务";
            this.关闭任务ToolStripMenuItem.Click += new System.EventHandler(this.关闭任务ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Task Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enable;
        private System.Windows.Forms.DataGridViewTextBoxColumn exe;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewComboBoxColumn rule;
        private System.Windows.Forms.DataGridViewButtonColumn ok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开启任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭任务ToolStripMenuItem;
    }
}

