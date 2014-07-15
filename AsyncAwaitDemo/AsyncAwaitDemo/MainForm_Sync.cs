using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public partial class MainForm
    {
        #region Sync

        private void RunSync_Click(object sender, EventArgs e)
        {
            RunSyncMethod(1);
        }
        
        private void RunSyncError_Click(object sender, EventArgs e)
        {
            RunSyncMethod(500);
        }
        
        private void RunSyncMethod(int i)
        {
            // Setup
            IMyService service = new MyService(i);
            var task = new MyWorkload(service);

            try
            {
                // Do work:
                int result = task.DoWork();
                // Use result:
                lblResult.Text = "Completed sync " + result;
            }
            catch (Exception ex)
            {
                // Handle error:    
                lblResult.Text = "Error sync " + ex.ToString();
            }
        }

        #endregion
    }
}
