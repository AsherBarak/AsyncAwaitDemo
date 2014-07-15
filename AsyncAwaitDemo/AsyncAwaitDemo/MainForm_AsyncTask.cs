using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public partial class MainForm

    {
        private async void AsyncTask_Click(object sender, EventArgs e)
        {
            await RunTaskAsync(3);
        }

        private async void AsyncTasklError_Click(object sender, EventArgs e)
        {
            await RunTaskAsync(500);
        }

        async Task RunTaskAsync(int i)
        {
            // Setup:
            IMyService service = new MyService(i);
            var task = new MyWorkload(service);

            try
            {
                // Do work:
                int result = await Task.Run<int>(((Func<int>)task.DoWork));
                // Use result:
                lblResult.Text = "Completed task async " + result;
            }
            catch (Exception ex)
            {
                // Handle error:
                lblResult.Text = "Error task async" + ex.ToString();
            }
        }

    }
}
