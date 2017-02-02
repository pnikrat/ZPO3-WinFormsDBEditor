using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDBEditor.Model;

namespace WinFormsDBEditor.View {
    public partial class AddEditCustomer : Form, IAddEditCustomer {

        NwindTypedDSTableAdapters.TableAdapterManager masterAdapter;
        NwindTypedDS theSet;
        public event EventHandler insertOccured;
        DBManager modelInstance;

        public AddEditCustomer(DBManager modelInstance) {
            InitializeComponent();
            masterAdapter = modelInstance.getMasterAdapter();
            theSet = modelInstance.getTheSet();
            this.modelInstance = modelInstance;
        }

    }
}
