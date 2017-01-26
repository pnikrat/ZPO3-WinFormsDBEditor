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
        private IAddNewOrder _popup;
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
            AddNewOrder form = new AddNewOrder(_data);
            _popup = (IAddNewOrder)form;
            _popup.insertOccured += this.UpdateOrdersTable;
            form.Show();
        }

        private void UpdateOrdersTable(object sender, EventArgs args) {
            _view.UpdateOrdersTable();
        }
    }
}
