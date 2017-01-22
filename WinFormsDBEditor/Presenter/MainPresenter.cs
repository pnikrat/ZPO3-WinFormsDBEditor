using System;
using System.Collections.Generic;
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

        public MainPresenter(IMainView MainView) {
            _view = MainView;
            _data = new DBManager(@"PROVIDER=MICROSOFT.JET.OLEDB.4.0;DATA SOURCE=..\..\Database\Nwind.mdb");
            SubscribeToFormEvents();
            DataControlInitialization();
        }

        private void SubscribeToFormEvents() {
            //_view.DataControlInitialization += this.DataControlInitialization;
        }

        private void DataControlInitialization()
        {
            _view.SetDataControlSource(_data.getOrdersFiltered());
        }
    }
}
