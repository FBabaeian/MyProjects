using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HotelModel.Models
{
	public class User
	{
		public int Id { get; set; }
		[MaxLength(100)]
		public string Name { get; set; }
		public string Password { get; set; }
		public string MemorizeQuestion { get; set; }
		public string MemorizeAnswer { get; set; }
		public byte[] Image { get; set; }

		public virtual ICollection<Message>  Message { get; set; }
	}
}