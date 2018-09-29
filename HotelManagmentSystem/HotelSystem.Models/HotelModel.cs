namespace HotelModel.CL
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class HotelModel : DbContext
	{

		public HotelModel()
			: base("HotelModel")
		{
		}

	
	}


}