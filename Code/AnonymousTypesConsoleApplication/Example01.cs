using System;

namespace AnonymousTypesConsoleApplication
{
	internal class Example01
	{
		internal string GetFullName1()
		{
			var customer = new Customer() { CustomerId = 101, FirstName = "John", LastName = "Smith" };
			var fullName = $"{customer.LastName}, {customer.FirstName}";
			return fullName;
		}

		internal string GetFullName2()
		{
			var customer = new { CustomerId = 101, FirstName = "John", LastName = "Smith" };
			var fullName = $"{customer.LastName}, {customer.FirstName}";
			return fullName;
		}
	}
}
