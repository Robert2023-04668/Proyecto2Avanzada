﻿namespace DatabaseFirst.Forms.UI
{
    partial class frmCategories
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
            bindingSource1 = new BindingSource(components);
            dgvCategory = new DataGridView();
            txtName = new TextBox();
            categoryViewModelBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            Deletebtn = new Button();
            CancelBtn = new Button();
            OkBtn = new Button();
            label3 = new Label();
            txtDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.BackgroundColor = Color.WhiteSmoke;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Dock = DockStyle.Right;
            dgvCategory.Location = new Point(314, 0);
            dgvCategory.MultiSelect = false;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvCategory.Size = new Size(567, 561);
            dgvCategory.TabIndex = 0;
            dgvCategory.SelectionChanged += dgvCategory_SelectionChanged;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.DataBindings.Add(new Binding("Text", categoryViewModelBindingSource, "CategoryName", true));
            txtName.Font = new Font("Times New Roman", 12F);
            txtName.Location = new Point(116, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(181, 30);
            txtName.TabIndex = 1;
            // 
            // categoryViewModelBindingSource
            // 
            categoryViewModelBindingSource.DataSource = typeof(CategoryViewModel);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(7, 158);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 3;
            label1.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(54, 110);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.FromArgb(220, 53, 69);
            Deletebtn.FlatStyle = FlatStyle.Popup;
            Deletebtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Deletebtn.Location = new Point(12, 514);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(285, 36);
            Deletebtn.TabIndex = 23;
            Deletebtn.Text = "DELETE";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.FromArgb(33, 150, 243);
            CancelBtn.FlatStyle = FlatStyle.Popup;
            CancelBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            CancelBtn.Location = new Point(12, 472);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(285, 36);
            CancelBtn.TabIndex = 22;
            CancelBtn.Text = "CLEAN";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // OkBtn
            // 
            OkBtn.BackColor = Color.FromArgb(40, 167, 69);
            OkBtn.FlatStyle = FlatStyle.Popup;
            OkBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            OkBtn.Location = new Point(12, 430);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(285, 36);
            OkBtn.TabIndex = 21;
            OkBtn.Text = "OK";
            OkBtn.UseVisualStyleBackColor = false;
            OkBtn.Click += OkBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 19);
            label3.Name = "label3";
            label3.Size = new Size(189, 46);
            label3.TabIndex = 24;
            label3.Text = "Categories";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.DataBindings.Add(new Binding("Text", categoryViewModelBindingSource, "Description", true));
            txtDescription.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(116, 158);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(181, 90);
            txtDescription.TabIndex = 25;
            txtDescription.Text = "";
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(881, 561);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(Deletebtn);
            Controls.Add(CancelBtn);
            Controls.Add(OkBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(dgvCategory);
            Name = "frmCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategories";
            Load += frmCategories_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private DataGridView dgvCategory;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Button Deletebtn;
        private Button CancelBtn;
        private Button OkBtn;
        private Label label3;
        private RichTextBox txtDescription;
        private BindingSource categoryViewModelBindingSource;
    }
}