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

        public MainPresenter(IMainView MainView) {
            _view = MainView;
            _data = new DBManager(@"PROVIDER=MICROSOFT.JET.OLEDB.4.0;DATA SOURCE=..\..\Database\Nwind.mdb");
            
            SubscribeToFormEvents();
            DataControlInitialization();
        }

        private void SubscribeToFormEvents() {
            //_view.DataControlInitialization += this.DataControlInitialization;
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
        }
    }
}
