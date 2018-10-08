﻿namespace Accounting.App
{
	partial class frmNewAccounting
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewAccounting));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvCustomers = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rbRecive = new System.Windows.Forms.RadioButton();
			this.rbPay = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
			this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvCustomers);
			this.groupBox1.Controls.Add(this.txtFilter);
			this.groupBox1.Location = new System.Drawing.Point(12, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(182, 309);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "اشخاص";
			// 
			// dgvCustomers
			// 
			this.dgvCustomers.AllowUserToAddRows = false;
			this.dgvCustomers.AllowUserToDeleteRows = false;
			this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
			this.dgvCustomers.Location = new System.Drawing.Point(6, 47);
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.ReadOnly = true;
			this.dgvCustomers.Size = new System.Drawing.Size(170, 256);
			this.dgvCustomers.TabIndex = 1;
			this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "FullName";
			this.Column1.HeaderText = "نام شخص";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(6, 20);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(170, 21);
			this.txtFilter.TabIndex = 0;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(505, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "طرف حساب:";
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(222, 22);
			this.textName.Name = "textName";
			this.textName.ReadOnly = true;
			this.textName.Size = new System.Drawing.Size(277, 21);
			this.textName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(509, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "نوع تراکنش:";
			// 
			// rbRecive
			// 
			this.rbRecive.AutoSize = true;
			this.rbRecive.Location = new System.Drawing.Point(425, 55);
			this.rbRecive.Name = "rbRecive";
			this.rbRecive.Size = new System.Drawing.Size(55, 17);
			this.rbRecive.TabIndex = 4;
			this.rbRecive.TabStop = true;
			this.rbRecive.Text = "دریافت";
			this.rbRecive.UseVisualStyleBackColor = true;
			// 
			// rbPay
			// 
			this.rbPay.AutoSize = true;
			this.rbPay.Location = new System.Drawing.Point(350, 57);
			this.rbPay.Name = "rbPay";
			this.rbPay.Size = new System.Drawing.Size(58, 17);
			this.rbPay.TabIndex = 5;
			this.rbPay.TabStop = true;
			this.rbPay.Text = "پرداخت";
			this.rbPay.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(515, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "مبلغ:";
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(222, 86);
			this.txtAmount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(287, 21);
			this.txtAmount.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(515, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "توضیح سند:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(222, 116);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(287, 179);
			this.txtDescription.TabIndex = 9;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(434, 305);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "ثبت";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// rangeValidator1
			// 
			this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
			this.rangeValidator1.ControlToValidate = this.txtAmount;
			this.rangeValidator1.ErrorMessage = "مبلغ را وارد کنید!";
			this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
			this.rangeValidator1.MaximumValue = "999999999999";
			this.rangeValidator1.MinimumValue = "1";
			this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
			// 
			// requiredFieldValidator1
			// 
			this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
			this.requiredFieldValidator1.ControlToValidate = this.textName;
			this.requiredFieldValidator1.ErrorMessage = "نام طرف حساب را مشخص کنید";
			this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
			// 
			// frmNewAccounting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.rbPay);
			this.Controls.Add(this.rbRecive);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmNewAccounting";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "تراکنش جدید";
			this.Load += new System.EventHandler(this.frmNewAccounting_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvCustomers;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbRecive;
		private System.Windows.Forms.RadioButton rbPay;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown txtAmount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button btnSave;
		private ValidationComponents.RangeValidator rangeValidator1;
		private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
	}
}