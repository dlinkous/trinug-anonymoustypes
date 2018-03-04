using System;

namespace AnonymousTypesConsoleApplication
{
    internal class Example07
    {
		internal string GetFullName1()
		{
			var customer1 = new { CustomerId = 101, FirstName = "John", LastName = "Smith" };
			var customer2 = new { CustomerId = 102, FirstName = "Jane", LastName = "Smith" };
			customer2 = customer1;
			var fullName = $"{customer2.LastName}, {customer2.FirstName}";
			return fullName;
		}

		internal string GetFullName2()
		{
			var customer1 = new { FirstName = "John", LastName = "Smith", CustomerId = 101 };
			var customer2 = new { CustomerId = 102, FirstName = "Jane", LastName = "Smith" };
			//customer2 = customer1; // Build Error
			var fullName = $"{customer2.LastName}, {customer2.FirstName}";
			return fullName;
		}
	}
}
