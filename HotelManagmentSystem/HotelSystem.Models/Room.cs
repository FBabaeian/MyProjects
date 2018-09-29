using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelModel.Models
{
	public class Room
	{   
		public int Id { get; set; }
		public string RoomInfo { get; set; }
		public string RoomStatus { get; set; }
		public string Extra { get; set; }
		public string Type { get; set; }
		public double RoomPrice { get; set; }

		public virtual ICollection<Bill> Bills { get; set; }
		public virtual ICollection<CheckIn> CheckIns { get; set; }
		public virtual ICollection<CheckOut> CheckOuts { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
	}
}