using System;

namespace AnonymousTypesConsoleApplication
{
    internal class Customer
    {
		internal int CustomerId { get; set; }
		internal string FirstName { get; set; }
		internal string LastName { get; set; }

		internal void IncrementCustomerId() => CustomerId++;
	}
}
