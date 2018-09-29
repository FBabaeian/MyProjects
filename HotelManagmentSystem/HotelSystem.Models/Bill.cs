using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HotelModel.Models
{
	public class Bill
	{
		public int Id { get; set; }
		public int? NumOfReservedDays { get; set; }
		public int RoomId { get; set; }
		public string Type { get; set; }
		public double RoomPrice { get; set; }
		public double? LaundryPrice { get; set; }
		public double? RentCarPrice { get; set; }
		public double? TotalPrice { get; set; }
		[MaxLength(100)]
		public string FirstName { get; set; }
		[MaxLength(100)]
		public string LastName { get; set; }
		public System.DateTime? BillDate { get; set; }
		public int? NoAdults { get; set; }
		public int? Nochild { get; set; }
		public int? CustomerId { get; set; }

		public virtual Room Room { get; set; }
	}
}