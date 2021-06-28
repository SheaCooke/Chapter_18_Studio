using System;
using System.Collections.Generic;
namespace RestaurantMenu
{
	public class Menu
	{

		public DateTime LastUpdated = DateTime.Today;

		public List<MenuItem> Appetizers = new List<MenuItem> ();
		public List<MenuItem> MainCourses = new List<MenuItem> ();
		public List<MenuItem> Desserts = new List<MenuItem> ();

		

		public void PrintMenu (string category)
        {
			if (category == "Appetizers")
			{
				foreach (var i in Appetizers)
				{
					Console.WriteLine(i.Description);
					Console.WriteLine($"Added to the menu on: {i.DateAdded}");
				}
			}
			else if (category == "MainCourses")
			{
				foreach (var i in MainCourses)
				{
					Console.WriteLine(i.Description);
					Console.WriteLine($"Added to the menu on: {i.DateAdded}");
				}
			}
			else if (category == "Desserts")
			{
				foreach (var i in Desserts)
				{
					Console.WriteLine(i.Description);
					Console.WriteLine($"Added to the menu on: {i.DateAdded}");
				}
			}
			else
            {
                Console.WriteLine("Invalid entry");
            }
		}

		public void AddItems (MenuItem item)
        {
			if (item.Category == "Appetizer")
			{
				this.Appetizers.Add(item);
				
			}
			else if (item.Category == "MainCourse")
			{
				this.MainCourses.Add(item);
				
			}
			else
			{
				this.Desserts.Add(item);
				
			}
		}
		public Menu()
		{
			
			
		}
	}
}