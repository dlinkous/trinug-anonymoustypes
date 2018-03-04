using System;
using System.Linq;

namespace AnonymousTypesConsoleApplication
{
    internal class Example09
    {
		private readonly IDatabase database = new FakeDatabase();

		internal string[] GetAllFullNames()
		{
			var customers = database.GetCustomers().Select(c => new { c.FirstName, c.LastName });
			var users = database.GetUsers().Select(u => new { FirstName = u.UserFirstName, LastName = u.UserLastName });
			var allPeople = customers.Concat(users);
			var allFullNames = allPeople.Select(p => GetFullName(p.FirstName, p.LastName));
			return allFullNames.ToArray();
		}

		private string GetFullName(string firstName, string lastName) => $"{lastName}, {firstName}";
	}
}
