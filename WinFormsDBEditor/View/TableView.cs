using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDBEditor.View
{
    public partial class TableView : UserControl, ITableView
    {
        TabPage associatedPage;

        public TableView(DataView tableToShow)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            InitializeTable(tableToShow);
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
    }
}
