namespace DatabaseFirst.Forms.UI
{
    partial class frmSuppliers
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
            Deletebtn = new Button();
            CancelBtn = new Button();
            OkBtn = new Button();
            txtCName = new TextBox();
            txtCTitle = new TextBox();
            txtAddres = new TextBox();
            txtCountry = new TextBox();
            txtRegion = new TextBox();
            txtPostalCode = new TextBox();
            txtCity = new TextBox();
            txtHomePage = new TextBox();
            txtContact = new TextBox();
            txtFax = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtPhone = new MaskedTextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(302, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1120, 602);
            dataGridView1.TabIndex = 0;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.FromArgb(220, 53, 69);
            Deletebtn.FlatStyle = FlatStyle.Flat;
            Deletebtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Deletebtn.Location = new Point(12, 559);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(267, 36);
            Deletebtn.TabIndex = 23;
            Deletebtn.Text = "DELETE";
            Deletebtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.FromArgb(33, 150, 243);
            CancelBtn.FlatStyle = FlatStyle.Popup;
            CancelBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            CancelBtn.Location = new Point(12, 517);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(267, 36);
            CancelBtn.TabIndex = 22;
            CancelBtn.Text = "CLEAN";
            CancelBtn.UseVisualStyleBackColor = false;
            // 
            // OkBtn
            // 
            OkBtn.BackColor = Color.FromArgb(40, 167, 69);
            OkBtn.FlatStyle = FlatStyle.Popup;
            OkBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            OkBtn.Location = new Point(12, 475);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(267, 36);
            OkBtn.TabIndex = 21;
            OkBtn.Text = "OK";
            OkBtn.UseVisualStyleBackColor = false;
            OkBtn.Click += OkBtn_Click;
            // 
            // txtCName
            // 
            txtCName.BorderStyle = BorderStyle.FixedSingle;
            txtCName.Font = new Font("Times New Roman", 10.2F);
            txtCName.Location = new Point(126, 89);
            txtCName.Name = "txtCName";
            txtCName.Size = new Size(153, 27);
            txtCName.TabIndex = 24;
            // 
            // txtCTitle
            // 
            txtCTitle.BorderStyle = BorderStyle.FixedSingle;
            txtCTitle.Font = new Font("Times New Roman", 10.2F);
            txtCTitle.Location = new Point(126, 120);
            txtCTitle.Name = "txtCTitle";
            txtCTitle.Size = new Size(153, 27);
            txtCTitle.TabIndex = 25;
            // 
            // txtAddres
            // 
            txtAddres.BorderStyle = BorderStyle.FixedSingle;
            txtAddres.Font = new Font("Times New Roman", 10.2F);
            txtAddres.Location = new Point(126, 186);
            txtAddres.Name = "txtAddres";
            txtAddres.Size = new Size(153, 27);
            txtAddres.TabIndex = 26;
            // 
            // txtCountry
            // 
            txtCountry.BorderStyle = BorderStyle.FixedSingle;
            txtCountry.Font = new Font("Times New Roman", 10.2F);
            txtCountry.Location = new Point(126, 318);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(153, 27);
            txtCountry.TabIndex = 27;
            // 
            // txtRegion
            // 
            txtRegion.BorderStyle = BorderStyle.FixedSingle;
            txtRegion.Font = new Font("Times New Roman", 10.2F);
            txtRegion.Location = new Point(126, 252);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(153, 27);
            txtRegion.TabIndex = 28;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Times New Roman", 10.2F);
            txtPostalCode.Location = new Point(126, 285);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(153, 27);
            txtPostalCode.TabIndex = 29;
            // 
            // txtCity
            // 
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Times New Roman", 10.2F);
            txtCity.Location = new Point(126, 219);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(153, 27);
            txtCity.TabIndex = 30;
            // 
            // txtHomePage
            // 
            txtHomePage.BorderStyle = BorderStyle.FixedSingle;
            txtHomePage.Font = new Font("Times New Roman", 10.2F);
            txtHomePage.Location = new Point(126, 417);
            txtHomePage.Name = "txtHomePage";
            txtHomePage.Size = new Size(153, 27);
            txtHomePage.TabIndex = 31;
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Times New Roman", 10.2F);
            txtContact.Location = new Point(126, 153);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(153, 27);
            txtContact.TabIndex = 32;
            // 
            // txtFax
            // 
            txtFax.BorderStyle = BorderStyle.FixedSingle;
            txtFax.Font = new Font("Times New Roman", 10.2F);
            txtFax.Location = new Point(126, 384);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(153, 27);
            txtFax.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 5, 22, 21);
            label1.Font = new Font("Times New Roman", 10.8F);
            label1.Location = new Point(51, 92);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 35;
            label1.Text = "C.Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F);
            label2.Location = new Point(55, 160);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 36;
            label2.Text = "Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F);
            label3.Location = new Point(62, 127);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 37;
            label3.Text = "C.Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F);
            label4.Location = new Point(60, 193);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 38;
            label4.Text = "Addres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F);
            label5.Location = new Point(24, 292);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 39;
            label5.Text = "Postal Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F);
            label6.Location = new Point(81, 226);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 39;
            label6.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F);
            label7.Location = new Point(61, 259);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 40;
            label7.Text = "Region";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.8F);
            label8.Location = new Point(52, 325);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 41;
            label8.Text = "Country";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.8F);
            label9.Location = new Point(65, 358);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 41;
            label9.Text = "Phone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.8F);
            label10.Location = new Point(85, 391);
            label10.Name = "label10";
            label10.Size = new Size(35, 20);
            label10.TabIndex = 42;
            label10.Text = "Fax";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.8F);
            label11.Location = new Point(27, 424);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 43;
            label11.Text = "Home Page";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Times New Roman", 10.2F);
            txtPhone.Location = new Point(126, 351);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(153, 27);
            txtPhone.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(65, 9);
            label12.Name = "label12";
            label12.Size = new Size(170, 46);
            label12.TabIndex = 45;
            label12.Text = "Suppliers";
            // 
            // frmSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1422, 602);
            Controls.Add(label12);
            Controls.Add(txtPhone);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFax);
            Controls.Add(txtContact);
            Controls.Add(txtHomePage);
            Controls.Add(txtCity);
            Controls.Add(txtPostalCode);
            Controls.Add(txtRegion);
            Controls.Add(txtCountry);
            Controls.Add(txtAddres);
            Controls.Add(txtCTitle);
            Controls.Add(txtCName);
            Controls.Add(Deletebtn);
            Controls.Add(CancelBtn);
            Controls.Add(OkBtn);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSuppliers";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  ";
            Load += frmSuppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private Button Deletebtn;
        private Button CancelBtn;
        private Button OkBtn;
        private TextBox txtCName;
        private TextBox txtCTitle;
        private TextBox txtAddres;
        private TextBox txtCountry;
        private TextBox txtRegion;
        private TextBox txtPostalCode;
        private TextBox txtCity;
        private TextBox txtHomePage;
        private TextBox txtContact;
        private TextBox txtFax;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private MaskedTextBox txtPhone;
        private Label label12;
    }
}