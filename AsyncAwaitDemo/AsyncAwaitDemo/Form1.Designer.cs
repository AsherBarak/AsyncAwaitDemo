namespace AsyncAwait
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RunSync = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.OldAsync = new System.Windows.Forms.Button();
            this.RunTaskAsynOnldError = new System.Windows.Forms.Button();
            this.RunTaskAsyncNew = new System.Windows.Forms.Button();
            this.RunAsyncErrorNew = new System.Windows.Forms.Button();
            this.RunSyncError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunSync
            // 
            this.RunSync.Location = new System.Drawing.Point(12, 12);
            this.RunSync.Name = "RunSync";
            this.RunSync.Size = new System.Drawing.Size(267, 23);
            this.RunSync.TabIndex = 0;
            this.RunSync.Text = "Run Sync";
            this.RunSync.UseVisualStyleBackColor = true;
            this.RunSync.Click += new System.EventHandler(this.RunSync_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 199);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // OldAsync
            // 
            this.OldAsync.Location = new System.Drawing.Point(12, 70);
            this.OldAsync.Name = "OldAsync";
            this.OldAsync.Size = new System.Drawing.Size(267, 23);
            this.OldAsync.TabIndex = 2;
            this.OldAsync.Text = "Run Async (background worker)";
            this.OldAsync.UseVisualStyleBackColor = true;
            this.OldAsync.Click += new System.EventHandler(this.BackgroundWorkerAsync_Click);
            // 
            // RunTaskAsynOnldError
            // 
            this.RunTaskAsynOnldError.Location = new System.Drawing.Point(12, 100);
            this.RunTaskAsynOnldError.Name = "RunTaskAsynOnldError";
            this.RunTaskAsynOnldError.Size = new System.Drawing.Size(267, 23);
            this.RunTaskAsynOnldError.TabIndex = 3;
            this.RunTaskAsynOnldError.Text = "Run Async Error (background worker)";
            this.RunTaskAsynOnldError.UseVisualStyleBackColor = true;
            this.RunTaskAsynOnldError.Click += new System.EventHandler(this.BackgroundWorkerError_Click);
            // 
            // RunTaskAsyncNew
            // 
            this.RunTaskAsyncNew.Location = new System.Drawing.Point(12, 130);
            this.RunTaskAsyncNew.Name = "RunTaskAsyncNew";
            this.RunTaskAsyncNew.Size = new System.Drawing.Size(267, 23);
            this.RunTaskAsyncNew.TabIndex = 4;
            this.RunTaskAsyncNew.Text = "Run Async (task)";
            this.RunTaskAsyncNew.UseVisualStyleBackColor = true;
            this.RunTaskAsyncNew.Click += new System.EventHandler(this.AsyncTask_Click);
            // 
            // RunAsyncErrorNew
            // 
            this.RunAsyncErrorNew.Location = new System.Drawing.Point(12, 160);
            this.RunAsyncErrorNew.Name = "RunAsyncErrorNew";
            this.RunAsyncErrorNew.Size = new System.Drawing.Size(267, 23);
            this.RunAsyncErrorNew.TabIndex = 6;
            this.RunAsyncErrorNew.Text = "Run Async Error (task)";
            this.RunAsyncErrorNew.UseVisualStyleBackColor = true;
            this.RunAsyncErrorNew.Click += new System.EventHandler(this.AsyncTasklError_Click);
            // 
            // RunSyncError
            // 
            this.RunSyncError.Location = new System.Drawing.Point(12, 41);
            this.RunSyncError.Name = "RunSyncError";
            this.RunSyncError.Size = new System.Drawing.Size(268, 23);
            this.RunSyncError.TabIndex = 7;
            this.RunSyncError.Text = "Run Sync Error";
            this.RunSyncError.UseVisualStyleBackColor = true;
            this.RunSyncError.Click += new System.EventHandler(this.RunSyncError_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 370);
            this.Controls.Add(this.RunSyncError);
            this.Controls.Add(this.RunAsyncErrorNew);
            this.Controls.Add(this.RunTaskAsyncNew);
            this.Controls.Add(this.RunTaskAsynOnldError);
            this.Controls.Add(this.OldAsync);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.RunSync);
            this.Name = "MainForm";
            this.Text = "Async Await trials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunSync;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button OldAsync;
        private System.Windows.Forms.Button RunTaskAsynOnldError;
        private System.Windows.Forms.Button RunTaskAsyncNew;
        private System.Windows.Forms.Button RunAsyncErrorNew;
        private System.Windows.Forms.Button RunSyncError;
    }
}

