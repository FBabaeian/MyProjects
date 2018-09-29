using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HotelModel.Models
{
	public class Customer
	{
		public int Id { get; set; }
		[MaxLength(100)]
		public string FirstName { get; set; }
		[MaxLength(100)]
		public string LastName { get; set; }
		public string Address { get; set; }
		[MaxLength(150)]
		public string Email { get; set; }
		[MaxLength(20)]
		public string Phone { get; set; }
		public int PassportNo { get; set; }
		public string Gender { get; set; }
		[MaxLength(30)]
		public string Country { get; set; }
		[MaxLength(20)]
		public string City { get; set; }
		public System.DateTime? BirthDate { get; set; }
		public string Checkstatus { get; set; }
		public virtual ICollection<CheckIn> CheckIns { get; set; }
		public virtual ICollection<CheckOut> CheckOuts { get; set; }
	}
}