using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDBEditor.View;

namespace WinFormsDBEditor.Presenter
{
    public class TablePresenter : ITablePresenter
    {
        private readonly ITableView _view;

        public TablePresenter(ITableView View)
        {
            _view = View;
        }

        public ITableView getViewInterface()
        {
            return _view;
        }
    }
}
