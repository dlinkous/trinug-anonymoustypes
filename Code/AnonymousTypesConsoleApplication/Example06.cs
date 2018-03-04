using System;

namespace AnonymousTypesConsoleApplication
{
    internal class Example06
    {
		internal string GetFullName1()
		{
			var customer = new Customer() { CustomerId = 101, FirstName = "John", LastName = "Smith" };
			var customerNames = new { FirstName = customer.FirstName, LastName = customer.LastName };
			var fullName = $"{customerNames.LastName}, {customerNames.FirstName}";
			return fullName;
		}

		internal string GetFullName2()
		{
			var customer = new Customer() { CustomerId = 101, FirstName = "John", LastName = "Smith" };
			var customerNames = new { customer.FirstName, customer.LastName };
			var fullName = $"{customerNames.LastName}, {customerNames.FirstName}";
			return fullName;
		}
	}
}
