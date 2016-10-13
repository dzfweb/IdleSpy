using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleSpy
{
    public partial class HistoryForm : Form
    {

        public HistoryForm()
        {
            InitializeComponent();
        }

        public HistoryForm(DataTable dataTable)
        {
            InitializeComponent();            
            this.radGridView1.DataSource = dataTable;
            this.radGridView1.Columns[0].IsVisible = false;
        }
      
    }
}
