namespace Accounting.App
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblReceive = new System.Windows.Forms.Label();
			this.lblPay = new System.Windows.Forms.Label();
			this.lblBalance = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnCustomers = new System.Windows.Forms.ToolStripButton();
			this.btnNewAccounting = new System.Windows.Forms.ToolStripButton();
			this.btnReportPay = new System.Windows.Forms.ToolStripButton();
			this.btnReportRecive = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.btnEditeLogin = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.toolStrip1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(786, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStrip2
			// 
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.btnNewAccounting,
            this.btnReportPay,
            this.btnReportRecive});
			this.toolStrip2.Location = new System.Drawing.Point(0, 25);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(786, 62);
			this.toolStrip2.TabIndex = 1;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
			this.statusStrip1.Location = new System.Drawing.Point(0, 539);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(786, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblDate
			// 
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(118, 17);
			this.lblDate.Text = "toolStripStatusLabel1";
			// 
			// lblTime
			// 
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(118, 17);
			this.lblTime.Text = "toolStripStatusLabel2";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnRefresh);
			this.groupBox1.Controls.Add(this.lblBalance);
			this.groupBox1.Controls.Add(this.lblPay);
			this.groupBox1.Controls.Add(this.lblReceive);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(388, 108);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(386, 144);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "گزارش ماه جاری ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(301, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "دریافتی ها :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(301, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "پرداختی ها :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(301, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "مانده : ";
			// 
			// lblReceive
			// 
			this.lblReceive.Location = new System.Drawing.Point(23, 29);
			this.lblReceive.Name = "lblReceive";
			this.lblReceive.Size = new System.Drawing.Size(272, 23);
			this.lblReceive.TabIndex = 3;
			this.lblReceive.Text = "0";
			this.lblReceive.Click += new System.EventHandler(this.label4_Click);
			// 
			// lblPay
			// 
			this.lblPay.Location = new System.Drawing.Point(23, 55);
			this.lblPay.Name = "lblPay";
			this.lblPay.Size = new System.Drawing.Size(272, 23);
			this.lblPay.TabIndex = 4;
			this.lblPay.Text = "0";
			// 
			// lblBalance
			// 
			this.lblBalance.Location = new System.Drawing.Point(23, 78);
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.Size = new System.Drawing.Size(272, 23);
			this.lblBalance.TabIndex = 5;
			this.lblBalance.Text = "0";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(286, 115);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 6;
			this.btnRefresh.Text = "به روز رسانی";
			this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Accounting.App.Properties.Resources.bookkeeping;
			this.pictureBox1.Location = new System.Drawing.Point(0, 279);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(423, 257);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// btnCustomers
			// 
			this.btnCustomers.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
			this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.Size = new System.Drawing.Size(71, 59);
			this.btnCustomers.Text = "طرف حساب";
			this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
			// 
			// btnNewAccounting
			// 
			this.btnNewAccounting.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewAccounting.Image = global::Accounting.App.Properties.Resources._1371476499_todo_list;
			this.btnNewAccounting.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnNewAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnNewAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNewAccounting.Name = "btnNewAccounting";
			this.btnNewAccounting.Size = new System.Drawing.Size(77, 59);
			this.btnNewAccounting.Text = "تراکنش جدید";
			this.btnNewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnNewAccounting.Click += new System.EventHandler(this.btnNewAccounting_Click);
			// 
			// btnReportPay
			// 
			this.btnReportPay.Image = global::Accounting.App.Properties.Resources.servicesCosts;
			this.btnReportPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnReportPay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnReportPay.Name = "btnReportPay";
			this.btnReportPay.Size = new System.Drawing.Size(97, 59);
			this.btnReportPay.Text = "گزارش پرداختی ها";
			this.btnReportPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnReportPay.Click += new System.EventHandler(this.btnReportPay_Click);
			// 
			// btnReportRecive
			// 
			this.btnReportRecive.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
			this.btnReportRecive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnReportRecive.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnReportRecive.Name = "btnReportRecive";
			this.btnReportRecive.Size = new System.Drawing.Size(98, 59);
			this.btnReportRecive.Text = "گزارش دریافتی ها";
			this.btnReportRecive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnReportRecive.Click += new System.EventHandler(this.btnReportRecive_Click);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditeLogin});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 22);
			this.toolStripDropDownButton1.Text = "تنظیمات";
			// 
			// btnEditeLogin
			// 
			this.btnEditeLogin.Name = "btnEditeLogin";
			this.btnEditeLogin.Size = new System.Drawing.Size(151, 22);
			this.btnEditeLogin.Text = "تنظیمات ورودی";
			this.btnEditeLogin.Click += new System.EventHandler(this.btnEditeLogin_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Accounting.App.Properties.Resources.Logo;
			this.pictureBox2.Location = new System.Drawing.Point(678, 457);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(108, 79);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 561);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip2);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "حسابداری شخصی من";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripButton btnCustomers;
		private System.Windows.Forms.ToolStripButton btnNewAccounting;
		private System.Windows.Forms.ToolStripButton btnReportPay;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton btnReportRecive;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblDate;
		private System.Windows.Forms.ToolStripStatusLabel lblTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem btnEditeLogin;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblReceive;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.Label lblPay;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}

