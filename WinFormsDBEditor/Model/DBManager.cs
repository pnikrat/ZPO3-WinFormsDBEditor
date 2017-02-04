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
using WinFormsDBEditor.NwindTypedDSTableAdapters;

namespace WinFormsDBEditor.Model {
    public class DBManager {

        private OleDbConnection connection;
        private CustomersTableAdapter customersAdapter;
        private ProductsTableAdapter productsAdapter;
        private OrdersTableAdapter ordersAdapter;
        private Order_DetailsTableAdapter orderDetailsAdapter;
        private NwindTypedDS theSet;
        private TableAdapterManager masterAdapter;

        public DBManager() {
            createConnection();
            createDataAdaptersAndDataSet();
            fillDataSet();
        }

        private void createConnection() {
            connection = new OleDbConnection(@"PROVIDER=MICROSOFT.JET.OLEDB.4.0;DATA SOURCE=..\..\Nwind.mdb");
        }

        private void createDataAdaptersAndDataSet() {
            theSet = new NwindTypedDS();
            customersAdapter = new CustomersTableAdapter();
            customersAdapter.Connection = connection;
            productsAdapter = new ProductsTableAdapter();
            productsAdapter.Connection = connection;
            ordersAdapter = new OrdersTableAdapter();
            ordersAdapter.Connection = connection;
            orderDetailsAdapter = new Order_DetailsTableAdapter();
            orderDetailsAdapter.Connection = connection;
            masterAdapter = new TableAdapterManager();
            masterAdapter.Connection = connection;
        }

        private void fillDataSet() {
            customersAdapter.Fill(theSet.Customers);
            customersAdapter.ClearBeforeFill = false;

            productsAdapter.Fill(theSet.Products);
            productsAdapter.ClearBeforeFill = false;
            productsAdapter.InitEvents();

            ordersAdapter.Fill(theSet.Orders);
            ordersAdapter.ClearBeforeFill = false;
            ordersAdapter.InitEvents();

            orderDetailsAdapter.Fill(theSet.Order_Details);

            masterAdapter.CustomersTableAdapter = customersAdapter;
            masterAdapter.ProductsTableAdapter = productsAdapter;
            masterAdapter.OrdersTableAdapter = ordersAdapter;
            masterAdapter.Order_DetailsTableAdapter = orderDetailsAdapter;
        }

        public void UpdateOrdersTableDataset() {
            ordersAdapter.Fill(theSet.Orders);
        }

        public void UpdateCustomersTableDataset() {
            customersAdapter.Fill(theSet.Customers);
        }

        public void UpdateProductsTableDataset() {
            productsAdapter.Fill(theSet.Products);
        }

        public TableAdapterManager getMasterAdapter() {
            return masterAdapter;
        }

        public NwindTypedDS getTheSet() {
            return theSet;
        }

        public NwindTypedDS.CustomersDataTable getCustomersTable() {
            return theSet.Customers;
        }

        public NwindTypedDS.ProductsDataTable getProductsTable() {
            return theSet.Products;
        }

        public NwindTypedDS.OrdersDataTable getOrdersTable() {
            return theSet.Orders;
        }



        // methods to be used soon
        public DataView getCustomersFromLondon()
        {
            return new DataView(theSet.Customers, "City = 'London'", "City", DataViewRowState.CurrentRows);
        }

        public DataView getOrdersFiltered()
        {
            return new DataView(theSet.Orders, "ShipCity = 'Berlin'", "OrderID", DataViewRowState.CurrentRows);
        }

        public void EditOrderRow(int rowNumber) {
            
            //theSet.Orders.FindByOrderID(rowNumber)
        }

        //end methods to be used soon

    }
}
