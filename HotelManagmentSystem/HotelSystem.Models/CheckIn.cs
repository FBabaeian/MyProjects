using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelModel.Models
{
	public class CheckIn
	{
		public int Id { get; set; }
		public System.DateTime? CheckInDate { get; set; }
		public int? NumOfReservedDays { get; set; }
		public int CustomerId { get; set; }
		public int RoomId { get; set; }
		public int? NoAdults { get; set; }
		public int? NoChildren { get; set; }
		public int PassportNo { get; set; }
		public int? Checkoutstatus { get; set; }

		public virtual Customer Customer { get; set; }
		public virtual Room Room { get; set; }
		public virtual ICollection<CheckOut> CheckOuts { get; set; }
	}
}