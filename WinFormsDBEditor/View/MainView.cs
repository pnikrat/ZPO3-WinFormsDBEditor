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

        public event EventHandler<EventArgs<int>> TabChange;
        public event EventHandler NewRecordCommand;
        private BindingSource ordersSource = new BindingSource();
        private BindingSource customersSource = new BindingSource();
        private BindingSource productsSource = new BindingSource();

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
            InitializeGridView();
        }

        private void InitializeGridView() {
            styleGridView(OrdersGridView);
            styleGridView(CustomersGridView);
            styleGridView(ProductsGridView);
        }

        private void styleGridView(DataGridView gridViewToStyle) {
            gridViewToStyle.RowHeadersVisible = false;
            gridViewToStyle.StandardTab = true;
            gridViewToStyle.MultiSelect = false;
            gridViewToStyle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewToStyle.AllowUserToResizeColumns = false;
            gridViewToStyle.AllowUserToResizeRows = false;
            gridViewToStyle.BackgroundColor = SystemColors.Window;
            gridViewToStyle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        public void AcceptOrdersTable(NwindTypedDS.OrdersDataTable _data) {
            ordersSource.DataSource = _data;
            OrdersGridView.DataSource = ordersSource;
        }

        public void UpdateOrdersTable() {
            ordersSource.ResetBindings(false);
        }

        public void AcceptCustomersTable(NwindTypedDS.CustomersDataTable _data) {
            customersSource.DataSource = _data;
            CustomersGridView.DataSource = customersSource;
        }

        public void AcceptProductsTable(NwindTypedDS.ProductsDataTable _data) {
            productsSource.DataSource = _data;
            ProductsGridView.DataSource = productsSource;
        }

        protected virtual void OnTabChange(EventArgs<int> args) {
            var eventHandler = this.TabChange;
            if (eventHandler != null)
                eventHandler.Invoke(this, args);
        }

        protected virtual void OnNewRecordCommand() {
            var eventHandler = this.NewRecordCommand;
            if (eventHandler != null)
                eventHandler.Invoke(this, null);
        }

        private void TablesTabControl_SelectedIndexChanged(object sender, EventArgs e) {
            TabControl control = (TabControl)sender;
            OnTabChange(new EventArgs<int>(control.SelectedIndex));
        }

        private void NewRecordButton_Click(object sender, EventArgs e) {
            OnNewRecordCommand();
        }
    }
}
