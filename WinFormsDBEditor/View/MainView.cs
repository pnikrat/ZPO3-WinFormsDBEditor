using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDBEditor.Presenter;
using WinFormsDBEditor.View;

namespace WinFormsDBEditor {
    public partial class MainView : Form, IMainView {

        public event EventHandler<EventArgs<int>> TabChange;
        public event EventHandler NewRecordCommand;
        public event EventHandler<EventArgs<object>> EditRecordCommand;
        public event EventHandler<EventArgs<object>> DeleteRecordCommand;
        private BindingSource ordersSource = new BindingSource();
        private BindingSource customersSource = new BindingSource();
        private BindingSource productsSource = new BindingSource();

        public MainView() {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView() {
            TablesTabControl.SizeMode = TabSizeMode.Fixed;
            NewRecordButton.Text = "New record...";
            EditRecordButton.Text = "Edit record...";
            DeleteRecordButton.Text = "Delete record";
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
            gridViewToStyle.AllowUserToAddRows = false;
            gridViewToStyle.ReadOnly = true;
            gridViewToStyle.BackgroundColor = SystemColors.Window;
            gridViewToStyle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            Type gridViewType = gridViewToStyle.GetType();
            PropertyInfo pi = gridViewType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(gridViewToStyle, true, null);
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

        public void UpdateCustomersTable() {
            customersSource.ResetBindings(false);
        }

        public void AcceptProductsTable(NwindTypedDS.ProductsDataTable _data) {
            productsSource.DataSource = _data;
            ProductsGridView.DataSource = productsSource;
        }

        public void UpdateProductsTable() {
            productsSource.ResetBindings(false);
        }

        public void SetStatusLabel(OperationStatus status) {
            if (status == OperationStatus.New) {
                StatusLabel.Text = "Row added";
            }
            else if (status == OperationStatus.Edited) {
                StatusLabel.Text = "Row edited";
            }
            else if (status == OperationStatus.Deleted) {
                StatusLabel.Text = "Row deleted";
            }
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

        protected virtual void OnEditRecordCommand(EventArgs<object> args) {
            var eventHandler = this.EditRecordCommand;
            if (eventHandler != null)
                eventHandler.Invoke(this, args);
        }

        protected virtual void OnDeleteRecordCommand(EventArgs<object> args) {
            var eventHandler = this.DeleteRecordCommand;
            if (eventHandler != null)
                eventHandler.Invoke(this, args);
        }

        private void TablesTabControl_SelectedIndexChanged(object sender, EventArgs e) {
            TabControl control = (TabControl)sender;
            OnTabChange(new EventArgs<int>(control.SelectedIndex));
        }

        private void NewRecordButton_Click(object sender, EventArgs e) {
            OnNewRecordCommand();            
        }

        private void EditRecordButton_Click(object sender, EventArgs e) {
            if (TablesTabControl.SelectedIndex == 0)
                OnEditRecordCommand(new EventArgs<object>(OrdersGridView.CurrentRow.DataBoundItem));
            else if (TablesTabControl.SelectedIndex == 1)
                OnEditRecordCommand(new EventArgs<object>(CustomersGridView.CurrentRow.DataBoundItem));
            else if (TablesTabControl.SelectedIndex == 2)
                OnEditRecordCommand(new EventArgs<object>(ProductsGridView.CurrentRow.DataBoundItem));
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e) {
            if (TablesTabControl.SelectedIndex == 0)
                OnDeleteRecordCommand(new EventArgs<object>(OrdersGridView.CurrentRow.DataBoundItem));
            else if (TablesTabControl.SelectedIndex == 1)
                OnDeleteRecordCommand(new EventArgs<object>(CustomersGridView.CurrentRow.DataBoundItem));
            else if (TablesTabControl.SelectedIndex == 2)
                OnDeleteRecordCommand(new EventArgs<object>(ProductsGridView.CurrentRow.DataBoundItem));
        }


    }
}
