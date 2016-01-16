using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace TaskScheduler
{
    public class Job
    {
        string m_strJob = "";
        Thread t = null;
        public Job(string p_strjob,Thread p_t)
        {
            m_strJob = p_strjob;
            t = p_t;
        }

        public void DoJob()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = m_strJob;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();
            t.Abort();
        }
    }
}
