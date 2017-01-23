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

        public DBManager() {
            createDataAdaptersAndDataSet();
            fillDataSet();
        }

        private void createDataAdaptersAndDataSet() {
            theSet = new NwindTypedDS();
            customersAdapter = new CustomersTableAdapter();
            productsAdapter = new ProductsTableAdapter();
            ordersAdapter = new OrdersTableAdapter();
            orderDetailsAdapter = new Order_DetailsTableAdapter();
        }

        private void fillDataSet() {
            customersAdapter.Fill(theSet.Customers);
            productsAdapter.Fill(theSet.Products);
            ordersAdapter.Fill(theSet.Orders);
            orderDetailsAdapter.Fill(theSet.Order_Details);
        }

        public NwindTypedDS getTheSet() {
            return theSet;
        }

        public DataView getCustomersTable() {
            return theSet.Customers.DefaultView;
        }

        public DataView getProductsTable() {
            return theSet.Products.DefaultView;
        }

        public DataView getOrdersTable() {
            return theSet.Orders.DefaultView;
        }

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
    }
}
