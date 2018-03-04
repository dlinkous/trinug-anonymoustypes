using System;

namespace AnonymousTypesConsoleApplication
{
	internal class Example02
	{
		internal string GetFullName1()
		{
			var customerA = new Customer() { CustomerId = 101, FirstName = "John", LastName = "Smith" };
			var customerB = customerA;
			var fullName = $"{customerB.LastName}, {customerB.FirstName}";
			return fullName;
		}

		internal string GetFullName2()
		{
			var customerA = new { CustomerId = 101, FirstName = "John", LastName = "Smith" };
			var customerB = customerA;
			var fullName = $"{customerB.LastName}, {customerB.FirstName}";
			return fullName;
		}
	}
}
