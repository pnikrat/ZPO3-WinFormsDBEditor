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


        void AcceptProductsTable(NwindTypedDS.ProductsDataTable _data);
        void AcceptCustomersTable(NwindTypedDS.CustomersDataTable _data);
        void AcceptOrdersTable(NwindTypedDS.OrdersDataTable _data);
        void UpdateOrdersTable();
        void UpdateCustomersTable();
        void UpdateProductsTable();

        event EventHandler<EventArgs<int>> TabChange;
        event EventHandler NewRecordCommand;
        event EventHandler<EventArgs<object>> EditRecordCommand;
        event EventHandler<EventArgs<object>> DeleteRecordCommand;

    }
}
