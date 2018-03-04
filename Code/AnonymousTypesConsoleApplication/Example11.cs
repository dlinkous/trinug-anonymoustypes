using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousTypesConsoleApplication
{
    internal class Example11
    {
		internal string GetColor()
		{
			var list = new List<FurnitureItem>();
			list.Add(new FurnitureItem() { Section = "A", Location = 1, Color = "Red" });
			list.Add(new FurnitureItem() { Section = "A", Location = 2, Color = "Orange" });
			list.Add(new FurnitureItem() { Section = "A", Location = 3, Color = "Yellow" });
			list.Add(new FurnitureItem() { Section = "B", Location = 1, Color = "Green" });
			list.Add(new FurnitureItem() { Section = "B", Location = 2, Color = "Blue" });
			var dictionary = list.ToDictionary(i => new { i.Section, i.Location });
			var item_B_1_Key = new { Section = "B", Location = 1 };
			var item_B_1_Item = dictionary[item_B_1_Key];
			return item_B_1_Item.Color;
		}
	}
}
