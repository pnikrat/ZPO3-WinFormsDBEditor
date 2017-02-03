using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDBEditor.Model;

namespace WinFormsDBEditor.View {
    public partial class AddEditCustomer : Form, IAddEditCustomer {

        NwindTypedDSTableAdapters.TableAdapterManager masterAdapter;
        NwindTypedDS theSet;
        public event EventHandler insertOccured;
        DBManager modelInstance;
        NwindTypedDS.CustomersRow theRow;
        bool isNew;
        BindingSource customerIDSource = new BindingSource();

        public AddEditCustomer(DBManager modelInstance) {
            InitializeComponent();
            InitModels(modelInstance);
            theRow = null;
        }

        public AddEditCustomer(NwindTypedDS.CustomersRow editedRow, DBManager modelInstance) {
            InitializeComponent();
            InitModels(modelInstance);
            PrepareBindingSources();
            AttachEditedRowValues(editedRow);

            theRow = editedRow;

            AddNewCustomerButton.Text = "Edit customer";
            this.Text = "Edit customer";
        }

        private void InitModels(DBManager model) {
            masterAdapter = model.getMasterAdapter();
            theSet = model.getTheSet();
            this.modelInstance = model;
        }

        private void PrepareBindingSources() {
            customerIDSource.DataSource = theSet.Customers.Select(r => new { r.CustomerID }).Distinct();

            CustomerIDComboBox.DataSource = customerIDSource;
            CustomerIDComboBox.DisplayMember = theSet.Customers.CustomerIDColumn.ColumnName;
            CustomerIDComboBox.ValueMember = theSet.Customers.CustomerIDColumn.ColumnName;
        }

        private void AttachEditedRowValues(NwindTypedDS.CustomersRow editedRow) {
            CustomerIDComboBox.SelectedValue = editedRow.CustomerID;
            CustomerIDComboBox.Enabled = false;
            CompanyNameTextBox.Text = editedRow.CompanyName;
            ContactNameTextBox.Text = editedRow.ContactName;
            ContactTitleTextBox.Text = editedRow.ContactTitle;
            AddressTextBox.Text = editedRow.Address;
            CityTextBox.Text = editedRow.City;
            RegionTextBox.Text = (editedRow.IsRegionNull()) ? string.Empty : editedRow.Region;
            PostalCodeTextBox.Text = (editedRow.IsPostalCodeNull()) ? string.Empty : editedRow.PostalCode;
            CountryTextBox.Text = editedRow.Country;
            PhoneBox.Text = editedRow.Phone;
            FaxBox.Text = (editedRow.IsFaxNull()) ? string.Empty : editedRow.Fax;

          /*  ShippedDatePicker.Value = (editedRow.IsShippedDateNull()) ? DateTime.Now.Date : editedRow.ShippedDate;
            ShipRegionTextBox.Text = (editedRow.IsShipRegionNull()) ? string.Empty : editedRow.ShipRegion;
            ShipPostalCodeTextBox.Text = (editedRow.IsShipPostalCodeNull()) ? string.Empty : editedRow.ShipPostalCode; */

        }

        protected virtual void OnInsertOccured() {
            var eventHandler = this.insertOccured;
            if (eventHandler != null)
                eventHandler.Invoke(this, null);
        }

        private void AddNewCustomerButton_Click(object sender, EventArgs e) {
            ClearErrors();
            if (!UserInputValidation())
                return;
            if (theRow == null) {
                theRow = theSet.Customers.NewCustomersRow();
                isNew = true;
                theRow.CustomerID = CustomerIDComboBox.Text;
            }
            theRow.CompanyName = CompanyNameTextBox.Text;
            theRow.ContactName = ContactNameTextBox.Text;
            theRow.ContactTitle = ContactTitleTextBox.Text;
            theRow.Address = AddressTextBox.Text;
            theRow.City = CityTextBox.Text;
            theRow.Region = RegionTextBox.Text;
            theRow.PostalCode = PostalCodeTextBox.Text;
            theRow.Country = CountryTextBox.Text;
            theRow.Phone = PhoneBox.Text;
            theRow.Fax = FaxBox.Text;
            if (isNew)
                theSet.Customers.Rows.Add(theRow);

            customerIDSource.EndEdit();

            int result = masterAdapter.UpdateAll(theSet);
            modelInstance.UpdateCustomersTableDataset();
            OnInsertOccured();
            this.Close();
        }

        private bool UserInputValidation() {
            if (theRow == null) { //validate customerID
                string tmp = CustomerIDComboBox.Text;
                if (string.IsNullOrWhiteSpace(tmp) || tmp.Length != 5 || !tmp.All(Char.IsLetter) || !tmp.All(Char.IsUpper)) {
                    errorProvider1.SetError(CustomerIDComboBox, "ID must be 5 uppercase letter only characters");
                    return false;
                }
                NwindTypedDS.CustomersRow rowWithSameId = theSet.Customers.FindByCustomerID(tmp);
                if (rowWithSameId != null) {
                    errorProvider1.SetError(CustomerIDComboBox, "This ID already exists");
                    return false;
                }
            }

            if (PostalCodeTextBox.Text.Length > 10) {
                errorProvider1.SetError(PostalCodeTextBox, "Value must be shorter than 10 characters");
                return false;
            }

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


    }
}
