using System.Data.OleDb;

namespace WinFormsDBEditor {
}

namespace WinFormsDBEditor {


    public partial class NwindTypedDS {
    }
}

namespace WinFormsDBEditor.NwindTypedDSTableAdapters {
    
    
    public partial class OrdersTableAdapter {

        public void InitEvents() {
            this._adapter.RowUpdated += _adapter_RowUpdated;
        }

        private void _adapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e) {
            if (e.Status == System.Data.UpdateStatus.Continue && e.StatementType == System.Data.StatementType.Insert) {
                var pk = e.Row.Table.PrimaryKey;
                pk[0].ReadOnly = false;

                OleDbCommand cmd = new OleDbCommand("SELECT MAX(OrderID) FROM Orders", e.Command.Connection, e.Command.Transaction);

                e.Row[pk[0]] = (int)cmd.ExecuteScalar();
                e.Row.AcceptChanges();
            }
        }
    }

    public partial class ProductsTableAdapter {
        public void InitEvents() {
            this._adapter.RowUpdated += _adapter_RowUpdated;
        }

        private void _adapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e) {
            if (e.Status == System.Data.UpdateStatus.Continue && e.StatementType == System.Data.StatementType.Insert) {
                var pk = e.Row.Table.PrimaryKey;
                pk[0].ReadOnly = false;

                OleDbCommand cmd = new OleDbCommand("SELECT MAX(ProductID) FROM Products", e.Command.Connection, e.Command.Transaction);

                e.Row[pk[0]] = (int)cmd.ExecuteScalar();
                e.Row.AcceptChanges();
            }
        }
    }
}
