using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDBEditor.View;

namespace WinFormsDBEditor {
    public partial class MainView : Form, IMainView {

        public event EventHandler DataControlInitialization;

        public MainView() {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView() {
            dataControl.RowHeadersVisible = false;
            dataControl.StandardTab = true;
            dataControl.MultiSelect = false;
            dataControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataControl.AllowUserToResizeColumns = false;
            dataControl.AllowUserToResizeRows = false;
            dataControl.BackgroundColor = SystemColors.Window;
            dataControl.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        public void SetDataControlSource(DataView table)
        {
            dataControl.DataSource = table;
        }

        protected virtual void OnDataControlInitialization()
        {
            var eventHandler = this.DataControlInitialization;
            if (eventHandler != null)
                eventHandler.Invoke(this, null);
        }
    }
}
