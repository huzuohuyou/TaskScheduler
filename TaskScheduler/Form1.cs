using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using ToolFunction;
using System.Diagnostics;
using System.Threading;

namespace TaskScheduler
{
    public partial class Form1 : Form
    {
        string m_strConfigPath = Application.StartupPath + "\\" + "config.xml";
        Thread m_tTask = null;
        public Form1()
        {
            InitializeComponent();
            InitData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name  == "exe")
            {//打开文件
               openFileDialog1.ShowDialog();
               dataGridView1.CurrentCell.Value = openFileDialog1.FileName;
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "ok")
            {//保存文件
                DataTable _dt = new DataTable();
                _dt.Columns.Add("exe");
                _dt.Columns.Add("message");
                _dt.Columns.Add("rule");
                foreach (DataGridViewRow var in dataGridView1.Rows)
                {
                    if (var.Cells[1].Value == null)
                    {
                        continue;
                    }
                    _dt.Rows.Add(var.Cells["exe"].Value.ToString(), var.Cells["message"].Value.ToString() == null ? "*" : var.Cells["message"].Value.ToString(), var.Cells["rule"].Value.ToString() == null ? "1" : var.Cells["rule"].Value.ToString());
                }
                DataSet _ds = new DataSet();
                _ds.Tables.Add(_dt.Copy());
                SaveData(_ds);
            }
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        public void InitData()
        {
            try
            {
                DataSet _ds = CommonFunction.ConvertXMLFileToDataSet(m_strConfigPath);
                dataGridView1.DataSource = _ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                CommonFunction.WriteError(ex.Message);
            }

        }

        public void SaveData(DataSet p_dsSource)
        {
            CommonFunction.ConvertDataSetToXMLFile(p_dsSource, m_strConfigPath);
        }

        private void 添加行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 开启任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Task Scheduler ：任务开启";
            m_tTask = new Thread(StartTask);
            m_tTask.Start();
        }

        private void 关闭任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Task Scheduler ：任务关闭";
            m_tTask = null;
        }

      

        public void StartTask( )
        {
            while (true)
            {
                Thread.Sleep(1000*60*60);
                try
                {
                    DataSet _ds = CommonFunction.ConvertXMLFileToDataSet(m_strConfigPath);
                    foreach (DataRow var in _ds.Tables[0].Rows)
                    {
                        if (var["rule"].ToString() == DateTime.Now.Hour.ToString())
                        {
                            CommonFunction.WriteLog(DateTime.Now.ToString() + var["exe"].ToString());
                            Thread t = null;
                            Job j = new Job(var["exe"].ToString(), t);
                            t = new Thread(j.DoJob);
                            t.Start();
                        }
                    }
                }
                catch (Exception ex)
                {
                    CommonFunction.WriteError(ex.Message);
                }
            }
        }
    }
}