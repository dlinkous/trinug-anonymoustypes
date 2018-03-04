using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousTypesConsoleApplication
{
    internal class Example12
    {
		internal class Result
		{
			internal DateTime Created { get; set; }
			internal string CreatorUserId { get; set; }
			internal int TotalQuantityOfWidgets { get; set; }
			internal decimal TotalCost { get; set; }
		}

		private readonly IDatabase database = new FakeDatabase();

		internal IEnumerable<Result> GetTotals() =>
			database.GetReports()
				.GroupBy(r => new { r.Created, r.CreatorUserId })
				.Select(g => new Result()
				{
					Created = g.Key.Created,
					CreatorUserId = g.Key.CreatorUserId,
					TotalQuantityOfWidgets = g.Sum(r => r.QuantityOfWidgets),
					TotalCost = g.Sum(r => r.Cost)
				});
	}
}
