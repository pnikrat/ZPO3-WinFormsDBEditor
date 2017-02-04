namespace WinFormsDBEditor.View {
    partial class AddEditProduct {
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
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.SupplierIDLabel = new System.Windows.Forms.Label();
            this.SupplierIDComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryIDLabel = new System.Windows.Forms.Label();
            this.CategoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityPerUnitLabel = new System.Windows.Forms.Label();
            this.QuantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.UnitsInStockLabel = new System.Windows.Forms.Label();
            this.UnitsInStockTextBox = new System.Windows.Forms.TextBox();
            this.UnitsOnOrderLabel = new System.Windows.Forms.Label();
            this.UnitsOnOrderTextBox = new System.Windows.Forms.TextBox();
            this.ReorderLevelLabel = new System.Windows.Forms.Label();
            this.ReorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.DiscontinuedCheckbox = new System.Windows.Forms.CheckBox();
            this.AddNewProductButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(12, 15);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(72, 13);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "ProductName";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(130, 12);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.ProductNameTextBox.TabIndex = 1;
            // 
            // SupplierIDLabel
            // 
            this.SupplierIDLabel.AutoSize = true;
            this.SupplierIDLabel.Location = new System.Drawing.Point(12, 41);
            this.SupplierIDLabel.Name = "SupplierIDLabel";
            this.SupplierIDLabel.Size = new System.Drawing.Size(56, 13);
            this.SupplierIDLabel.TabIndex = 2;
            this.SupplierIDLabel.Text = "SupplierID";
            // 
            // SupplierIDComboBox
            // 
            this.SupplierIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierIDComboBox.FormattingEnabled = true;
            this.SupplierIDComboBox.Location = new System.Drawing.Point(130, 38);
            this.SupplierIDComboBox.Name = "SupplierIDComboBox";
            this.SupplierIDComboBox.Size = new System.Drawing.Size(142, 21);
            this.SupplierIDComboBox.TabIndex = 2;
            // 
            // CategoryIDLabel
            // 
            this.CategoryIDLabel.AutoSize = true;
            this.CategoryIDLabel.Location = new System.Drawing.Point(12, 68);
            this.CategoryIDLabel.Name = "CategoryIDLabel";
            this.CategoryIDLabel.Size = new System.Drawing.Size(60, 13);
            this.CategoryIDLabel.TabIndex = 4;
            this.CategoryIDLabel.Text = "CategoryID";
            // 
            // CategoryIDComboBox
            // 
            this.CategoryIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryIDComboBox.FormattingEnabled = true;
            this.CategoryIDComboBox.Location = new System.Drawing.Point(130, 65);
            this.CategoryIDComboBox.Name = "CategoryIDComboBox";
            this.CategoryIDComboBox.Size = new System.Drawing.Size(142, 21);
            this.CategoryIDComboBox.TabIndex = 3;
            // 
            // QuantityPerUnitLabel
            // 
            this.QuantityPerUnitLabel.AutoSize = true;
            this.QuantityPerUnitLabel.Location = new System.Drawing.Point(12, 95);
            this.QuantityPerUnitLabel.Name = "QuantityPerUnitLabel";
            this.QuantityPerUnitLabel.Size = new System.Drawing.Size(81, 13);
            this.QuantityPerUnitLabel.TabIndex = 6;
            this.QuantityPerUnitLabel.Text = "QuantityPerUnit";
            // 
            // QuantityPerUnitTextBox
            // 
            this.QuantityPerUnitTextBox.Location = new System.Drawing.Point(130, 92);
            this.QuantityPerUnitTextBox.Name = "QuantityPerUnitTextBox";
            this.QuantityPerUnitTextBox.Size = new System.Drawing.Size(142, 20);
            this.QuantityPerUnitTextBox.TabIndex = 4;
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(12, 121);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(50, 13);
            this.UnitPriceLabel.TabIndex = 8;
            this.UnitPriceLabel.Text = "UnitPrice";
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Location = new System.Drawing.Point(130, 118);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.Size = new System.Drawing.Size(142, 20);
            this.UnitPriceTextBox.TabIndex = 5;
            this.UnitPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitPriceTextBox_KeyPress);
            // 
            // UnitsInStockLabel
            // 
            this.UnitsInStockLabel.AutoSize = true;
            this.UnitsInStockLabel.Location = new System.Drawing.Point(12, 147);
            this.UnitsInStockLabel.Name = "UnitsInStockLabel";
            this.UnitsInStockLabel.Size = new System.Drawing.Size(68, 13);
            this.UnitsInStockLabel.TabIndex = 10;
            this.UnitsInStockLabel.Text = "UnitsInStock";
            // 
            // UnitsInStockTextBox
            // 
            this.UnitsInStockTextBox.Location = new System.Drawing.Point(130, 144);
            this.UnitsInStockTextBox.Name = "UnitsInStockTextBox";
            this.UnitsInStockTextBox.Size = new System.Drawing.Size(142, 20);
            this.UnitsInStockTextBox.TabIndex = 6;
            this.UnitsInStockTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitsInStockTextBox_KeyPress);
            // 
            // UnitsOnOrderLabel
            // 
            this.UnitsOnOrderLabel.AutoSize = true;
            this.UnitsOnOrderLabel.Location = new System.Drawing.Point(12, 173);
            this.UnitsOnOrderLabel.Name = "UnitsOnOrderLabel";
            this.UnitsOnOrderLabel.Size = new System.Drawing.Size(71, 13);
            this.UnitsOnOrderLabel.TabIndex = 12;
            this.UnitsOnOrderLabel.Text = "UnitsOnOrder";
            // 
            // UnitsOnOrderTextBox
            // 
            this.UnitsOnOrderTextBox.Location = new System.Drawing.Point(130, 170);
            this.UnitsOnOrderTextBox.Name = "UnitsOnOrderTextBox";
            this.UnitsOnOrderTextBox.Size = new System.Drawing.Size(142, 20);
            this.UnitsOnOrderTextBox.TabIndex = 7;
            this.UnitsOnOrderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitsOnOrderTextBox_KeyPress);
            // 
            // ReorderLevelLabel
            // 
            this.ReorderLevelLabel.AutoSize = true;
            this.ReorderLevelLabel.Location = new System.Drawing.Point(12, 199);
            this.ReorderLevelLabel.Name = "ReorderLevelLabel";
            this.ReorderLevelLabel.Size = new System.Drawing.Size(71, 13);
            this.ReorderLevelLabel.TabIndex = 14;
            this.ReorderLevelLabel.Text = "ReorderLevel";
            // 
            // ReorderLevelTextBox
            // 
            this.ReorderLevelTextBox.Location = new System.Drawing.Point(130, 196);
            this.ReorderLevelTextBox.Name = "ReorderLevelTextBox";
            this.ReorderLevelTextBox.Size = new System.Drawing.Size(142, 20);
            this.ReorderLevelTextBox.TabIndex = 8;
            this.ReorderLevelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReorderLevelTextBox_KeyPress);
            // 
            // DiscontinuedCheckbox
            // 
            this.DiscontinuedCheckbox.AutoSize = true;
            this.DiscontinuedCheckbox.Location = new System.Drawing.Point(15, 228);
            this.DiscontinuedCheckbox.Name = "DiscontinuedCheckbox";
            this.DiscontinuedCheckbox.Size = new System.Drawing.Size(88, 17);
            this.DiscontinuedCheckbox.TabIndex = 9;
            this.DiscontinuedCheckbox.Text = "Discontinued";
            this.DiscontinuedCheckbox.UseVisualStyleBackColor = true;
            // 
            // AddNewProductButton
            // 
            this.AddNewProductButton.Location = new System.Drawing.Point(15, 279);
            this.AddNewProductButton.Name = "AddNewProductButton";
            this.AddNewProductButton.Size = new System.Drawing.Size(257, 23);
            this.AddNewProductButton.TabIndex = 10;
            this.AddNewProductButton.Text = "Add new record";
            this.AddNewProductButton.UseVisualStyleBackColor = true;
            this.AddNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 314);
            this.Controls.Add(this.AddNewProductButton);
            this.Controls.Add(this.DiscontinuedCheckbox);
            this.Controls.Add(this.ReorderLevelTextBox);
            this.Controls.Add(this.ReorderLevelLabel);
            this.Controls.Add(this.UnitsOnOrderTextBox);
            this.Controls.Add(this.UnitsOnOrderLabel);
            this.Controls.Add(this.UnitsInStockTextBox);
            this.Controls.Add(this.UnitsInStockLabel);
            this.Controls.Add(this.UnitPriceTextBox);
            this.Controls.Add(this.UnitPriceLabel);
            this.Controls.Add(this.QuantityPerUnitTextBox);
            this.Controls.Add(this.QuantityPerUnitLabel);
            this.Controls.Add(this.CategoryIDComboBox);
            this.Controls.Add(this.CategoryIDLabel);
            this.Controls.Add(this.SupplierIDComboBox);
            this.Controls.Add(this.SupplierIDLabel);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductNameLabel);
            this.MaximumSize = new System.Drawing.Size(310, 353);
            this.MinimumSize = new System.Drawing.Size(310, 353);
            this.Name = "AddEditProduct";
            this.Text = "Add New Product";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label SupplierIDLabel;
        private System.Windows.Forms.ComboBox SupplierIDComboBox;
        private System.Windows.Forms.Label CategoryIDLabel;
        private System.Windows.Forms.ComboBox CategoryIDComboBox;
        private System.Windows.Forms.Label QuantityPerUnitLabel;
        private System.Windows.Forms.TextBox QuantityPerUnitTextBox;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.Label UnitsInStockLabel;
        private System.Windows.Forms.TextBox UnitsInStockTextBox;
        private System.Windows.Forms.Label UnitsOnOrderLabel;
        private System.Windows.Forms.TextBox UnitsOnOrderTextBox;
        private System.Windows.Forms.Label ReorderLevelLabel;
        private System.Windows.Forms.TextBox ReorderLevelTextBox;
        private System.Windows.Forms.CheckBox DiscontinuedCheckbox;
        private System.Windows.Forms.Button AddNewProductButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}