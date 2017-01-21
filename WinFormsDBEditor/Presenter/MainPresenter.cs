using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDBEditor.View;

namespace WinFormsDBEditor.Presenter {
    class MainPresenter 
    {

        private readonly IMainView _view;
        //private PatientData currentPatient;
        //private Dictionary<string, bool> ErrorDict;

        public MainPresenter(IMainView MainView) {
            _view = MainView;
            //currentPatient = new PatientData();
            SubscribeToFormEvents();
            //SetupErrorDict();
        }

        private void SubscribeToFormEvents() {
            //_view.PrescriptionNumberChanged += this.PrescriptionNumberChanged;
        }

    }
}
