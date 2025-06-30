namespace DatabaseFirst
{
    partial class frmProducts
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
            dgvProducts = new DataGridView();
            txtCategory = new TextBox();
            txtProduct = new TextBox();
            txtQPU = new TextBox();
            txtUnitInStock = new TextBox();
            txtUnitOnOrder = new TextBox();
            txtSupplier = new TextBox();
            txtUnitprice = new TextBox();
            txtReordderLevel = new TextBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            OkBtn = new Button();
            CancelBtn = new Button();
            Deletebtn = new Button();
            label9 = new Label();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Right;
            dgvProducts.Location = new Point(302, 0);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvProducts.Size = new Size(1120, 602);
            dgvProducts.TabIndex = 0;
            // 
            // txtCategory
            // 
            txtCategory.BorderStyle = BorderStyle.FixedSingle;
            txtCategory.Font = new Font("Times New Roman", 10.2F);
            txtCategory.Location = new Point(154, 121);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(125, 27);
            txtCategory.TabIndex = 1;
            // 
            // txtProduct
            // 
            txtProduct.BorderStyle = BorderStyle.FixedSingle;
            txtProduct.Font = new Font("Times New Roman", 10.2F);
            txtProduct.Location = new Point(154, 79);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(125, 27);
            txtProduct.TabIndex = 2;
            // 
            // txtQPU
            // 
            txtQPU.BorderStyle = BorderStyle.FixedSingle;
            txtQPU.Font = new Font("Times New Roman", 10.2F);
            txtQPU.Location = new Point(154, 205);
            txtQPU.Name = "txtQPU";
            txtQPU.Size = new Size(125, 27);
            txtQPU.TabIndex = 3;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.BorderStyle = BorderStyle.FixedSingle;
            txtUnitInStock.Font = new Font("Times New Roman", 10.2F);
            txtUnitInStock.Location = new Point(154, 289);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(125, 27);
            txtUnitInStock.TabIndex = 4;
            // 
            // txtUnitOnOrder
            // 
            txtUnitOnOrder.BorderStyle = BorderStyle.FixedSingle;
            txtUnitOnOrder.Font = new Font("Times New Roman", 10.2F);
            txtUnitOnOrder.Location = new Point(154, 331);
            txtUnitOnOrder.Name = "txtUnitOnOrder";
            txtUnitOnOrder.Size = new Size(125, 27);
            txtUnitOnOrder.TabIndex = 5;
            // 
            // txtSupplier
            // 
            txtSupplier.BorderStyle = BorderStyle.FixedSingle;
            txtSupplier.Font = new Font("Times New Roman", 10.2F);
            txtSupplier.Location = new Point(154, 163);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(125, 27);
            txtSupplier.TabIndex = 6;
            // 
            // txtUnitprice
            // 
            txtUnitprice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitprice.Font = new Font("Times New Roman", 10.2F);
            txtUnitprice.Location = new Point(154, 247);
            txtUnitprice.Name = "txtUnitprice";
            txtUnitprice.Size = new Size(125, 27);
            txtUnitprice.TabIndex = 7;
            // 
            // txtReordderLevel
            // 
            txtReordderLevel.BorderStyle = BorderStyle.FixedSingle;
            txtReordderLevel.Font = new Font("Times New Roman", 10.2F);
            txtReordderLevel.Location = new Point(154, 373);
            txtReordderLevel.Name = "txtReordderLevel";
            txtReordderLevel.Size = new Size(125, 27);
            txtReordderLevel.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(143, 415);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 26);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Discontinued";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(74, 84);
            label1.Name = "label1";
            label1.Size = new Size(71, 22);
            label1.TabIndex = 10;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(64, 125);
            label2.Name = "label2";
            label2.Size = new Size(81, 22);
            label2.TabIndex = 11;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(67, 166);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 12;
            label3.Text = "Supplier";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(-1, 210);
            label4.Name = "label4";
            label4.Size = new Size(146, 22);
            label4.TabIndex = 13;
            label4.Text = "Quantity Per Unit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(55, 248);
            label5.Name = "label5";
            label5.Size = new Size(90, 22);
            label5.TabIndex = 14;
            label5.Text = "Unit Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(20, 371);
            label6.Name = "label6";
            label6.Size = new Size(125, 22);
            label6.TabIndex = 15;
            label6.Text = "Reorder Level";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F);
            label7.Location = new Point(33, 289);
            label7.Name = "label7";
            label7.Size = new Size(112, 22);
            label7.TabIndex = 16;
            label7.Text = "Unit in Stock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F);
            label8.Location = new Point(30, 330);
            label8.Name = "label8";
            label8.Size = new Size(115, 22);
            label8.TabIndex = 17;
            label8.Text = "Unit on order";
            // 
            // OkBtn
            // 
            OkBtn.BackColor = Color.FromArgb(40, 167, 69);
            OkBtn.FlatStyle = FlatStyle.Popup;
            OkBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            OkBtn.Location = new Point(12, 471);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(267, 36);
            OkBtn.TabIndex = 18;
            OkBtn.Text = "OK";
            OkBtn.UseVisualStyleBackColor = false;
            OkBtn.Click += OkBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.FromArgb(33, 150, 243);
            CancelBtn.FlatStyle = FlatStyle.Popup;
            CancelBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            CancelBtn.Location = new Point(12, 513);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(267, 36);
            CancelBtn.TabIndex = 19;
            CancelBtn.Text = "CANCEL";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.FromArgb(220, 53, 69);
            Deletebtn.FlatStyle = FlatStyle.Popup;
            Deletebtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Deletebtn.Location = new Point(12, 555);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(267, 36);
            Deletebtn.TabIndex = 20;
            Deletebtn.Text = "DELETE";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(30, 9);
            label9.Name = "label9";
            label9.Size = new Size(237, 46);
            label9.TabIndex = 21;
            label9.Text = "Product Form";
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1422, 602);
            Controls.Add(label9);
            Controls.Add(Deletebtn);
            Controls.Add(CancelBtn);
            Controls.Add(OkBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(txtReordderLevel);
            Controls.Add(txtUnitprice);
            Controls.Add(txtSupplier);
            Controls.Add(txtUnitOnOrder);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtQPU);
            Controls.Add(txtProduct);
            Controls.Add(txtCategory);
            Controls.Add(dgvProducts);
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private TextBox txtCategory;
        private TextBox txtProduct;
        private TextBox txtQPU;
        private TextBox txtUnitInStock;
        private TextBox txtUnitOnOrder;
        private TextBox txtSupplier;
        private TextBox txtUnitprice;
        private TextBox txtReordderLevel;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button OkBtn;
        private Button CancelBtn;
        private Button Deletebtn;
        private Label label9;
        private BindingSource bindingSource1;
    }
}