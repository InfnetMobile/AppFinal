using System;
using SQLiteNetExtensions.Attributes;

namespace InfoNews
{
	public class Location
	{
		public string Street { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string PostCode { get; set; }
	}
}
