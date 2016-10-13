namespace IdleSpy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPower = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxLoadWithWindows = new System.Windows.Forms.CheckBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet = new IdleSpy.Data();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "IdleSpy is working in background";
            this.notifyIcon1.BalloonTipTitle = "IdleSpy";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(165, 226);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(107, 23);
            this.btnPower.TabIndex = 0;
            this.btnPower.Text = "[Power]";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxLoadWithWindows);
            this.panel1.Controls.Add(this.txtInterval);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 208);
            this.panel1.TabIndex = 1;
            // 
            // cbxLoadWithWindows
            // 
            this.cbxLoadWithWindows.AutoSize = true;
            this.cbxLoadWithWindows.Enabled = false;
            this.cbxLoadWithWindows.Location = new System.Drawing.Point(22, 42);
            this.cbxLoadWithWindows.Name = "cbxLoadWithWindows";
            this.cbxLoadWithWindows.Size = new System.Drawing.Size(114, 17);
            this.cbxLoadWithWindows.TabIndex = 2;
            this.cbxLoadWithWindows.Text = "Start with windows";
            this.cbxLoadWithWindows.UseVisualStyleBackColor = true;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(82, 13);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(54, 20);
            this.txtInterval.TabIndex = 1;
            this.txtInterval.Text = "1000";
            this.txtInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interval (ms)";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "Data";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(12, 226);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(60, 23);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(78, 226);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(60, 23);
            this.btnChart.TabIndex = 3;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "IdleSpy";
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxLoadWithWindows;
        private Data dataSet;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnChart;
    }
}

