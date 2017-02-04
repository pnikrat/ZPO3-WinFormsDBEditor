using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDBEditor.Model;
using WinFormsDBEditor.Presenter;

namespace WinFormsDBEditor.View {
    public partial class AddEditProduct : Form, IAddEditEntity {

        NwindTypedDSTableAdapters.TableAdapterManager masterAdapter;
        NwindTypedDS theSet;
        public event EventHandler<EventArgs<OperationStatus>> insertOccured;
        DBManager modelInstance;
        NwindTypedDS.ProductsRow theRow;
        bool isNew;
        BindingSource supplierIdSource;
        BindingSource categoryIdSource;
        char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

        public AddEditProduct(DBManager modelInstance) {
            InitializeComponent();
            InitModels(modelInstance);
            PrepareBindingSources();
            theRow = null;
        }

        public AddEditProduct(NwindTypedDS.ProductsRow editedRow, DBManager modelInstance) {
            InitializeComponent();
            InitModels(modelInstance);
            PrepareBindingSources();
            AttachEditedRowValues(editedRow);
            theRow = editedRow;

            AddNewProductButton.Text = "Edit product";
            this.Text = "Edit product";
        }

        private void InitModels(DBManager model) {
            masterAdapter = model.getMasterAdapter();
            theSet = model.getTheSet();
            this.modelInstance = model;
        }

        private void PrepareBindingSources() {
            supplierIdSource = new BindingSource();
            supplierIdSource.DataSource = theSet.Products.Select(r => new { r.SupplierID }).Distinct().OrderBy(x => x.SupplierID);

            SupplierIDComboBox.DataSource = supplierIdSource;
            SupplierIDComboBox.DisplayMember = theSet.Products.SupplierIDColumn.ColumnName;
            SupplierIDComboBox.ValueMember = theSet.Products.SupplierIDColumn.ColumnName;

            categoryIdSource = new BindingSource();
            categoryIdSource.DataSource = theSet.Products.Select(r => new { r.CategoryID }).Distinct().OrderBy(x => x.CategoryID);

            CategoryIDComboBox.DataSource = categoryIdSource;
            CategoryIDComboBox.DisplayMember = theSet.Products.CategoryIDColumn.ColumnName;
            CategoryIDComboBox.ValueMember = theSet.Products.CategoryIDColumn.ColumnName;
        }

        private void AttachEditedRowValues(NwindTypedDS.ProductsRow editedRow) {
            SupplierIDComboBox.SelectedValue = editedRow.SupplierID;
            CategoryIDComboBox.SelectedValue = editedRow.CategoryID;
            ProductNameTextBox.Text = editedRow.ProductName;
            QuantityPerUnitTextBox.Text = editedRow.QuantityPerUnit;
            UnitPriceTextBox.Text = editedRow.UnitPrice.ToString();
            UnitsInStockTextBox.Text = editedRow.UnitsInStock.ToString();
            UnitsOnOrderTextBox.Text = editedRow.UnitsOnOrder.ToString();
            ReorderLevelTextBox.Text = editedRow.ReorderLevel.ToString();
            DiscontinuedCheckbox.Checked = editedRow.Discontinued;
        }

        protected virtual void OnInsertOccured(OperationStatus args) {
            var eventHandler = this.insertOccured;
            if (eventHandler != null)
                eventHandler.Invoke(this, new EventArgs<OperationStatus>(args));
        }

        private void AddNewProductButton_Click(object sender, EventArgs e) {
            ClearErrors();
            if (!UserInputValidation())
                return;
            if (theRow == null) {
                theRow = theSet.Products.NewProductsRow();
                isNew = true;
                theRow.SupplierID = (int)SupplierIDComboBox.SelectedValue;
                theRow.CategoryID = (int)CategoryIDComboBox.SelectedValue;
            }
            theRow.ProductName = ProductNameTextBox.Text;
            theRow.QuantityPerUnit = QuantityPerUnitTextBox.Text;
            theRow.UnitPrice = decimal.Parse(UnitPriceTextBox.Text);
            theRow.UnitsInStock = short.Parse(UnitsInStockTextBox.Text);
            theRow.UnitsOnOrder = short.Parse(UnitsOnOrderTextBox.Text);
            theRow.ReorderLevel = short.Parse(ReorderLevelTextBox.Text);
            theRow.Discontinued = DiscontinuedCheckbox.Checked;
            if (isNew)
                theSet.Products.Rows.Add(theRow);

            supplierIdSource.EndEdit();
            categoryIdSource.EndEdit();

            int result = masterAdapter.UpdateAll(theSet);
            modelInstance.UpdateProductsTableDataset();
            OperationStatus status = (isNew) ? OperationStatus.New : OperationStatus.Edited;
            OnInsertOccured(status);
            this.Close();
        }

        private bool UserInputValidation() {
            var boxes = Controls.OfType<TextBox>();

            foreach (var box in boxes) {
                if (string.IsNullOrWhiteSpace(box.Text)) {
                    errorProvider1.SetError(box, "Please fill the required field");
                    return false;
                }
            }
            return true;
        }

        private void ClearErrors() {
            errorProvider1.Clear();
        }

        private void UnitPriceTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != decimalChar)) {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == decimalChar) {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void UnitsInStockTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8) {
                e.Handled = true;
                return;
            }
        }

        private void UnitsOnOrderTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8) {
                e.Handled = true;
                return;
            }
        }

        private void ReorderLevelTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8) {
                e.Handled = true;
                return;
            }
        }
    }
}
