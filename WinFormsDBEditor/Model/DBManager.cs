using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDBEditor;

namespace WinFormsDBEditor.Model {
    public class DBManager {

        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataSet usedDataSet;
        private NewDataSet theSet;

        public DBManager(string connectionString) {
            establishConnection(connectionString);
            createDataAdapterAndDataSet();
            createSchema();
            initNewDataSet();
        }

        private void establishConnection(string connectionString) {
            connection = new OleDbConnection(connectionString);
        }

        private void createDataAdapterAndDataSet() {
            usedDataSet = new DataSet();
            dataAdapter = new OleDbDataAdapter();
        }

        private void createSchema() {
            if (!File.Exists(@"..\..\UsedDataSet.xsd")) {
                fillDataSet(usedDataSet);
                usedDataSet.WriteXmlSchema(@"..\..\UsedDataSet.xsd");
            }
        }

        private void initNewDataSet() {
            theSet = new NewDataSet();
            fillDataSet(theSet);
        }

        private void fillDataSet(DataSet setToFill) {
            dataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Customers", connection);
            dataAdapter.Fill(setToFill, "Customers");
            dataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Products", connection);
            dataAdapter.Fill(setToFill, "Products");
            dataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM Orders", connection);
            dataAdapter.Fill(setToFill, "Orders");
            dataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM [Order Details]", connection);
            dataAdapter.Fill(setToFill, "OrderDetails");
        }

        public NewDataSet.CustomersDataTable getCustomersTable() {
            return theSet.Customers;
        }

        public NewDataSet.ProductsDataTable getProductsTable() {
            return theSet.Products;
        }

        public NewDataSet.OrdersDataTable getOrdersTable() {
            return theSet.Orders;
        }
    }
}
