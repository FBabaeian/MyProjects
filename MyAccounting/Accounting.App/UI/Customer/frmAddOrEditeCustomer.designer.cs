using System;

namespace Accounting.App
{
	partial class frmAddOrEditeCustomer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEditeCustomer));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSelectPhoto = new System.Windows.Forms.Button();
			this.pcCustomer = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMobile = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
			this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcCustomer)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSelectPhoto);
			this.groupBox1.Controls.Add(this.pcCustomer);
			this.groupBox1.Location = new System.Drawing.Point(12, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 237);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "تصویر";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// btnSelectPhoto
			// 
			this.btnSelectPhoto.Location = new System.Drawing.Point(17, 191);
			this.btnSelectPhoto.Name = "btnSelectPhoto";
			this.btnSelectPhoto.Size = new System.Drawing.Size(164, 23);
			this.btnSelectPhoto.TabIndex = 1;
			this.btnSelectPhoto.Text = "انتخاب تصویر";
			this.btnSelectPhoto.UseVisualStyleBackColor = true;
			this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
			// 
			// pcCustomer
			// 
			this.pcCustomer.Image = global::Accounting.App.Properties.Resources.no_profile_image;
			this.pcCustomer.Location = new System.Drawing.Point(17, 21);
			this.pcCustomer.Name = "pcCustomer";
			this.pcCustomer.Size = new System.Drawing.Size(164, 162);
			this.pcCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcCustomer.TabIndex = 0;
			this.pcCustomer.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtAddress);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtEmail);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtMobile);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtName);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(248, 31);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(212, 237);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "اطلاعات شخص";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(25, 163);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(166, 51);
			this.txtAddress.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(146, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "آدرس  :";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(25, 123);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(166, 21);
			this.txtEmail.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(146, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "ایمیل  :";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// txtMobile
			// 
			this.txtMobile.Location = new System.Drawing.Point(25, 82);
			this.txtMobile.Name = "txtMobile";
			this.txtMobile.Size = new System.Drawing.Size(166, 21);
			this.txtMobile.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(143, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "موبایل  :";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(25, 42);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(166, 21);
			this.txtName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(155, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "نام  :";
			// 
			// requiredFieldValidator1
			// 
			this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
			this.requiredFieldValidator1.ControlToValidate = this.txtName;
			this.requiredFieldValidator1.ErrorMessage = "لطفا نام را وارد کنید";
			this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
			// 
			// requiredFieldValidator2
			// 
			this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
			this.requiredFieldValidator2.ControlToValidate = this.txtMobile;
			this.requiredFieldValidator2.ErrorMessage = "لطفا شماره همراه را وارد کنید";
			this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(372, 276);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "ثبت";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmAddOrEditeCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 311);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmAddOrEditeCustomer";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "افزودن شخص جدید";
			this.Load += new System.EventHandler(this.AddOrEditeCustomer_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pcCustomer)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMobile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSelectPhoto;
		private System.Windows.Forms.PictureBox pcCustomer;
		private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
		private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
		private System.Windows.Forms.Button btnSave;
	}
}