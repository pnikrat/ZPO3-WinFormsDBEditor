using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDBEditor.Presenter;

namespace WinFormsDBEditor.View {
    public interface IMainView {

        void SetDataControlSource(DataView table);
        void AddTabPageToTablesTabControl(TabPage page);


        event EventHandler DataControlInitialization;
        event EventHandler<EventArgs<int>> TabChange;

    }
}
