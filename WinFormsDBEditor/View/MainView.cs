using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDBEditor.View;

namespace WinFormsDBEditor {
    public partial class MainView : Form, IMainView {

        public MainView() {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView() {

        }
    }
}
