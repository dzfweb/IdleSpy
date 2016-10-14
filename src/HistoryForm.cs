using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
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
                                         Rank = index + 1,
                                         Title = obj.Title,
                                         Time = ParseIdleLogTime(obj.Time)
                                     });

            this.radGridView1.DataSource = logGroupedByTitle;
        }

        private string ParseIdleLogTime(int second)
        {
            var t = TimeSpan.FromMilliseconds(second);
            return string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                        t.Hours,
                        t.Minutes,
                        t.Seconds,
                        t.Milliseconds);
        }
    }
}