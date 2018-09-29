using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelModel.Models
{
	public class Laundry
	{
		
		public int Id { get; set; }
		public int ServiceId { get; set; }
		[MaxLength(100)]
		public string ServiceName { get; set; }
		public string ServiceInfo { get; set; }
		public double Price { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
	}
}