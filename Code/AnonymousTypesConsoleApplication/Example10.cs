using System;

namespace AnonymousTypesConsoleApplication
{
    internal class Example10
    {
		internal bool CompareNames1()
		{
			var customer1 = new { CustomerId = 101, FirstName = "John", LastName = "Smith" };
			var customer2 = new { CustomerId = 102, FirstName = "Jane", LastName = "Smith" };
			var hashCode1 = customer1.GetHashCode(); // Unused
			var hashCode2 = customer2.GetHashCode(); // Unused
			var equal = customer1.Equals(customer2);
			return equal;
		}

		internal bool CompareNames2()
		{
			var customer1 = new { CustomerId = 101, FirstName = "John", LastName = "Smith" };
			var customer2 = new { CustomerId = 101, FirstName = "John", LastName = "Smith" };
			var hashCode1 = customer1.GetHashCode(); // Unused
			var hashCode2 = customer2.GetHashCode(); // Unused
			var equal = customer1.Equals(customer2);
			return equal;
		}
	}
}
