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

        public AddEditOrder(DBManager modelInstance) {
            InitializeComponent();
            masterAdapter = modelInstance.getMasterAdapter();
            theSet = modelInstance.getTheSet();
            this.modelInstance = modelInstance;

            customerIDSource = new BindingSource(theSet, theSet.Orders.TableName);

            customerIdComboBox.DataSource = customerIDSource;
            customerIdComboBox.DisplayMember = theSet.Orders.CustomerIDColumn.ColumnName;
            customerIdComboBox.ValueMember = theSet.Orders.CustomerIDColumn.ColumnName;
            
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
            newRow.OrderDate = OrderDatePicker.Value;
            newRow.RequiredDate = RequiredDatePicker.Value;
            newRow.ShippedDate = ShippedDatePicker.Value;
            newRow.ShipVia = (int)ShipViaComboBox.SelectedValue;
            newRow.Freight = 12;
            newRow.ShipName = ShipNameTextBox.Text;
            newRow.ShipAddress = ShipAddressTextBox.Text;
            newRow.ShipCity = ShipCityTextBox.Text;
            newRow.ShipRegion = ShipRegionTextBox.Text;
            newRow.ShipPostalCode = ShipPostalCodeBox.Text;
            newRow.ShipCountry = ShipCountryTextBox.Text;
            theSet.Orders.Rows.Add(newRow);

            customerIDSource.EndEdit();
            int result = masterAdapter.UpdateAll(theSet);
            modelInstance.UpdateOrdersTableDataset();
            OnInsertOccured();
        }
    }
}
