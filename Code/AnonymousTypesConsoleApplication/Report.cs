using System;

namespace AnonymousTypesConsoleApplication
{
	internal class Report
	{
		internal int Id { get; set; }
		internal DateTime Created { get; set; }
		internal string CreatorUserId { get; set; }
		internal int QuantityOfWidgets { get; set; }
		internal decimal Cost { get; set; }
		internal bool IsArchived { get; set; }
	}
}
