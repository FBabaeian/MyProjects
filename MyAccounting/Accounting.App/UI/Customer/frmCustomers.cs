using Accounting.DataLayer.Context;
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
	public partial class frmCustomers : Form
	{
		public frmCustomers()
		{
			InitializeComponent();
		}

		private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void frmCustomers_Load(object sender, EventArgs e)
		{
			BindGrid();
		}

	
		void BindGrid()
		{
			using (UnitOfWork db = new UnitOfWork())
			{
				dgvCustomers.AutoGenerateColumns = false;
				dgvCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
			}

		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			using (UnitOfWork db=new UnitOfWork())
			{
				dgvCustomers.DataSource = db.CustomerRepository.GetCustomersByFilter(txtFilter.Text);

			}
		}

		private void btnRefreshCustomer_Click(object sender, EventArgs e)
		{
			txtFilter.Text = "";
			BindGrid();

		}

		private void btnDeleteCustomer_Click(object sender, EventArgs e)
		{
			
			if (dgvCustomers.CurrentRow != null)
			{
				using (UnitOfWork db = new UnitOfWork())
				{
					string name = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
					if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید؟ ", " توجه ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{
						int CustomerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
						db.CustomerRepository.DeleteCustomer(CustomerId);
						db.Save();
						BindGrid();
					}
				}
			}
			else
			{
					RtlMessageBox.Show("لطفا شخص موردنظرتان را انتخاب کنید");
			}
					
			}

		private void btnAddNewCustomer_Click(object sender, EventArgs e)
		{
			frmAddOrEditeCustomer frmAdd = new frmAddOrEditeCustomer();
			if (frmAdd.ShowDialog() == DialogResult.OK)
			{
				BindGrid();
			}
		}

		private void btnEditCustomer_Click(object sender, EventArgs e)
		{
			
			if (dgvCustomers.CurrentRow !=null)
			{
				int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
				frmAddOrEditeCustomer frmAddOrEdite = new frmAddOrEditeCustomer();
				frmAddOrEdite.customerId = customerId;
				if (frmAddOrEdite.ShowDialog () ==DialogResult.OK)
				{
					BindGrid();
				}
			}
		}
	}
}

