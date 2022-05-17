using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private void SecondsSelector_ValueChanged(object sender, EventArgs e)
        {
            manager.UpdateSecLock();
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            cancel = false;
            startBtn.Enabled = false;
            stopBtn.Enabled = true;

            if (manager.GetRequestCount() == 0)
            {
                manager.Terminate("Requests queue is empty");
            }
            else
            {
                try
                {
                    bw = new BackgroundWorker();
                    bw.DoWork += (obj, ea) => manager.ThreadCalculation(ref cancel);
                    bw.RunWorkerAsync();
                    messageLabel.Text = "Thread started";
                }
                catch (Exception ex)
                {
                    messageLabel.Text = ex.GetBaseException().ToString();
                }
            }
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            cancel = true;
            manager.Terminate("Thread stopped");
        }
        private void ClearJournalBtn_Click(object sender, EventArgs e)
        {
            journalView.Items.Clear();
            messageLabel2.Text = "";
        }

    }
}
