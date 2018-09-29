using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelModel.Models
{
	public class Bill
	{
		public int BillID { get; set; }
		public int? NumOfReservedDays { get; set; }
		public int RoomNum { get; set; }
		public string Type { get; set; }
		public double RoomPrice { get; set; }
		public double? LaundryPrice { get; set; }
		public double? RentCarPrice { get; set; }
		public double? TotalPrice { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public System.DateTime? BillDate { get; set; }
		public int? NoAdults { get; set; }
		public int? Nochild { get; set; }
		public int? CustomerID { get; set; }

		public virtual Room Room { get; set; }
	}
}