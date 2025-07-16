namespace DatabaseFirst.Forms.UI
{
    partial class frmOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            dataGridView2 = new DataGridView();
            Product = new DataGridViewComboBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            ProductCategoryName = new DataGridViewTextBoxColumn();
            ProductSupplierCompanyName = new DataGridViewTextBoxColumn();
            ExtendedPrice = new DataGridViewTextBoxColumn();
            bindingSource2 = new BindingSource(components);
            txtCity = new TextBox();
            txtAdress = new TextBox();
            cmbCustomer = new ComboBox();
            cmbEmployee = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtShipName = new TextBox();
            txtShipCountry = new TextBox();
            textBox5 = new TextBox();
            txtRegion = new TextBox();
            txtPostalCode = new TextBox();
            cmbShipVia = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label1 = new Label();
            label17 = new Label();
            label18 = new Label();
            bindingCustomer = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingCustomer).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(336, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(198, 107);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Product, UnitPrice, Quantity, Discount, ProductCategoryName, ProductSupplierCompanyName, ExtendedPrice });
            dataGridView2.Location = new Point(12, 304);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(956, 240);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
            // 
            // Product
            // 
            Product.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Product.HeaderText = "Product";
            Product.MinimumWidth = 6;
            Product.Name = "Product";
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Discount
            // 
            Discount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Discount.HeaderText = "Discount";
            Discount.MinimumWidth = 6;
            Discount.Name = "Discount";
            // 
            // ProductCategoryName
            // 
            ProductCategoryName.HeaderText = "Product Category Name";
            ProductCategoryName.MinimumWidth = 6;
            ProductCategoryName.Name = "ProductCategoryName";
            // 
            // ProductSupplierCompanyName
            // 
            ProductSupplierCompanyName.HeaderText = "Product Supplier Company Name";
            ProductSupplierCompanyName.MinimumWidth = 6;
            ProductSupplierCompanyName.Name = "ProductSupplierCompanyName";
            // 
            // ExtendedPrice
            // 
            ExtendedPrice.HeaderText = "Extended Price";
            ExtendedPrice.MinimumWidth = 6;
            ExtendedPrice.Name = "ExtendedPrice";
            // 
            // bindingSource2
            // 
            bindingSource2.DataSource = typeof(DetailsViewModel);
            // 
            // txtCity
            // 
            txtCity.Location = new Point(694, 126);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(274, 27);
            txtCity.TabIndex = 2;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(694, 83);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(274, 27);
            txtAdress.TabIndex = 4;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(158, 82);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(152, 28);
            cmbCustomer.TabIndex = 5;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            cmbCustomer.DisplayMemberChanged += cmbCustomer_DisplayMemberChanged;
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(158, 119);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(151, 28);
            cmbEmployee.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(889, 565);
            label2.Name = "label2";
            label2.Size = new Size(23, 26);
            label2.TabIndex = 8;
            label2.Text = "0";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(158, 199);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // txtShipName
            // 
            txtShipName.Location = new Point(125, 590);
            txtShipName.Name = "txtShipName";
            txtShipName.Size = new Size(220, 27);
            txtShipName.TabIndex = 11;
            // 
            // txtShipCountry
            // 
            txtShipCountry.Location = new Point(695, 255);
            txtShipCountry.Name = "txtShipCountry";
            txtShipCountry.Size = new Size(272, 27);
            txtShipCountry.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(158, 235);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(152, 27);
            textBox5.TabIndex = 13;
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(694, 169);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(274, 27);
            txtRegion.TabIndex = 14;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(695, 212);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(272, 27);
            txtPostalCode.TabIndex = 16;
            // 
            // cmbShipVia
            // 
            cmbShipVia.FormattingEnabled = true;
            cmbShipVia.Location = new Point(125, 630);
            cmbShipVia.Name = "cmbShipVia";
            cmbShipVia.Size = new Size(151, 28);
            cmbShipVia.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 19;
            label3.Text = "Customer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(562, 259);
            label4.Name = "label4";
            label4.Size = new Size(127, 23);
            label4.TabIndex = 20;
            label4.Text = "Ship Country:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(12, 631);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 21;
            label5.Text = "Ship Via:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(12, 202);
            label6.Name = "label6";
            label6.Size = new Size(140, 23);
            label6.TabIndex = 22;
            label6.Text = "Required Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(12, 160);
            label7.Name = "label7";
            label7.Size = new Size(115, 23);
            label7.TabIndex = 23;
            label7.Text = "Order Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(12, 239);
            label8.Name = "label8";
            label8.Size = new Size(129, 23);
            label8.TabIndex = 24;
            label8.Text = "Shipped Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.Location = new Point(562, 87);
            label9.Name = "label9";
            label9.Size = new Size(75, 23);
            label9.TabIndex = 25;
            label9.Text = "Adress:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.Location = new Point(562, 130);
            label10.Name = "label10";
            label10.Size = new Size(53, 23);
            label10.TabIndex = 26;
            label10.Text = "City:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label11.Location = new Point(12, 594);
            label11.Name = "label11";
            label11.Size = new Size(107, 23);
            label11.TabIndex = 27;
            label11.Text = "Ship Name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label12.Location = new Point(796, 568);
            label12.Name = "label12";
            label12.Size = new Size(87, 23);
            label12.TabIndex = 28;
            label12.Text = "Subtotal:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label13.Location = new Point(562, 216);
            label13.Name = "label13";
            label13.Size = new Size(118, 23);
            label13.TabIndex = 29;
            label13.Text = "Postal Code:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label14.Location = new Point(562, 173);
            label14.Name = "label14";
            label14.Size = new Size(76, 23);
            label14.TabIndex = 30;
            label14.Text = "Region:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label15.Location = new Point(12, 120);
            label15.Name = "label15";
            label15.Size = new Size(100, 23);
            label15.TabIndex = 31;
            label15.Text = "Employee:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label16.Location = new Point(796, 599);
            label16.Name = "label16";
            label16.Size = new Size(78, 23);
            label16.TabIndex = 32;
            label16.Text = "Freight:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(158, 156);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(152, 27);
            dateTimePicker3.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(889, 630);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 34;
            label1.Text = "Total";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label17.Location = new Point(889, 599);
            label17.Name = "label17";
            label17.Size = new Size(78, 23);
            label17.TabIndex = 35;
            label17.Text = "Freight:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label18.Location = new Point(796, 630);
            label18.Name = "label18";
            label18.Size = new Size(60, 23);
            label18.TabIndex = 36;
            label18.Text = "Total:";
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(979, 663);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label1);
            Controls.Add(dateTimePicker3);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbShipVia);
            Controls.Add(txtPostalCode);
            Controls.Add(txtRegion);
            Controls.Add(textBox5);
            Controls.Add(txtShipCountry);
            Controls.Add(txtShipName);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(cmbEmployee);
            Controls.Add(cmbCustomer);
            Controls.Add(txtAdress);
            Controls.Add(txtCity);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmOrders";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private DataGridView dataGridView2;
        private BindingSource bindingSource2;
        private TextBox txtCity;
        private TextBox txtAdress;
        private ComboBox cmbCustomer;
        private ComboBox cmbEmployee;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtShipName;
        private TextBox txtShipCountry;
        private TextBox textBox5;
        private TextBox txtRegion;
        private TextBox txtPostalCode;
        private DataGridViewComboBoxColumn Product;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn ProductCategoryName;
        private DataGridViewTextBoxColumn ProductSupplierCompanyName;
        private DataGridViewTextBoxColumn ExtendedPrice;
        private ComboBox cmbShipVia;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private DateTimePicker dateTimePicker3;
        private Label label1;
        private Label label17;
        private Label label18;
        private BindingSource bindingCustomer;
    }
}