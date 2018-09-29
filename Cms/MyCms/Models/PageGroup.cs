using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyCms.Models
{
	public class PageGroup
	{
		[Key]
		public int GroupId { get; set; }

		[Display(Name ="عنوان گروه خبری")]
		[Required(ErrorMessage ="لطفا {0} را وارد کنید")]
		[MaxLength(150,ErrorMessage ="نمی تواند بیشتر از 150 کاراکتر باشد")]
		public string GroupTitle { get; set; }

		public virtual List<News> News { get; set; }
	}
}