using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDBEditor.View {
    public interface IMainView {

        void SetDataControlSource(DataView table);

        event EventHandler DataControlInitialization;
    }
}
