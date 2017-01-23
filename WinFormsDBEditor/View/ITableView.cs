using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDBEditor.Presenter;

namespace WinFormsDBEditor.View
{
    public interface ITableView
    {
        TabPage getTabPage();
        event EventHandler<EventArgs<int>> RowChange;

    }
}
