using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDBEditor.Model;

namespace WinFormsDBEditor.View {
    public partial class AddEditOrder : Form, IAddEditOrder {

        NwindTypedDSTableAdapters.TableAdapterManager masterAdapter;
        NwindTypedDS theSet;
        public event EventHandler insertOccured;
        DBManager modelInstance;
        BindingSource customerIDSource;
        BindingSource employeeIDSource;
        BindingSource shipViaSource;

        public AddEditOrder(DBManager modelInstance) {
            InitializeComponent();
            InitModels(modelInstance);
            PrepareBindingSources();
        }

        public AddEditOrder(NwindTypedDS.OrdersRow editedRow, DBManager modelInstance) {
            InitializeComponent();
            InitModels(modelInstance);
            PrepareBindingSources();
            AttachEditedRowValues(editedRow);
        }

        private void InitModels(DBManager model) {
            masterAdapter = model.getMasterAdapter();
            theSet = model.getTheSet();
            this.modelInstance = model;
        }

        private void PrepareBindingSources() {
            customerIDSource = new BindingSource();
            customerIDSource.DataSource = theSet.Orders.Select(r => new { r.CustomerID }).Distinct();

            customerIdComboBox.DataSource = customerIDSource;
            customerIdComboBox.DisplayMember = theSet.Orders.CustomerIDColumn.ColumnName;
            customerIdComboBox.ValueMember = theSet.Orders.CustomerIDColumn.ColumnName;

            employeeIDSource = new BindingSource();
            employeeIDSource.DataSource = theSet.Orders.Select(r => new { r.EmployeeID }).Distinct();

            EmployeeIdComboBox.DataSource = employeeIDSource;
            EmployeeIdComboBox.DisplayMember = theSet.Orders.EmployeeIDColumn.ColumnName;
            EmployeeIdComboBox.ValueMember = theSet.Orders.EmployeeIDColumn.ColumnName;

            shipViaSource = new BindingSource();
            shipViaSource.DataSource = theSet.Orders.Select(r => new { r.ShipVia }).Distinct();

            ShipViaComboBox.DataSource = shipViaSource;
            ShipViaComboBox.DisplayMember = theSet.Orders.ShipViaColumn.ColumnName;
            ShipViaComboBox.ValueMember = theSet.Orders.ShipViaColumn.ColumnName;
        }

        private void AttachEditedRowValues(NwindTypedDS.OrdersRow editedRow) {
            customerIdComboBox.SelectedValue = editedRow.CustomerID;
            EmployeeIdComboBox.SelectedValue = editedRow.EmployeeID;
            OrderDatePicker.Value = editedRow.OrderDate;
            RequiredDatePicker.Value = editedRow.RequiredDate;
            ShippedDatePicker.Value = editedRow.ShippedDate;
            ShipViaComboBox.SelectedValue = editedRow.ShipVia;
            FreightTextBox.Text = editedRow.Freight.ToString();
            ShipNameTextBox.Text = editedRow.ShipName;
            ShipAddressTextBox.Text = editedRow.ShipAddress;
            ShipCityTextBox.Text = editedRow.ShipCity;
            ShipRegionTextBox.Text = editedRow.ShipRegion;
            ShipPostalCodeBox.Text = editedRow.ShipPostalCode;
            ShipCountryTextBox.Text = editedRow.ShipCountry;
        }

        protected virtual void OnInsertOccured() {
            var eventHandler = this.insertOccured;
            if (eventHandler != null)
                eventHandler.Invoke(this, null);
        }

        private void button1_Click(object sender, EventArgs e) {
            NwindTypedDS.OrdersRow newRow = theSet.Orders.NewOrdersRow();
            newRow.CustomerID = (string)customerIdComboBox.SelectedValue;
            newRow.EmployeeID = (int)EmployeeIdComboBox.SelectedValue;
            newRow.OrderDate = OrderDatePicker.Value.Date;
            newRow.RequiredDate = RequiredDatePicker.Value.Date;
            newRow.ShippedDate = ShippedDatePicker.Value.Date;
            newRow.ShipVia = (int)ShipViaComboBox.SelectedValue;
            newRow.Freight = decimal.Parse(FreightTextBox.Text);
            newRow.ShipName = ShipNameTextBox.Text;
            newRow.ShipAddress = ShipAddressTextBox.Text;
            newRow.ShipCity = ShipCityTextBox.Text;
            newRow.ShipRegion = ShipRegionTextBox.Text;
            newRow.ShipPostalCode = ShipPostalCodeBox.Text;
            newRow.ShipCountry = ShipCountryTextBox.Text;
            theSet.Orders.Rows.Add(newRow);

            customerIDSource.EndEdit();
            employeeIDSource.EndEdit();
            shipViaSource.EndEdit();

            int result = masterAdapter.UpdateAll(theSet);
            modelInstance.UpdateOrdersTableDataset();
            OnInsertOccured();
        }
    }
}
