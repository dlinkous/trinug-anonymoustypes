using System;

namespace AnonymousTypesConsoleApplication
{
    internal class Example05
    {
		internal string GetBothLastNames()
		{
			var pair = new
			{
				Customer1 = new Customer() { CustomerId = 101, FirstName = "John", LastName = "Smith" },
				Customer2 = new Customer() { CustomerId = 102, FirstName = "Jane", LastName = "Smith" }
			};
			pair.Customer2.LastName = "Doe";
			var bothLastNames = $"{pair.Customer1.LastName}, {pair.Customer2.LastName}";
			return bothLastNames;
		}
    }
}
