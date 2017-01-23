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
        private DBManager _data;
        private List<ITablePresenter> dataTabs = new List<ITablePresenter>();
        private ITablePresenter currentTab;
        private int currentRowNumber;

        public MainPresenter(IMainView MainView) {
            _view = MainView;
            _data = new DBManager();
            //@"PROVIDER=MICROSOFT.JET.OLEDB.4.0;DATA SOURCE=Nwind.mdb"
            SubscribeToFormEvents();
            DataControlInitialization();
            SubscribeToControlsEvents();
        }

        private void SubscribeToFormEvents() {
            //_view.DataControlInitialization += this.DataControlInitialization;
            _view.TabChange += this.TabChange;
        }

        private void SubscribeToControlsEvents() {
            foreach (ITablePresenter _control in dataTabs) {
                _control.RowChangePropagate += this.RowChangeInControl;
            }
        }

        private void WireUpTableViewWithTablePresenter(DataView table)
        {
            TableView singleTable = new TableView(table);
            TablePresenter singlePresenter = new TablePresenter(singleTable);
            dataTabs.Add(singlePresenter);
            _view.AddTabPageToTablesTabControl(singlePresenter.getViewInterface().getTabPage());
        }

        private void DataControlInitialization()
        {
            WireUpTableViewWithTablePresenter(_data.getOrdersTable());
            WireUpTableViewWithTablePresenter(_data.getCustomersTable());
            WireUpTableViewWithTablePresenter(_data.getProductsTable());
            currentTab = dataTabs[0];
        }

        private void TabChange(object sender, EventArgs<int> args) {
            //0 - orders, 1 - customers, 2 - products
            currentTab = dataTabs[args.value];
        }

        private void RowChangeInControl(object sender, EventArgs<int> args) {
            currentRowNumber = args.value;
            
        }
    }
}
