using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelModel.Models
{
	public class CheckOut
	{  
		public int Id { get; set; }
		public System.DateTime? CheckOutDate { get; set; }
		public int CheckInId { get; set; }
		public int RoomId { get; set; }
		public int CustomerId { get; set; }
		public int NoAdults { get; set; }
		public int? NoChildren { get; set; }
		public int PassportNo { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual CheckIn CheckIn { get; set; }
		public virtual Room Room { get; set; }
		


	}
}