using System.Diagnostics;
using ProcessManager;

namespace Meneger
{
    public partial class TaskManeger : Form
    {
        ProcessManager.ProcessManager processManager = new ProcessManager.ProcessManager(); 

        public TaskManeger()
        {
            InitializeComponent();
            REFRESH();
        }

        void REFRESH()
        {
            processManager.refresh();
            ProcsList.Items.Clear();
            for (int i = 0; i < processManager.length; i++)
            {
                var row = new String[] { processManager[i].name,
                    processManager[i].memory.ToString("F2"),
                    processManager[i].priority,
                    "-",
                    processManager[i].stream_count.ToString()
                };
                if (processManager[i].start_time != null)
                    row[3] = processManager[i].start_time.ToString();
                var lvi = new ListViewItem(row);
                lvi.Tag = processManager[i];
                ProcsList.Items.Add(lvi);
            }
        }
        private void CalcButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
            REFRESH();
        }
        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc = (ProcessManager.Process)ProcsList.SelectedItems[0].Tag;
            proc.Stop();
            REFRESH();
        }
        public void ChangePriorityClick(object sender, EventArgs e)
        {
            var but = (ToolStripMenuItem) sender;
            var proc = (ProcessManager.Process)ProcsList.SelectedItems[0].Tag;
            proc.ChangePriority(but.Text);
            REFRESH();
        }
        private void WordButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE");
            REFRESH();
        }


        private void PhpStorm_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\JetBrains\PhpStorm 2022.2.1\bin\phpstorm64.exe");
            REFRESH();
        }

        private void WebStormButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\JetBrains\WebStorm 2021.3.2\bin\webstorm64.exe");
            REFRESH();
        }

        private void PyCharmButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\JetBrains\PyCharm Community Edition 2022.1.4\bin\pycharm64.exe");
            REFRESH();
        }

        private void SpotifyButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\ivanm\AppData\Roaming\Spotify\Spotify.exe");
            REFRESH();
        }
    }
}