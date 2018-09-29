using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelModel.Models
{
	public class RentCar
	{
	
		public int Id { get; set; }
		public int ServiceID { get; set; }
		[MaxLength(100)]
		public string CarBrand { get; set; }
		public int? CustomerId { get; set; }
		public double? Price { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
	}
}