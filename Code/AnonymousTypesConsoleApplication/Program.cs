using System;
using System.Linq;

namespace AnonymousTypesConsoleApplication
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var example01 = new Example01();
			example01.GetFullName1();
			example01.GetFullName2();
			var example02 = new Example02();
			example02.GetFullName1();
			example02.GetFullName2();
			var example03 = new Example03();
			example03.GetFullName1();
			example03.GetFullName2();
			var example04 = new Example04();
			example04.GetCustomerId1();
			example04.GetCustomerId2();
			var example05 = new Example05();
			example05.GetBothLastNames();
			var example06 = new Example06();
			example06.GetFullName1();
			example06.GetFullName2();
			var example07 = new Example07();
			example07.GetFullName1();
			example07.GetFullName2();
			var example08 = new Example08();
			example08.GetBothLastNames();
			var example09 = new Example09();
			example09.GetAllFullNames();
			var example10 = new Example10();
			example10.CompareNames1();
			example10.CompareNames2();
			var example11 = new Example11();
			example11.GetColor();
			var example12 = new Example12();
			var totals = example12.GetTotals().ToArray();
		}
	}
}
