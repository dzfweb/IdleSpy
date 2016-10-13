using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace IdleSpy
{
    public partial class MainForm : Form
    {
        private bool IdleSpyStatus = true;
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
                        System.Threading.Thread.Sleep(int.Parse(txtInterval.Text));

                        var title = IdleSpyHelper.GetActiveWindowTitle();

                        if (!string.IsNullOrEmpty(title))
                        {
                            System.Diagnostics.Debug.WriteLine(title);

                            var newRow = dataSet.Tables["Log"].NewRow();
                            newRow[1] = DateTime.Now;
                            newRow[2] = title;
                            dataSet.Tables["Log"].Rows.Add(newRow);

                            dataSet.Tables["Log"].AcceptChanges();
                        }
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

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryForm(dataSet.Copy().Tables["Log"]);
            historyForm.ShowDialog();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            var chartForm = new ChartForm(dataSet.Copy().Tables["Log"]);
            chartForm.ShowDialog();
        }
    }
}