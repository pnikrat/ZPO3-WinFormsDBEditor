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
