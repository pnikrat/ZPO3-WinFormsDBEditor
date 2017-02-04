using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDBEditor.Presenter;

namespace WinFormsDBEditor.View {
    public interface IAddEditEntity {
        event EventHandler<EventArgs<OperationStatus>> insertOccured;
    }
}
