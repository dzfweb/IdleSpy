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

            var logGroupedByTitle = (from row in dataTable.AsEnumerable()
                                     group row by row.Field<string>("Title") into grp
                                     orderby grp.Count() descending
                                     select new
                                     {
                                         Title = grp.Key,
                                         Time = grp.Count()
                                     })
                                     .OrderByDescending(p => p.Time)
                                     .Select((obj, index) =>
                                     new
                                     {
                                         Rank = index+1,
                                         Title = obj.Title,
                                         Time = ParseIdleLogTime(obj.Time)
                                     });

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