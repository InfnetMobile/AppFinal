using System;
using System.Collections.Generic;

namespace InfoNews
{
	public class RootObject
	{
		public IList<Result> Results { get; set; }

		public Info Info { get; set; }
	}

	public class Info
	{
		public string Seed { get; set; }

		public int Results { get; set; }

		public int Page { get; set; }

		public string Version { get; set; }
	}
}
