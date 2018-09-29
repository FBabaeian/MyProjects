using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MyCms.Models
{
	public class News
	{
		[Key]
		public int NewsId { get; set; }

		[Display(Name ="عنوان گروه خبری")]
		[Required(ErrorMessage ="لطفا {0} را وارد کنید")]
		public int GroupId { get; set; }

		[Required(ErrorMessage ="لطفا {0} را وارد کنید")]
		[Display(Name ="عنوان خبر")]
		[MaxLength(150,ErrorMessage ="نمی تواند بیشتر از 150 کاراکتر باشد")]
		public string NewsTitle { get; set; }

		[Display(Name ="متن خبر")]
		[Required(ErrorMessage ="لطفا {0} را وارد کنید")]
		[DataType(DataType.MultilineText)]
		[AllowHtml]
		public string NewsText { get; set; }

		[Display(Name ="نام تصویر")]
		public string ImageName { get; set; }

		[Display(Name = "بازدید")]
		public int NewsSeen { get; set; }

		[Display(Name = "تاریخ ایجاد")]
		[DisplayFormat(DataFormatString ="{0:dddd, dd MMMM yyyy}")]
		public DateTime CreateDate { get; set; } 

		public PageGroup PageGroups { get; set; }



	}
}