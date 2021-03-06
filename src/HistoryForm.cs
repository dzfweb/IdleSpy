﻿using System;
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

            var source = new BindingSource();
            source.DataSource = logGroupedByTitle;

            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private string ParseIdleLogTime(int second)
        {
            var t = TimeSpan.FromSeconds(second);
            return string.Format("{0:D2} hrs, {1:D2} mins, {2:D2} secs", t.Hours, t.Minutes, t.Seconds);
        }
    }
}