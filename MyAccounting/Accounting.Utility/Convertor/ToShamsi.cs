using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accounting.Utility.Convertor
{
	public static class ToShamsi
	{
		public static string Toshamsi(this DateTime value)
		{
			PersianCalendar pc = new PersianCalendar();
			return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString("00");
		}
	}
}
