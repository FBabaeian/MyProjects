using Accounting.DataLayer.Context;
using Accounting.Utility;
using Accounting.Utility.Convertor;
using Accounting.ViewModels.Customers;
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
	public partial class frmReport : Form
	{
		public int TypeID = 0;
		public frmReport()
		{
			InitializeComponent();
		}

		private void frmReport_Load(object sender, EventArgs e)
		{
			using (UnitOfWork db = new UnitOfWork())
			{
				List<ListCustomersViewModel> list = new List<ListCustomersViewModel>();
				list.Add(new ListCustomersViewModel()
				{
					CustomerID = 0,
					FullName="انتخاب کنید"
				});
				list.AddRange(db.CustomerRepository.GetNameCustomers());

				cbCustomer.DataSource = list;
				cbCustomer.DisplayMember = "FullName";
				cbCustomer.ValueMember = "CustomerID";

			}
				if (TypeID == 1)
				{
					this.Text = "گزارش دریافتی ها";
				}
				else
				{
					this.Text = "گزارش پرداختی ها";
				}

		}

		private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			Filter();
		}

		void Filter()
		{
			using (UnitOfWork db = new UnitOfWork())
			{
				//dgReport.AutoGenerateColumns = false;
				List<DataLayer.Accounting> result = new List<DataLayer.Accounting>();
				DateTime? StartDate;
				DateTime? EndDate;

				if (txtFromDate.Text != "    /  /")
				{
					StartDate = Convert.ToDateTime(txtFromDate.Text);
					StartDate = ToMiladi.toMiladi(StartDate.Value);
					result = result.Where(r => r.DateTime >= StartDate.Value).ToList();
				}


				if (txtToDate.Text != "    /  /")
				{
					EndDate = Convert.ToDateTime(txtToDate.Text);
					EndDate = ToMiladi.toMiladi(EndDate.Value);
					result = result.Where(r => r.DateTime <= EndDate.Value).ToList();
				}



				if ((int)cbCustomer.SelectedValue != 0)
				{
					int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
					result.AddRange(db.AccountingRepository.Get(a => a.TypeID == TypeID && a.CustomerID == customerId));
				}
				else
				{
					result.AddRange(db.AccountingRepository.Get(a => a.TypeID == TypeID));

				}

				dgReport.Rows.Clear();
				foreach (var accounting in result)
				{
					string customerName = db.CustomerRepository.GetCustomerNameById(accounting.CustomerID);
					dgReport.Rows.Add(accounting.ID,customerName,accounting.Amount,accounting.DateTime.Toshamsi(),accounting.Description);
				}
			}

		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			Filter();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgReport.CurrentRow != null)
			{
				using (UnitOfWork db= new UnitOfWork())
				{
					string name = dgReport.CurrentRow.Cells[1].Value.ToString();
					if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید؟ ", " توجه ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{
						int Id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
						
						db.AccountingRepository.Delete(Id);
						db.Save();
						Filter();

					}
				}
			}
			else
			{
				RtlMessageBox.Show("لطفا شخص موردنظرتان را انتخاب کنید");
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dgReport.CurrentRow != null)
			{
				int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
				frmNewAccounting frmNew = new frmNewAccounting();
				frmNew.AccountID = id;
				if (frmNew.ShowDialog() == DialogResult.OK)
				{
					Filter();
				}
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			DataTable dtPrint = new DataTable();
			dtPrint.Columns.Add("Customer");
			dtPrint.Columns.Add("Amount");
			dtPrint.Columns.Add("Date");
			dtPrint.Columns.Add("Description");
			foreach (DataGridViewRow item in dgReport.Rows)
			{
				dtPrint.Rows.Add(
					item.Cells[0].Value.ToString(),
					item.Cells[1].Value.ToString(),
					item.Cells[2].Value.ToString(),
					item.Cells[3].Value.ToString()

					);
			}
			stiPrint.RegData("DT",dtPrint);
			stiPrint.Load(Application.StartupPath + "/Report.mrt");
			stiPrint.Show();
		}
	}
}
