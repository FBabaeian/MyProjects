﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;

namespace Accounting.App
{
	public partial class frmNewAccounting : Form
	{
		
		private UnitOfWork db;
		public int AccountID = 0;
		public frmNewAccounting()
		{
			InitializeComponent();
		}

		private void frmNewAccounting_Load(object sender, EventArgs e)
		{
			
			db = new UnitOfWork();
			dgvCustomers.AutoGenerateColumns = false;
			dgvCustomers.DataSource = db.CustomerRepository.GetNameCustomers();
			if (AccountID !=0)
			{
				var account = db.AccountingRepository.GetById(AccountID);
				txtAmount.Text = account.Amount.ToString();
				txtDescription.Text = account.Description;
				textName.Text = db.CustomerRepository.GetCustomerNameById(account.CustomerID);
				if (account.TypeID == 1)
				{
					rbRecive.Checked = true;

				}
				else
				{
					rbPay.Checked = true;
				}
				this.Text = "ویرایش";
				btnSave.Text = "ویرایش";
				db.Dispose();
			}
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			dgvCustomers.AutoGenerateColumns = false;
			dgvCustomers.DataSource = db.CustomerRepository.GetNameCustomers(txtFilter.Text);
		}

		private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textName.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			
			if (BaseValidator.IsFormValid(this.components))
			{
				if (rbPay.Checked || rbRecive.Checked)
				{
					db = new UnitOfWork();
					DataLayer.Accounting accounting = new DataLayer.Accounting()
					{
						Amount = int.Parse(txtAmount.Value.ToString()),
						CustomerID = db.CustomerRepository.GetCustomerIdByName(textName.Text),
						TypeID = (rbRecive.Checked) ? 1 : 2,
						DateTime = DateTime.Now,
						Description=txtDescription.Text
					};
					if (AccountID == 0)
					{
						db.AccountingRepository.Insert(accounting);
					}
					else
					{
						accounting.ID = AccountID;
						db.AccountingRepository.Update(accounting);
					}
					
					db.Save();
					db.Dispose();
					DialogResult = DialogResult.OK;
				}
				else
				{
					RtlMessageBox.Show("لطفا نوع تراکنش را مشخص کنید");
				}

			}
		}
	}
}

