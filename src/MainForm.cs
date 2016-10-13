using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace IdleSpy
{
    public partial class MainForm : Form
    {
        private bool IdleSpyStatus = false;
        public MainForm()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
            RefreshPowerButton();
        }

        public void RefreshPowerButton()
        {
            btnPower.Text = IdleSpyStatus ? "Stop" : "Start";
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (true)
            {
                if (IdleSpyStatus)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        // Perform a time consuming operation and report progress.
                        System.Threading.Thread.Sleep(500);
                        System.Diagnostics.Debug.WriteLine(IdleSpyHelper.GetActiveWindowTitle());
                    }
                }
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            IdleSpyStatus = !IdleSpyStatus;
            RefreshPowerButton();
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}