using System;

namespace AnonymousTypesConsoleApplication
{
	internal class Example04
	{
		internal string GetCustomerId1()
		{
			var customer = new Customer() { CustomerId = 101, FirstName = "John", LastName = "Smith" };
			customer.IncrementCustomerId();
			var customerIdString = customer.CustomerId.ToString();
			return customerIdString;
		}

		internal string GetCustomerId2()
		{
			var customer = new { CustomerId = 101, FirstName = "John", LastName = "Smith" };
			//customer.IncrementCustomerId(); // Build Error
			var customerIdString = customer.CustomerId.ToString();
			return customerIdString;
		}
	}
}
