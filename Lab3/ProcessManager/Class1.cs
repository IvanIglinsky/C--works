using System.Diagnostics;
using System.Diagnostics.PerformanceData;

namespace ProcessManager
{
    public class Process
    {
        public string name;
        public float memory;
        public DateTime? start_time;
        public string priority;
        public int stream_count;
        private System.Diagnostics.Process proc;
        public Process(System.Diagnostics.Process proc)
        {
            this.proc = proc;
            this.name = proc.ProcessName;
            try
            {
                this.start_time = proc.StartTime;
            }
            catch
            {
                this.start_time = null;
            }

            PerformanceCounter performanceCounter = new PerformanceCounter();
            performanceCounter.CategoryName = "Process";
            performanceCounter.CounterName = "Working Set - Private";
            performanceCounter.InstanceName = proc.ProcessName;
            this.memory = Convert.ToInt32(performanceCounter.NextValue()) / (float)(1024 * 1024);
            performanceCounter.Close();
            performanceCounter.Dispose();
            
            try
            {
                this.priority = proc.PriorityClass.ToString();
            }
            catch
            {
                this.priority = "-";
            }
            this.stream_count = proc.Threads.Count;
        }
        public void Stop()
        {
            proc.Kill();
        }

        public void ChangePriority(string priority)
        {
            switch (priority)
            {
                case "RealTime":
                    this.proc.PriorityClass = ProcessPriorityClass.RealTime;
                    break;
                case "High":
                    this.proc.PriorityClass = ProcessPriorityClass.High;
                    break;
                case "AboveNormal":
                    this.proc.PriorityClass = ProcessPriorityClass.AboveNormal;
                    break;
                case "Normal":
                    this.proc.PriorityClass = ProcessPriorityClass.Normal;
                    break;
                case "BelowNormal":
                    this.proc.PriorityClass = ProcessPriorityClass.BelowNormal;
                    break;
                case "Idle":
                    this.proc.PriorityClass = ProcessPriorityClass.Idle;
                    break;
            }

            this.priority = this.proc.PriorityClass.ToString();
        }

        public static int nameComp(Process mp1, Process mp2)
        {
            return String.Compare(mp1.name, mp2.name, StringComparison.OrdinalIgnoreCase);
        }
    }
    
    public class ProcessManager
    {
        Process[] processes;
        public int length;
        private int sort = 0;
        public ProcessManager()
        {
            refresh();
        }

        public void refresh()
        {
            System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcesses();
            processes = new Process[procs.Length];
            int i = 0;
            length = procs.Length;
            foreach (System.Diagnostics.Process proc in procs)
            {
                processes[i] = new Process(proc);
                i++;
            }
            Array.Sort(processes, Process.nameComp);
        }

        
        public Process this[int key]
        {
            get => processes[key];
        }
    }
}