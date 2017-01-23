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
        public event EventHandler<EventArgs<int>> RowChangePropagate;

        public TablePresenter(ITableView View)
        {
            _view = View;
            SubscribeToViewEvents();
        }

        public ITableView getViewInterface()
        {
            return _view;
        }

        private void SubscribeToViewEvents() {
            _view.RowChange += this.RowChange;
        }

        private void RowChange(object sender, EventArgs<int> args) {
            var eventHandler = this.RowChangePropagate;
            if (eventHandler != null)
                eventHandler.Invoke(sender, args);
        }
    }
}
