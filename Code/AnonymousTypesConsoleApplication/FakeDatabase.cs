using System;
using System.Collections.Generic;

namespace AnonymousTypesConsoleApplication
{
	internal class FakeDatabase : IDatabase
	{
		public IEnumerable<Customer> GetCustomers() =>
			new Customer[]
			{
				new Customer() { CustomerId = 101, FirstName = "John", LastName = "Smith" },
				new Customer() { CustomerId = 102, FirstName = "Jane", LastName = "Smith" }
			};

		public IEnumerable<User> GetUsers() =>
			new User[]
			{
				new User() { Id = 2098, UserFirstName = "Bob", UserLastName = "Jones" },
				new User() { Id = 2099, UserFirstName = "Lisa", UserLastName = "Jones" }
			};

		public IEnumerable<Report> GetReports() =>
			new Report[]
			{
				new Report() { Id = 1001, Created = DateTime.Parse("01/01/2018"), CreatorUserId = "Adam", QuantityOfWidgets = 7, Cost = 36.83m, IsArchived = false },
				new Report() { Id = 1002, Created = DateTime.Parse("01/01/2018"), CreatorUserId = "Adam", QuantityOfWidgets = 4, Cost = 73.83m, IsArchived = true },
				new Report() { Id = 1003, Created = DateTime.Parse("02/22/2018"), CreatorUserId = "Adam", QuantityOfWidgets = 9, Cost = 21.38m, IsArchived = true },
				new Report() { Id = 1004, Created = DateTime.Parse("02/22/2018"), CreatorUserId = "Adam", QuantityOfWidgets = 2, Cost = 86.03m, IsArchived = false },
				new Report() { Id = 1005, Created = DateTime.Parse("02/22/2018"), CreatorUserId = "Bob", QuantityOfWidgets = 2, Cost = 236.72m, IsArchived = false },
				new Report() { Id = 1006, Created = DateTime.Parse("01/01/2018"), CreatorUserId = "Bob", QuantityOfWidgets = 5, Cost = 158.20m, IsArchived = false },
				new Report() { Id = 1007, Created = DateTime.Parse("02/22/2018"), CreatorUserId = "Bob", QuantityOfWidgets = 2, Cost = 452.49m, IsArchived = true },
				new Report() { Id = 1008, Created = DateTime.Parse("01/01/2018"), CreatorUserId = "Bob", QuantityOfWidgets = 3, Cost = 388.61m, IsArchived = false }
			};
	}
}
