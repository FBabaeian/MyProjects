using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelModel.Models
{

	public class Message
    {	[Key]
        public int UserID_from { get; set; }
        public int UserID_to { get; set; }
        public string Message1 { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual User User { get; set; }
    }
}
