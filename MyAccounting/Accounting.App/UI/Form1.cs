using Accounting.Business;
using Accounting.Utility.Convertor;
using Accounting.ViewModels.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void btnCustomers_Click(object sender, EventArgs e)
		{
			frmCustomers frmCustomer = new frmCustomers();
			frmCustomer.ShowDialog();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			this.Hide();
			frmLogin login = new frmLogin();
			if (login.ShowDialog() == DialogResult.OK)
			{
				this.Show();
				lblDate.Text = DateTime.Now.Toshamsi();
				lblTime.Text = DateTime.Now.ToShortTimeString();
				Report();
			}
			else
			{
				Application.Exit();
			}
		}

		void Report()
		{
			ReportViewModel report = Account.ReportMainForm();
			lblReceive.Text = report.Recieve.ToString("#,0");
			lblPay.Text = report.Pay.ToString("#,0");
			lblBalance.Text = report.Balance.ToString("#,0");


		}

		private void btnNewAccounting_Click(object sender, EventArgs e)
		{
			frmNewAccounting frmNewAccounting = new frmNewAccounting();
			frmNewAccounting.ShowDialog();
		}

		private void btnReportPay_Click(object sender, EventArgs e)
		{
			frmReport frmReport = new frmReport();
			frmReport.TypeID = 2;
			frmReport.ShowDialog();
		}

		private void btnReportRecive_Click(object sender, EventArgs e)
		{
			frmReport frmReport = new frmReport();
			frmReport.TypeID = 1;
			frmReport.ShowDialog();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToShortTimeString();
		}

		

		private void btnEditeLogin_Click(object sender, EventArgs e)
		{
			frmLogin login = new frmLogin();
			login.IsEdit = true;
			login.ShowDialog();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			Report();
		}
	}
}
