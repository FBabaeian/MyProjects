using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accounting.Utility
{
	public  static class ToMiladi
	{
		public static DateTime toMiladi(this DateTime value)
		{
			PersianCalendar pc = new PersianCalendar();
			return new DateTime(value.Year, value.Month, value.Day,pc);
		}
	}
}
