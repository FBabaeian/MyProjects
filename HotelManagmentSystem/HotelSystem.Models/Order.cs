using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelModel.Models
{
	public class Order
	{	
		public int Id { get; set; }
		public int ServiceID { get; set; }
		public int Room_Id { get; set; }
		public double ServicePrice { get; set; }
		public System.DateTime? FirstDay { get; set; }
		public System.DateTime? LastDay { get; set; }
		public int? Quantity { get; set; }
		public double OrderPrice { get; set; }
		public int? CarId { get; set; }
		public int? Loundry_Id { get; set; }

		public virtual Laundry Laundry { get; set; }
		public virtual RentCar RentCar { get; set; }
		public virtual Room Room { get; set; }
	}
}