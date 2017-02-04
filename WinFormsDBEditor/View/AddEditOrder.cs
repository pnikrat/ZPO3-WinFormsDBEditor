using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
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
        NwindTypedDS.OrdersRow theRow;
        bool isNew;
        BindingSource customerIDSource;
        BindingSource employeeIDSource;
        BindingSource shipViaSource;
        char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

        public AddEditOrder(DBManager modelInstance) {
            InitializeComponent();
            InitModels(modelInstance);
            PrepareBindingSources();
            theRow = null;
        }

        public AddEditOrder(NwindTypedDS.OrdersRow editedRow, DBManager modelInstance) {
            InitializeComponent();
            InitModels(modelInstance);
            PrepareBindingSources();
            AttachEditedRowValues(editedRow);
            theRow = editedRow;

            AddNewOrderButton.Text = "Edit order";
            this.Text = "Edit order";
        }

        private void InitModels(DBManager model) {
            masterAdapter = model.getMasterAdapter();
            theSet = model.getTheSet();
            this.modelInstance = model;
        }

        private void PrepareBindingSources() {
            customerIDSource = new BindingSource();
            customerIDSource.DataSource = theSet.Orders.Select(r => new { r.CustomerID }).Distinct().OrderBy(x => x.CustomerID);

            customerIdComboBox.DataSource = customerIDSource;
            customerIdComboBox.DisplayMember = theSet.Orders.CustomerIDColumn.ColumnName;
            customerIdComboBox.ValueMember = theSet.Orders.CustomerIDColumn.ColumnName;

            employeeIDSource = new BindingSource();
            employeeIDSource.DataSource = theSet.Orders.Select(r => new { r.EmployeeID }).Distinct().OrderBy(x => x.EmployeeID);

            EmployeeIdComboBox.DataSource = employeeIDSource;
            EmployeeIdComboBox.DisplayMember = theSet.Orders.EmployeeIDColumn.ColumnName;
            EmployeeIdComboBox.ValueMember = theSet.Orders.EmployeeIDColumn.ColumnName;

            shipViaSource = new BindingSource();
            shipViaSource.DataSource = theSet.Orders.Select(r => new { r.ShipVia }).Distinct().OrderBy(x => x.ShipVia);

            ShipViaComboBox.DataSource = shipViaSource;
            ShipViaComboBox.DisplayMember = theSet.Orders.ShipViaColumn.ColumnName;
            ShipViaComboBox.ValueMember = theSet.Orders.ShipViaColumn.ColumnName;
        }

        private void AttachEditedRowValues(NwindTypedDS.OrdersRow editedRow) {
            
            customerIdComboBox.SelectedValue = editedRow.CustomerID;
            EmployeeIdComboBox.SelectedValue = editedRow.EmployeeID;
            OrderDatePicker.Value = editedRow.OrderDate;
            RequiredDatePicker.Value = editedRow.RequiredDate;
            ShippedDatePicker.Value = (editedRow.IsShippedDateNull()) ? DateTime.Now.Date : editedRow.ShippedDate;
            ShipViaComboBox.SelectedValue = editedRow.ShipVia;
            FreightTextBox.Text = editedRow.Freight.ToString();
            ShipNameTextBox.Text = editedRow.ShipName;
            ShipAddressTextBox.Text = editedRow.ShipAddress;
            ShipCityTextBox.Text = editedRow.ShipCity;          
            ShipRegionTextBox.Text = (editedRow.IsShipRegionNull()) ? string.Empty : editedRow.ShipRegion;
            ShipPostalCodeTextBox.Text = (editedRow.IsShipPostalCodeNull()) ? string.Empty : editedRow.ShipPostalCode;
            ShipCountryTextBox.Text = editedRow.ShipCountry;

        }

        protected virtual void OnInsertOccured() {
            var eventHandler = this.insertOccured;
            if (eventHandler != null)
                eventHandler.Invoke(this, null);
        }

        private void button1_Click(object sender, EventArgs e) {
            ClearErrors();
            if (!UserInputValidation())
                return;
            if (theRow == null) {
                theRow = theSet.Orders.NewOrdersRow();
                isNew = true;
            }
            theRow.CustomerID = (string)customerIdComboBox.SelectedValue;
            theRow.EmployeeID = (int)EmployeeIdComboBox.SelectedValue;
            theRow.OrderDate = OrderDatePicker.Value.Date;
            theRow.RequiredDate = RequiredDatePicker.Value.Date;
            theRow.ShippedDate = ShippedDatePicker.Value.Date;
            theRow.ShipVia = (int)ShipViaComboBox.SelectedValue;
            theRow.Freight = decimal.Parse(FreightTextBox.Text);
            theRow.ShipName = ShipNameTextBox.Text;
            theRow.ShipAddress = ShipAddressTextBox.Text;
            theRow.ShipCity = ShipCityTextBox.Text;
            theRow.ShipRegion = ShipRegionTextBox.Text;
            theRow.ShipPostalCode = ShipPostalCodeTextBox.Text;
            theRow.ShipCountry = ShipCountryTextBox.Text;
            if (isNew)
                theSet.Orders.Rows.Add(theRow);

            customerIDSource.EndEdit();
            employeeIDSource.EndEdit();
            shipViaSource.EndEdit();

            int result = masterAdapter.UpdateAll(theSet);
            modelInstance.UpdateOrdersTableDataset();
            OnInsertOccured();
            this.Close();
        }

        private bool UserInputValidation() {
            var boxes = Controls.OfType<TextBox>();

            foreach (var box in boxes) {
                if (string.IsNullOrWhiteSpace(box.Text)) {
                    errorProvider1.SetError(box, "Please fill the required field");
                    return false;
                }
            }
            return true;
        }

        private void ClearErrors() {
            errorProvider1.Clear();
        }

        private void FreightTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != decimalChar)) {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == decimalChar) {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}
