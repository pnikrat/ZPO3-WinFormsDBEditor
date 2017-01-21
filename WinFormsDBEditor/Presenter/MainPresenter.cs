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
        private NewDataSet.CustomersDataTable temp;
        //private Dictionary<string, bool> ErrorDict;

        public MainPresenter(IMainView MainView) {
            _view = MainView;
            _data = new DBManager(@"PROVIDER=MICROSOFT.JET.OLEDB.4.0;DATA SOURCE=..\..\Database\Nwind.mdb");
            SubscribeToFormEvents();
            displayCustomersTable();
        }

        private void SubscribeToFormEvents() {
            //_view.PrescriptionNumberChanged += this.PrescriptionNumberChanged;
        }

        private void displayCustomersTable() {
            temp = _data.getCustomersTable();
        }
    }
}
