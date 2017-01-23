using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDBEditor.Presenter;
using WinFormsDBEditor.View;

namespace WinFormsDBEditor {
    public partial class MainView : Form, IMainView {

        public event EventHandler DataControlInitialization;
        public event EventHandler<EventArgs<int>> TabChange;

        public MainView() {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView() {
            TablesTabControl.SizeMode = TabSizeMode.Fixed;
            NewRecordButton.Text = "New order...";
            EditRecordButton.Text = "Edit record...";
            DeleteRecordButton.Text = "Delete record";
            FilterButton.Text = "Filter results...";
            StatusLabel.Text = "Data loaded";
        }

        public void AddTabPageToTablesTabControl(TabPage page)
        {
            TablesTabControl.TabPages.Add(page);
        }

        public void SetDataControlSource(DataView table)
        {
                     
        }

        protected virtual void OnDataControlInitialization()
        {
            var eventHandler = this.DataControlInitialization;
            if (eventHandler != null)
                eventHandler.Invoke(this, null);
        }

        protected virtual void OnTabChange(EventArgs<int> args) {
            var eventHandler = this.TabChange;
            if (eventHandler != null)
                eventHandler.Invoke(this, args);
        }

        private void TablesTabControl_SelectedIndexChanged(object sender, EventArgs e) {
            TabControl control = (TabControl)sender;
            OnTabChange(new EventArgs<int>(control.SelectedIndex));
        }
    }
}
