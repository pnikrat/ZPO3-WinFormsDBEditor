namespace WinFormsDBEditor.View {
    partial class AddEditOrder {
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
            this.customerIdComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.AddNewOrderButton = new System.Windows.Forms.Button();
            this.EmployeeIdLabel = new System.Windows.Forms.Label();
            this.EmployeeIdComboBox = new System.Windows.Forms.ComboBox();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.OrderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.RequiredDateLabel = new System.Windows.Forms.Label();
            this.ShippedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ShippedDateLabel = new System.Windows.Forms.Label();
            this.RequiredDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ShipViaLabel = new System.Windows.Forms.Label();
            this.ShipViaComboBox = new System.Windows.Forms.ComboBox();
            this.FreightLabel = new System.Windows.Forms.Label();
            this.FreightTextBox = new System.Windows.Forms.TextBox();
            this.ShipNameLabel = new System.Windows.Forms.Label();
            this.ShipNameTextBox = new System.Windows.Forms.TextBox();
            this.ShipAddressLabel = new System.Windows.Forms.Label();
            this.ShipAddressTextBox = new System.Windows.Forms.TextBox();
            this.ShipCityLabel = new System.Windows.Forms.Label();
            this.ShipCityTextBox = new System.Windows.Forms.TextBox();
            this.ShipRegionLabel = new System.Windows.Forms.Label();
            this.ShipRegionTextBox = new System.Windows.Forms.TextBox();
            this.ShipPostalCodeLabel = new System.Windows.Forms.Label();
            this.ShipPostalCodeBox = new System.Windows.Forms.MaskedTextBox();
            this.ShipCountryLabel = new System.Windows.Forms.Label();
            this.ShipCountryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customerIdComboBox
            // 
            this.customerIdComboBox.FormattingEnabled = true;
            this.customerIdComboBox.Location = new System.Drawing.Point(130, 12);
            this.customerIdComboBox.Name = "customerIdComboBox";
            this.customerIdComboBox.Size = new System.Drawing.Size(142, 21);
            this.customerIdComboBox.TabIndex = 0;
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(12, 15);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(62, 13);
            this.CustomerIDLabel.TabIndex = 1;
            this.CustomerIDLabel.Text = "CustomerID";
            // 
            // AddNewOrderButton
            // 
            this.AddNewOrderButton.Location = new System.Drawing.Point(15, 376);
            this.AddNewOrderButton.MaximumSize = new System.Drawing.Size(257, 23);
            this.AddNewOrderButton.MinimumSize = new System.Drawing.Size(257, 23);
            this.AddNewOrderButton.Name = "AddNewOrderButton";
            this.AddNewOrderButton.Size = new System.Drawing.Size(257, 23);
            this.AddNewOrderButton.TabIndex = 2;
            this.AddNewOrderButton.Text = "Add new record";
            this.AddNewOrderButton.UseVisualStyleBackColor = true;
            this.AddNewOrderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeIdLabel
            // 
            this.EmployeeIdLabel.AutoSize = true;
            this.EmployeeIdLabel.Location = new System.Drawing.Point(12, 42);
            this.EmployeeIdLabel.Name = "EmployeeIdLabel";
            this.EmployeeIdLabel.Size = new System.Drawing.Size(64, 13);
            this.EmployeeIdLabel.TabIndex = 3;
            this.EmployeeIdLabel.Text = "EmployeeID";
            // 
            // EmployeeIdComboBox
            // 
            this.EmployeeIdComboBox.FormattingEnabled = true;
            this.EmployeeIdComboBox.Location = new System.Drawing.Point(130, 39);
            this.EmployeeIdComboBox.Name = "EmployeeIdComboBox";
            this.EmployeeIdComboBox.Size = new System.Drawing.Size(142, 21);
            this.EmployeeIdComboBox.TabIndex = 4;
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Location = new System.Drawing.Point(12, 66);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(56, 13);
            this.OrderDateLabel.TabIndex = 5;
            this.OrderDateLabel.Text = "OrderDate";
            // 
            // OrderDatePicker
            // 
            this.OrderDatePicker.Location = new System.Drawing.Point(130, 66);
            this.OrderDatePicker.Name = "OrderDatePicker";
            this.OrderDatePicker.Size = new System.Drawing.Size(142, 20);
            this.OrderDatePicker.TabIndex = 6;
            // 
            // RequiredDateLabel
            // 
            this.RequiredDateLabel.AutoSize = true;
            this.RequiredDateLabel.Location = new System.Drawing.Point(12, 92);
            this.RequiredDateLabel.Name = "RequiredDateLabel";
            this.RequiredDateLabel.Size = new System.Drawing.Size(73, 13);
            this.RequiredDateLabel.TabIndex = 7;
            this.RequiredDateLabel.Text = "RequiredDate";
            // 
            // ShippedDatePicker
            // 
            this.ShippedDatePicker.Location = new System.Drawing.Point(130, 118);
            this.ShippedDatePicker.Name = "ShippedDatePicker";
            this.ShippedDatePicker.Size = new System.Drawing.Size(142, 20);
            this.ShippedDatePicker.TabIndex = 8;
            // 
            // ShippedDateLabel
            // 
            this.ShippedDateLabel.AutoSize = true;
            this.ShippedDateLabel.Location = new System.Drawing.Point(12, 118);
            this.ShippedDateLabel.Name = "ShippedDateLabel";
            this.ShippedDateLabel.Size = new System.Drawing.Size(69, 13);
            this.ShippedDateLabel.TabIndex = 9;
            this.ShippedDateLabel.Text = "ShippedDate";
            // 
            // RequiredDatePicker
            // 
            this.RequiredDatePicker.Location = new System.Drawing.Point(130, 92);
            this.RequiredDatePicker.Name = "RequiredDatePicker";
            this.RequiredDatePicker.Size = new System.Drawing.Size(142, 20);
            this.RequiredDatePicker.TabIndex = 10;
            // 
            // ShipViaLabel
            // 
            this.ShipViaLabel.AutoSize = true;
            this.ShipViaLabel.Location = new System.Drawing.Point(12, 147);
            this.ShipViaLabel.Name = "ShipViaLabel";
            this.ShipViaLabel.Size = new System.Drawing.Size(43, 13);
            this.ShipViaLabel.TabIndex = 11;
            this.ShipViaLabel.Text = "ShipVia";
            // 
            // ShipViaComboBox
            // 
            this.ShipViaComboBox.FormattingEnabled = true;
            this.ShipViaComboBox.Location = new System.Drawing.Point(130, 144);
            this.ShipViaComboBox.Name = "ShipViaComboBox";
            this.ShipViaComboBox.Size = new System.Drawing.Size(142, 21);
            this.ShipViaComboBox.TabIndex = 12;
            // 
            // FreightLabel
            // 
            this.FreightLabel.AutoSize = true;
            this.FreightLabel.Location = new System.Drawing.Point(12, 174);
            this.FreightLabel.Name = "FreightLabel";
            this.FreightLabel.Size = new System.Drawing.Size(39, 13);
            this.FreightLabel.TabIndex = 13;
            this.FreightLabel.Text = "Freight";
            // 
            // FreightTextBox
            // 
            this.FreightTextBox.Location = new System.Drawing.Point(130, 171);
            this.FreightTextBox.Name = "FreightTextBox";
            this.FreightTextBox.Size = new System.Drawing.Size(142, 20);
            this.FreightTextBox.TabIndex = 14;
            // 
            // ShipNameLabel
            // 
            this.ShipNameLabel.AutoSize = true;
            this.ShipNameLabel.Location = new System.Drawing.Point(12, 200);
            this.ShipNameLabel.Name = "ShipNameLabel";
            this.ShipNameLabel.Size = new System.Drawing.Size(56, 13);
            this.ShipNameLabel.TabIndex = 15;
            this.ShipNameLabel.Text = "ShipName";
            // 
            // ShipNameTextBox
            // 
            this.ShipNameTextBox.Location = new System.Drawing.Point(130, 197);
            this.ShipNameTextBox.Name = "ShipNameTextBox";
            this.ShipNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.ShipNameTextBox.TabIndex = 16;
            // 
            // ShipAddressLabel
            // 
            this.ShipAddressLabel.AutoSize = true;
            this.ShipAddressLabel.Location = new System.Drawing.Point(12, 224);
            this.ShipAddressLabel.Name = "ShipAddressLabel";
            this.ShipAddressLabel.Size = new System.Drawing.Size(66, 13);
            this.ShipAddressLabel.TabIndex = 17;
            this.ShipAddressLabel.Text = "ShipAddress";
            // 
            // ShipAddressTextBox
            // 
            this.ShipAddressTextBox.Location = new System.Drawing.Point(130, 221);
            this.ShipAddressTextBox.Name = "ShipAddressTextBox";
            this.ShipAddressTextBox.Size = new System.Drawing.Size(142, 20);
            this.ShipAddressTextBox.TabIndex = 18;
            // 
            // ShipCityLabel
            // 
            this.ShipCityLabel.AutoSize = true;
            this.ShipCityLabel.Location = new System.Drawing.Point(12, 250);
            this.ShipCityLabel.Name = "ShipCityLabel";
            this.ShipCityLabel.Size = new System.Drawing.Size(45, 13);
            this.ShipCityLabel.TabIndex = 19;
            this.ShipCityLabel.Text = "ShipCity";
            // 
            // ShipCityTextBox
            // 
            this.ShipCityTextBox.Location = new System.Drawing.Point(130, 247);
            this.ShipCityTextBox.Name = "ShipCityTextBox";
            this.ShipCityTextBox.Size = new System.Drawing.Size(142, 20);
            this.ShipCityTextBox.TabIndex = 20;
            // 
            // ShipRegionLabel
            // 
            this.ShipRegionLabel.AutoSize = true;
            this.ShipRegionLabel.Location = new System.Drawing.Point(12, 276);
            this.ShipRegionLabel.Name = "ShipRegionLabel";
            this.ShipRegionLabel.Size = new System.Drawing.Size(62, 13);
            this.ShipRegionLabel.TabIndex = 21;
            this.ShipRegionLabel.Text = "ShipRegion";
            // 
            // ShipRegionTextBox
            // 
            this.ShipRegionTextBox.Location = new System.Drawing.Point(130, 273);
            this.ShipRegionTextBox.Name = "ShipRegionTextBox";
            this.ShipRegionTextBox.Size = new System.Drawing.Size(142, 20);
            this.ShipRegionTextBox.TabIndex = 22;
            // 
            // ShipPostalCodeLabel
            // 
            this.ShipPostalCodeLabel.AutoSize = true;
            this.ShipPostalCodeLabel.Location = new System.Drawing.Point(12, 302);
            this.ShipPostalCodeLabel.Name = "ShipPostalCodeLabel";
            this.ShipPostalCodeLabel.Size = new System.Drawing.Size(82, 13);
            this.ShipPostalCodeLabel.TabIndex = 23;
            this.ShipPostalCodeLabel.Text = "ShipPostalCode";
            // 
            // ShipPostalCodeBox
            // 
            this.ShipPostalCodeBox.Location = new System.Drawing.Point(130, 299);
            this.ShipPostalCodeBox.Mask = "00-000";
            this.ShipPostalCodeBox.Name = "ShipPostalCodeBox";
            this.ShipPostalCodeBox.Size = new System.Drawing.Size(142, 20);
            this.ShipPostalCodeBox.TabIndex = 24;
            // 
            // ShipCountryLabel
            // 
            this.ShipCountryLabel.AutoSize = true;
            this.ShipCountryLabel.Location = new System.Drawing.Point(12, 328);
            this.ShipCountryLabel.Name = "ShipCountryLabel";
            this.ShipCountryLabel.Size = new System.Drawing.Size(64, 13);
            this.ShipCountryLabel.TabIndex = 25;
            this.ShipCountryLabel.Text = "ShipCountry";
            // 
            // ShipCountryTextBox
            // 
            this.ShipCountryTextBox.Location = new System.Drawing.Point(130, 325);
            this.ShipCountryTextBox.Name = "ShipCountryTextBox";
            this.ShipCountryTextBox.Size = new System.Drawing.Size(142, 20);
            this.ShipCountryTextBox.TabIndex = 26;
            // 
            // AddNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.ShipCountryTextBox);
            this.Controls.Add(this.ShipCountryLabel);
            this.Controls.Add(this.ShipPostalCodeBox);
            this.Controls.Add(this.ShipPostalCodeLabel);
            this.Controls.Add(this.ShipRegionTextBox);
            this.Controls.Add(this.ShipRegionLabel);
            this.Controls.Add(this.ShipCityTextBox);
            this.Controls.Add(this.ShipCityLabel);
            this.Controls.Add(this.ShipAddressTextBox);
            this.Controls.Add(this.ShipAddressLabel);
            this.Controls.Add(this.ShipNameTextBox);
            this.Controls.Add(this.ShipNameLabel);
            this.Controls.Add(this.FreightTextBox);
            this.Controls.Add(this.FreightLabel);
            this.Controls.Add(this.ShipViaComboBox);
            this.Controls.Add(this.ShipViaLabel);
            this.Controls.Add(this.RequiredDatePicker);
            this.Controls.Add(this.ShippedDateLabel);
            this.Controls.Add(this.ShippedDatePicker);
            this.Controls.Add(this.RequiredDateLabel);
            this.Controls.Add(this.OrderDatePicker);
            this.Controls.Add(this.OrderDateLabel);
            this.Controls.Add(this.EmployeeIdComboBox);
            this.Controls.Add(this.EmployeeIdLabel);
            this.Controls.Add(this.AddNewOrderButton);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.customerIdComboBox);
            this.MaximumSize = new System.Drawing.Size(300, 450);
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "AddNewOrder";
            this.Text = "Add New Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerIdComboBox;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Button AddNewOrderButton;
        private System.Windows.Forms.Label EmployeeIdLabel;
        private System.Windows.Forms.ComboBox EmployeeIdComboBox;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.DateTimePicker OrderDatePicker;
        private System.Windows.Forms.Label RequiredDateLabel;
        private System.Windows.Forms.DateTimePicker ShippedDatePicker;
        private System.Windows.Forms.Label ShippedDateLabel;
        private System.Windows.Forms.DateTimePicker RequiredDatePicker;
        private System.Windows.Forms.Label ShipViaLabel;
        private System.Windows.Forms.ComboBox ShipViaComboBox;
        private System.Windows.Forms.Label FreightLabel;
        private System.Windows.Forms.TextBox FreightTextBox;
        private System.Windows.Forms.Label ShipNameLabel;
        private System.Windows.Forms.TextBox ShipNameTextBox;
        private System.Windows.Forms.Label ShipAddressLabel;
        private System.Windows.Forms.TextBox ShipAddressTextBox;
        private System.Windows.Forms.Label ShipCityLabel;
        private System.Windows.Forms.TextBox ShipCityTextBox;
        private System.Windows.Forms.Label ShipRegionLabel;
        private System.Windows.Forms.TextBox ShipRegionTextBox;
        private System.Windows.Forms.Label ShipPostalCodeLabel;
        private System.Windows.Forms.MaskedTextBox ShipPostalCodeBox;
        private System.Windows.Forms.Label ShipCountryLabel;
        private System.Windows.Forms.TextBox ShipCountryTextBox;
    }
}