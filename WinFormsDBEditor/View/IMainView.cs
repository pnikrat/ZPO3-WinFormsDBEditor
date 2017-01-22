using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDBEditor.View {
    public interface IMainView {

        void SetDataControlSource(DataView table);
        void AddTabPageToTablesTabControl(TabPage page);


        event EventHandler DataControlInitialization;
    }
}
