using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDBEditor.View;

namespace WinFormsDBEditor.Presenter
{
    public interface ITablePresenter
    {
        ITableView getViewInterface();
        event EventHandler<EventArgs<int>> RowChangePropagate;

    }
}
