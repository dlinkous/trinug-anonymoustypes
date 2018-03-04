using System;
using System.Collections.Generic;

namespace AnonymousTypesConsoleApplication
{
    internal interface IDatabase
    {
		IEnumerable<Customer> GetCustomers();
		IEnumerable<User> GetUsers();
		IEnumerable<Report> GetReports();
    }
}
