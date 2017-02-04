namespace WinFormsDBEditor {
    partial class MainView {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TablesTabControl = new System.Windows.Forms.TabControl();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.CustomersPage = new System.Windows.Forms.TabPage();
            this.CustomersGridView = new System.Windows.Forms.DataGridView();
            this.ProductsPage = new System.Windows.Forms.TabPage();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NewRecordButton = new System.Windows.Forms.Button();
            this.EditRecordButton = new System.Windows.Forms.Button();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.TablesTabControl.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.CustomersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).BeginInit();
            this.ProductsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TablesTabControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TablesTabControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TablesTabControl, 2);
            this.TablesTabControl.Controls.Add(this.OrdersPage);
            this.TablesTabControl.Controls.Add(this.CustomersPage);
            this.TablesTabControl.Controls.Add(this.ProductsPage);
            this.TablesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablesTabControl.Location = new System.Drawing.Point(3, 79);
            this.TablesTabControl.Name = "TablesTabControl";
            this.TablesTabControl.SelectedIndex = 0;
            this.TablesTabControl.Size = new System.Drawing.Size(778, 679);
            this.TablesTabControl.TabIndex = 3;
            this.TablesTabControl.SelectedIndexChanged += new System.EventHandler(this.TablesTabControl_SelectedIndexChanged);
            // 
            // OrdersPage
            // 
            this.OrdersPage.Controls.Add(this.OrdersGridView);
            this.OrdersPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Size = new System.Drawing.Size(770, 573);
            this.OrdersPage.TabIndex = 0;
            this.OrdersPage.Text = "Orders";
            this.OrdersPage.UseVisualStyleBackColor = true;
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersGridView.Location = new System.Drawing.Point(0, 0);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.Size = new System.Drawing.Size(770, 573);
            this.OrdersGridView.TabIndex = 0;
            // 
            // CustomersPage
            // 
            this.CustomersPage.Controls.Add(this.CustomersGridView);
            this.CustomersPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersPage.Name = "CustomersPage";
            this.CustomersPage.Size = new System.Drawing.Size(770, 573);
            this.CustomersPage.TabIndex = 1;
            this.CustomersPage.Text = "Customers";
            this.CustomersPage.UseVisualStyleBackColor = true;
            // 
            // CustomersGridView
            // 
            this.CustomersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersGridView.Location = new System.Drawing.Point(0, 0);
            this.CustomersGridView.Name = "CustomersGridView";
            this.CustomersGridView.Size = new System.Drawing.Size(770, 573);
            this.CustomersGridView.TabIndex = 0;
            // 
            // ProductsPage
            // 
            this.ProductsPage.Controls.Add(this.ProductsGridView);
            this.ProductsPage.Location = new System.Drawing.Point(4, 22);
            this.ProductsPage.Name = "ProductsPage";
            this.ProductsPage.Size = new System.Drawing.Size(770, 653);
            this.ProductsPage.TabIndex = 2;
            this.ProductsPage.Text = "Products";
            this.ProductsPage.UseVisualStyleBackColor = true;
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsGridView.Location = new System.Drawing.Point(0, 0);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.Size = new System.Drawing.Size(770, 653);
            this.ProductsGridView.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.StatusLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(800, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 70);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.StatusLabel, 4);
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.Location = new System.Drawing.Point(10, 5);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(58, 22);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Controls.Add(this.NewRecordButton);
            this.flowLayoutPanel1.Controls.Add(this.EditRecordButton);
            this.flowLayoutPanel1.Controls.Add(this.DeleteRecordButton);
            this.flowLayoutPanel1.Controls.Add(this.FilterButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(480, 35);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // NewRecordButton
            // 
            this.NewRecordButton.AutoSize = true;
            this.NewRecordButton.Location = new System.Drawing.Point(10, 10);
            this.NewRecordButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.NewRecordButton.Name = "NewRecordButton";
            this.NewRecordButton.Size = new System.Drawing.Size(53, 23);
            this.NewRecordButton.TabIndex = 0;
            this.NewRecordButton.Text = "button1";
            this.NewRecordButton.UseVisualStyleBackColor = true;
            this.NewRecordButton.Click += new System.EventHandler(this.NewRecordButton_Click);
            // 
            // EditRecordButton
            // 
            this.EditRecordButton.AutoSize = true;
            this.EditRecordButton.Location = new System.Drawing.Point(83, 10);
            this.EditRecordButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.EditRecordButton.Name = "EditRecordButton";
            this.EditRecordButton.Size = new System.Drawing.Size(53, 23);
            this.EditRecordButton.TabIndex = 1;
            this.EditRecordButton.Text = "button1";
            this.EditRecordButton.UseVisualStyleBackColor = true;
            this.EditRecordButton.Click += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.AutoSize = true;
            this.DeleteRecordButton.Location = new System.Drawing.Point(156, 10);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(53, 23);
            this.DeleteRecordButton.TabIndex = 2;
            this.DeleteRecordButton.Text = "button1";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.AutoSize = true;
            this.FilterButton.Location = new System.Drawing.Point(229, 10);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(53, 23);
            this.FilterButton.TabIndex = 3;
            this.FilterButton.Text = "button1";
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "MainView";
            this.Text = "Nwind DB Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TablesTabControl.ResumeLayout(false);
            this.OrdersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.CustomersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).EndInit();
            this.ProductsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl TablesTabControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button NewRecordButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button EditRecordButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage OrdersPage;
        private System.Windows.Forms.TabPage CustomersPage;
        private System.Windows.Forms.TabPage ProductsPage;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.DataGridView CustomersGridView;
        private System.Windows.Forms.DataGridView ProductsGridView;
    }
}

