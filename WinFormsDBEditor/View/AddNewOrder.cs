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
    public partial class AddNewOrder : Form, IAddNewOrder {

        NwindTypedDSTableAdapters.TableAdapterManager masterAdapter;
        NwindTypedDS theSet;
        public event EventHandler insertOccured;
        DBManager modelInstance;
        BindingSource customerIDSource;

        public AddNewOrder(DBManager modelInstance) {
            InitializeComponent();
            masterAdapter = modelInstance.getMasterAdapter();
            theSet = modelInstance.getTheSet();
            this.modelInstance = modelInstance;

            customerIDSource = new BindingSource(theSet, theSet.Orders.TableName);

            comboBox1.DataSource = customerIDSource;
            comboBox1.DisplayMember = theSet.Orders.CustomerIDColumn.ColumnName;
            comboBox1.ValueMember = theSet.Orders.CustomerIDColumn.ColumnName;
            
        }

        protected virtual void OnInsertOccured() {
            var eventHandler = this.insertOccured;
            if (eventHandler != null)
                eventHandler.Invoke(this, null);
        }

        private void button1_Click(object sender, EventArgs e) {
            NwindTypedDS.OrdersRow newRow = theSet.Orders.NewOrdersRow();
            newRow.CustomerID = (string)comboBox1.SelectedValue;
            newRow.EmployeeID = 9;
            newRow.OrderDate = new DateTime(2000, 1, 10);
            newRow.RequiredDate = new DateTime(2001, 1, 10);
            newRow.ShippedDate = new DateTime(2003, 12, 6);
            newRow.ShipVia = 2;
            newRow.Freight = 12;
            newRow.ShipName = "test";
            newRow.ShipAddress = "asdf";
            newRow.ShipCity = "augard";
            newRow.ShipRegion = "far";
            newRow.ShipPostalCode = "234-54";
            newRow.ShipCountry = "Berlioo";
            theSet.Orders.Rows.Add(newRow);

            customerIDSource.EndEdit();
            int result = masterAdapter.UpdateAll(theSet);
            modelInstance.UpdateOrdersTableDataset();
            OnInsertOccured();
        }
    }
}
