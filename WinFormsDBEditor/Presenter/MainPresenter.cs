using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDBEditor.Model;
using WinFormsDBEditor.View;

namespace WinFormsDBEditor.Presenter {
    class MainPresenter 
    {
        private readonly IMainView _view;
        private IAddEditOrder _popupOrder;
        private IAddEditCustomer _popupCustomer;
        private IAddEditProduct _popupProduct;
        private DBManager _data;
        //private int currentRowNumber;
        private int currentTab;

        public MainPresenter(IMainView MainView) {
            _view = MainView;
            _data = new DBManager();
            SubscribeToFormEvents();
            DataControlInitialization();
            currentTab = 0;
        }

        private void SubscribeToFormEvents() {
            _view.TabChange += this.TabChange;
            _view.NewRecordCommand += this.NewRecordCommand;
            _view.EditRecordCommand += this.EditRecordCommand;
            _view.DeleteRecordCommand += this.DeleteRecordCommand;
        }

        private void DataControlInitialization()
        {
            _view.AcceptOrdersTable(_data.getOrdersTable());
            _view.AcceptCustomersTable(_data.getCustomersTable());
            _view.AcceptProductsTable(_data.getProductsTable());
        }

        private void TabChange(object sender, EventArgs<int> args) {
            //0 - orders, 1 - customers, 2 - products
            currentTab = args.value;
        }

        private void NewRecordCommand(object sender, EventArgs args) {
            if (currentTab == 0) {
                AddEditOrder form = new AddEditOrder(_data);
                _popupOrder = (IAddEditOrder)form;
                _popupOrder.insertOccured += this.UpdateOrdersTable;
                form.Show();
            }
            else if (currentTab == 1) {
                AddEditCustomer form = new AddEditCustomer(_data);
                _popupCustomer = (IAddEditCustomer)form;
                _popupCustomer.insertOccured += this.UpdateCustomersTable;
                form.Show();
            }
            else if (currentTab == 2) {
                AddEditProduct form = new AddEditProduct(_data);
                _popupProduct = (IAddEditProduct)form;
                _popupProduct.insertOccured += this.UpdateProductsTable;
                form.Show();
            }

        }

        private void EditRecordCommand(object sender, EventArgs<object> args) {
            DataRowView rowView = (DataRowView)args.value;
            if (currentTab == 0) {
                AddEditOrder form = new AddEditOrder((NwindTypedDS.OrdersRow)rowView.Row, _data);
                form.Show();
            }
            else if (currentTab == 1) {
                AddEditCustomer form = new AddEditCustomer((NwindTypedDS.CustomersRow)rowView.Row, _data);
                form.Show();
            }
        }

        private void DeleteRecordCommand(object sender, EventArgs<object> args) {
            DataRowView rowView = (DataRowView)args.value;
            if (currentTab == 0) {
                NwindTypedDS.OrdersRow theRow = (NwindTypedDS.OrdersRow)rowView.Row;
                theRow.Delete();

                _data.getMasterAdapter().Order_DetailsTableAdapter.Update(_data.getTheSet().Order_Details);
                _data.getMasterAdapter().OrdersTableAdapter.Update(_data.getTheSet().Orders);

                //_data.getMasterAdapter().UpdateAll(_data.getTheSet());
                _data.UpdateOrdersTableDataset();
                UpdateOrdersTable(this, null);
            }
            else if (currentTab == 1) {
                NwindTypedDS.CustomersRow theRow = (NwindTypedDS.CustomersRow)rowView.Row;
                theRow.Delete();
                _data.getMasterAdapter().OrdersTableAdapter.Update(_data.getTheSet().Orders);
                _data.getMasterAdapter().CustomersTableAdapter.Update(_data.getTheSet().Customers);
                
                _data.UpdateCustomersTableDataset();
                UpdateCustomersTable(this, null);
            }
            else if (currentTab == 2) {
                NwindTypedDS.ProductsRow theRow = (NwindTypedDS.ProductsRow)rowView.Row;
                theRow.Delete();

                _data.getMasterAdapter().Order_DetailsTableAdapter.Update(_data.getTheSet().Order_Details);
                _data.getMasterAdapter().ProductsTableAdapter.Update(_data.getTheSet().Products);

                //_data.getMasterAdapter().UpdateAll(_data.getTheSet());
                _data.UpdateProductsTableDataset();
                UpdateProductsTable(this, null);
            }
        }

        private void UpdateOrdersTable(object sender, EventArgs args) {
            _view.UpdateOrdersTable();
        }

        private void UpdateCustomersTable(object sender, EventArgs args) {
            _view.UpdateCustomersTable();
        }

        private void UpdateProductsTable(object sender, EventArgs args) {
            _view.UpdateProductsTable();
        }
    }
}
