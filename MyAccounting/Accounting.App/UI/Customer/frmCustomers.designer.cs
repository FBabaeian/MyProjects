﻿namespace Accounting.App
{
	partial class frmCustomers
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnAddNewCustomer = new System.Windows.Forms.ToolStripButton();
			this.btnEditCustomer = new System.Windows.Forms.ToolStripButton();
			this.btnDeleteCustomer = new System.Windows.Forms.ToolStripButton();
			this.btnRefreshCustomer = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
			this.dgvCustomers = new System.Windows.Forms.DataGridView();
			this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewCustomer,
            this.btnEditCustomer,
            this.btnDeleteCustomer,
            this.btnRefreshCustomer,
            this.toolStripLabel1,
            this.txtFilter});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(584, 61);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnAddNewCustomer
			// 
			this.btnAddNewCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNewCustomer.Image = global::Accounting.App.Properties.Resources._1371475930_filenew;
			this.btnAddNewCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnAddNewCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAddNewCustomer.Name = "btnAddNewCustomer";
			this.btnAddNewCustomer.Size = new System.Drawing.Size(74, 58);
			this.btnAddNewCustomer.Text = "شخص جدید";
			this.btnAddNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
			// 
			// btnEditCustomer
			// 
			this.btnEditCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditCustomer.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
			this.btnEditCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnEditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditCustomer.Name = "btnEditCustomer";
			this.btnEditCustomer.Size = new System.Drawing.Size(84, 58);
			this.btnEditCustomer.Text = "ویرایش شخص";
			this.btnEditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
			// 
			// btnDeleteCustomer
			// 
			this.btnDeleteCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteCustomer.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
			this.btnDeleteCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnDeleteCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDeleteCustomer.Name = "btnDeleteCustomer";
			this.btnDeleteCustomer.Size = new System.Drawing.Size(74, 58);
			this.btnDeleteCustomer.Text = "حذف شخص";
			this.btnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
			// 
			// btnRefreshCustomer
			// 
			this.btnRefreshCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefreshCustomer.Image = global::Accounting.App.Properties.Resources._1371476394_refresh_red;
			this.btnRefreshCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnRefreshCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRefreshCustomer.Name = "btnRefreshCustomer";
			this.btnRefreshCustomer.Size = new System.Drawing.Size(63, 58);
			this.btnRefreshCustomer.Text = "بروزرسانی";
			this.btnRefreshCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnRefreshCustomer.Click += new System.EventHandler(this.btnRefreshCustomer_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(53, 58);
			this.toolStripLabel1.Text = "جستجو: ";
			// 
			// txtFilter
			// 
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(100, 61);
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			// 
			// dgvCustomers
			// 
			this.dgvCustomers.AllowUserToAddRows = false;
			this.dgvCustomers.AllowUserToDeleteRows = false;
			this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.Column1,
            this.Column2,
            this.Column3});
			this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCustomers.Location = new System.Drawing.Point(0, 61);
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.ReadOnly = true;
			this.dgvCustomers.Size = new System.Drawing.Size(584, 300);
			this.dgvCustomers.TabIndex = 1;
			this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
			// 
			// CustomerID
			// 
			this.CustomerID.DataPropertyName = "CustomerID";
			this.CustomerID.HeaderText = "Column1";
			this.CustomerID.Name = "CustomerID";
			this.CustomerID.ReadOnly = true;
			this.CustomerID.Visible = false;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "FullName";
			this.Column1.HeaderText = "نام";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Mobile";
			this.Column2.HeaderText = "موبایل";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Email";
			this.Column3.HeaderText = "ایمیل";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// frmCustomers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.dgvCustomers);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmCustomers";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "لیست اشخاص";
			this.Load += new System.EventHandler(this.frmCustomers_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnAddNewCustomer;
		private System.Windows.Forms.ToolStripButton btnEditCustomer;
		private System.Windows.Forms.ToolStripButton btnDeleteCustomer;
		private System.Windows.Forms.ToolStripButton btnRefreshCustomer;
		private System.Windows.Forms.ToolStripTextBox txtFilter;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.DataGridView dgvCustomers;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
	}
}