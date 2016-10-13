using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace IdleSpy
{
    public partial class ChartForm : Form
    {

        public ChartForm()
        {
            InitializeComponent();
        }

        public ChartForm(DataTable dataTable)
        {
            InitializeComponent();

            radChartView1.Title = "Idle Log";
  
        }
    }
}
