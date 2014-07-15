using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public partial class MainForm
    {
        #region Async background worker

        private void BackgroundWorkerAsync_Click(object sender, EventArgs e)
        {
            RunBackgroundWorker(2);
        }

        private void BackgroundWorkerError_Click(object sender, EventArgs e)
        {
            RunBackgroundWorker(500);
        }

        private void RunBackgroundWorker(int i)
        {
            // Setup:
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            IMyService service = new MyService(i);
            var task = new MyWorkload(service);

            // Pass setup:
            bw.RunWorkerAsync(task);
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do work (use setup):
            var task = (MyWorkload)e.Argument;
            e.Result = task.DoWork();
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Handle error (use error):
            if (e.Error != null)
            {
                lblResult.Text = "Error background worker " + e.Error;
                return;
            }

            // Use result (use result):
            lblResult.Text = "Completed background worker " + e.Result;
        }

        #endregion

    }
}
