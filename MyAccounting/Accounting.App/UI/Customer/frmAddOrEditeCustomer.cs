using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using ValidationComponents;

namespace Accounting.App
{
	public partial class frmAddOrEditeCustomer : Form
	{
		public int customerId = 0;
		UnitOfWork db = new UnitOfWork();
		public frmAddOrEditeCustomer()
		{
			InitializeComponent();
		}

		private void AddOrEditeCustomer_Load(object sender, EventArgs e)
		{
			if (customerId!=0)
			{
				this.Text = "ویرایش شخص";
				btnSave.Text = "ویرایش";
				var customer = db.CustomerRepository.GetCustomerById(customerId);
				txtName.Text = customer.FullName;
				txtMobile.Text = customer.Mobile;
				txtEmail.Text = customer.Email;
				txtAddress.Text = customer.Address;
				pcCustomer.ImageLocation = Application.LocalUserAppDataPath + customer.CustomerImage;
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void btnSelectPhoto_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				pcCustomer.ImageLocation = openFile.FileName;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (BaseValidator.IsFormValid(this.components))
			{
				string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
				string path = Application.LocalUserAppDataPath;
				if (!Directory.Exists(path))
				{

					Directory.CreateDirectory(path);

				}
				pcCustomer.Image.Save(path+imageName);
				Customers customers = new Customers()
				{
					FullName=txtName.Text,
					Address=txtAddress.Text,
					Email=txtEmail.Text,
					Mobile=txtMobile.Text,
					CustomerImage=imageName

				};
				if (customerId==0)
				{
					db.CustomerRepository.InsertCustomer(customers);
				}
				else
				{
					customers.CustomerID = customerId;
					db.CustomerRepository.UpdateCustomer(customers);
				}
				
				db.Save();
				DialogResult = DialogResult.OK;
			}
		}
	}
}
