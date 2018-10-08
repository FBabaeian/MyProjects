﻿using System;
using System.Collections.Generic;
using Accounting.ViewModels.Customers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
	public interface ICustomerRepository
	{
		List<Customers> GetAllCustomers();
		List<ListCustomersViewModel> GetNameCustomers(string filter = "");
		IEnumerable<Customers> GetCustomersByFilter(string parameter);
		Customers GetCustomerById(int customerId);
		bool InsertCustomer(Customers customer);
		bool UpdateCustomer(Customers customer);
		bool DeleteCustomer(Customers customer);
		bool DeleteCustomer(int customerId);
		int GetCustomerIdByName(string name);
		string GetCustomerNameById(int customerId);

	}
}
