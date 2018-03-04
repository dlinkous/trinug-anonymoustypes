using System;

namespace AnonymousTypesConsoleApplication
{
    internal class Example08
    {
		internal string GetBothLastNames()
		{
			var customers = new[]
			{
				new { CustomerId = 101, FirstName = "John", LastName = "Smith" },
				new { CustomerId = 102, FirstName = "Jane", LastName = "Smith" }
			};
			var bothLastNames = $"{customers[0].LastName}, {customers[1].LastName}";
			return bothLastNames;
		}
	}
}
