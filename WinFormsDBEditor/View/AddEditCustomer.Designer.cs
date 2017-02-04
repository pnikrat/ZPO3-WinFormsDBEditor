namespace WinFormsDBEditor.View {
    partial class AddEditCustomer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.AddNewCustomerButton = new System.Windows.Forms.Button();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.RegionTextBox = new System.Windows.Forms.TextBox();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ContactTitleTextBox = new System.Windows.Forms.TextBox();
            this.ContactTitleLabel = new System.Windows.Forms.Label();
            this.ContactNameLabel = new System.Windows.Forms.Label();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.FaxLabel = new System.Windows.Forms.Label();
            this.CustomerIDComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.FaxTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewCustomerButton
            // 
            this.AddNewCustomerButton.Location = new System.Drawing.Point(15, 319);
            this.AddNewCustomerButton.Name = "AddNewCustomerButton";
            this.AddNewCustomerButton.Size = new System.Drawing.Size(257, 23);
            this.AddNewCustomerButton.TabIndex = 11;
            this.AddNewCustomerButton.Text = "Add new record";
            this.AddNewCustomerButton.UseVisualStyleBackColor = true;
            this.AddNewCustomerButton.Click += new System.EventHandler(this.AddNewCustomerButton_Click);
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(12, 199);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(61, 13);
            this.PostalCodeLabel.TabIndex = 32;
            this.PostalCodeLabel.Text = "PostalCode";
            // 
            // RegionTextBox
            // 
            this.RegionTextBox.Location = new System.Drawing.Point(130, 170);
            this.RegionTextBox.Name = "RegionTextBox";
            this.RegionTextBox.Size = new System.Drawing.Size(142, 20);
            this.RegionTextBox.TabIndex = 6;
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Location = new System.Drawing.Point(12, 173);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(41, 13);
            this.RegionLabel.TabIndex = 30;
            this.RegionLabel.Text = "Region";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(130, 144);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(142, 20);
            this.CityTextBox.TabIndex = 5;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(12, 147);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 28;
            this.CityLabel.Text = "City";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(130, 118);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(142, 20);
            this.AddressTextBox.TabIndex = 4;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(12, 121);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 26;
            this.AddressLabel.Text = "Address";
            // 
            // ContactTitleTextBox
            // 
            this.ContactTitleTextBox.Location = new System.Drawing.Point(130, 92);
            this.ContactTitleTextBox.Name = "ContactTitleTextBox";
            this.ContactTitleTextBox.Size = new System.Drawing.Size(142, 20);
            this.ContactTitleTextBox.TabIndex = 3;
            // 
            // ContactTitleLabel
            // 
            this.ContactTitleLabel.AutoSize = true;
            this.ContactTitleLabel.Location = new System.Drawing.Point(12, 95);
            this.ContactTitleLabel.Name = "ContactTitleLabel";
            this.ContactTitleLabel.Size = new System.Drawing.Size(64, 13);
            this.ContactTitleLabel.TabIndex = 24;
            this.ContactTitleLabel.Text = "ContactTitle";
            // 
            // ContactNameLabel
            // 
            this.ContactNameLabel.AutoSize = true;
            this.ContactNameLabel.Location = new System.Drawing.Point(12, 68);
            this.ContactNameLabel.Name = "ContactNameLabel";
            this.ContactNameLabel.Size = new System.Drawing.Size(72, 13);
            this.ContactNameLabel.TabIndex = 22;
            this.ContactNameLabel.Text = "ContactName";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(12, 41);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(79, 13);
            this.CompanyNameLabel.TabIndex = 20;
            this.CompanyNameLabel.Text = "CompanyName";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(12, 15);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(62, 13);
            this.CustomerIDLabel.TabIndex = 18;
            this.CustomerIDLabel.Text = "CustomerID";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(12, 225);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(43, 13);
            this.CountryLabel.TabIndex = 36;
            this.CountryLabel.Text = "Country";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(130, 222);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(142, 20);
            this.CountryTextBox.TabIndex = 8;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(12, 251);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.PhoneLabel.TabIndex = 38;
            this.PhoneLabel.Text = "Phone";
            // 
            // FaxLabel
            // 
            this.FaxLabel.AutoSize = true;
            this.FaxLabel.Location = new System.Drawing.Point(12, 277);
            this.FaxLabel.Name = "FaxLabel";
            this.FaxLabel.Size = new System.Drawing.Size(24, 13);
            this.FaxLabel.TabIndex = 40;
            this.FaxLabel.Text = "Fax";
            // 
            // CustomerIDComboBox
            // 
            this.CustomerIDComboBox.FormattingEnabled = true;
            this.CustomerIDComboBox.Location = new System.Drawing.Point(130, 11);
            this.CustomerIDComboBox.Name = "CustomerIDComboBox";
            this.CustomerIDComboBox.Size = new System.Drawing.Size(142, 21);
            this.CustomerIDComboBox.TabIndex = 0;
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(130, 40);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.CompanyNameTextBox.TabIndex = 1;
            // 
            // ContactNameTextBox
            // 
            this.ContactNameTextBox.Location = new System.Drawing.Point(130, 66);
            this.ContactNameTextBox.Name = "ContactNameTextBox";
            this.ContactNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.ContactNameTextBox.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(130, 196);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(142, 20);
            this.PostalCodeTextBox.TabIndex = 7;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(130, 248);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(142, 20);
            this.PhoneTextBox.TabIndex = 9;
            this.PhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTextBox_KeyPress);
            // 
            // FaxTextBox
            // 
            this.FaxTextBox.Location = new System.Drawing.Point(130, 274);
            this.FaxTextBox.Name = "FaxTextBox";
            this.FaxTextBox.Size = new System.Drawing.Size(142, 20);
            this.FaxTextBox.TabIndex = 10;
            this.FaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FaxTextBox_KeyPress);
            // 
            // AddEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 354);
            this.Controls.Add(this.FaxTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.ContactNameTextBox);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.CustomerIDComboBox);
            this.Controls.Add(this.FaxLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.AddNewCustomerButton);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.RegionTextBox);
            this.Controls.Add(this.RegionLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.ContactTitleTextBox);
            this.Controls.Add(this.ContactTitleLabel);
            this.Controls.Add(this.ContactNameLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.CustomerIDLabel);
            this.MaximumSize = new System.Drawing.Size(310, 393);
            this.MinimumSize = new System.Drawing.Size(310, 393);
            this.Name = "AddEditCustomer";
            this.Text = "Add New Customer";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewCustomerButton;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.TextBox RegionTextBox;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox ContactTitleTextBox;
        private System.Windows.Forms.Label ContactTitleLabel;
        private System.Windows.Forms.Label ContactNameLabel;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label FaxLabel;
        private System.Windows.Forms.ComboBox CustomerIDComboBox;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.TextBox ContactNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.TextBox FaxTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
    }
}