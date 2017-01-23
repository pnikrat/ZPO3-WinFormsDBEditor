using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDBEditor.Presenter;

namespace WinFormsDBEditor.View
{
    public partial class TableView : UserControl, ITableView
    {
        TabPage associatedPage;
        DataView associatedDataView;
        public event EventHandler<EventArgs<int>> RowChange;

        public TableView(DataView tableToShow)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            InitializeTable(tableToShow);
            associatedDataView = tableToShow;
        }

        private void InitializeTable(DataView tableToShow)
        {
            associatedPage = new TabPage(tableToShow.Table.TableName);
            dataControl.RowHeadersVisible = false;
            dataControl.StandardTab = true;
            dataControl.MultiSelect = false;
            dataControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataControl.AllowUserToResizeColumns = false;
            dataControl.AllowUserToResizeRows = false;
            dataControl.BackgroundColor = SystemColors.Window;
            dataControl.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataControl.DataSource = tableToShow;
            associatedPage.Controls.Add(this);
        }

        public TabPage getTabPage()
        {
            return associatedPage;
        }

        protected virtual void OnRowChange(EventArgs<int> args) {
            var eventHandler = this.RowChange;
            if (eventHandler != null)
                eventHandler.Invoke(this, args);
        }

        private void dataControl_RowEnter(object sender, DataGridViewCellEventArgs e) {
            OnRowChange(new EventArgs<int>(e.RowIndex));
        }
    }
}
