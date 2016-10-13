using System.Data;
using System.Linq;
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

            var logGroupedByTitle = from row in dataTable.AsEnumerable()
                                    group row by row.Field<string>("Title") into grp
                                    select new
                                    {
                                        Title = grp.Key,
                                        Time = ParseIdleLogTime(grp.Count())
                                    };

            this.radGridView1.DataSource = logGroupedByTitle;
        }

        private string ParseIdleLogTime(int second)
        {
            if (second < 60)
                return second + " seconds";
            else if (second > 60 && second < 3600)
                return second / 60 + " minutes";
            else if (second > 3600)
                return second / 3600 + " hours";

            return second + "";
        }
    }
}