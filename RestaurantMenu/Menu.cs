using System;
using System.Collections.Generic;
namespace RestaurantMenu
{
	public class Menu
	{

		public static DateTime LastUpdated = new DateTime(2021, 06, 28);

		public List<MenuItem> Appetizers = new List<MenuItem> ();
		public List<MenuItem> MainCourses = new List<MenuItem> ();
		public List<MenuItem> Desserts = new List<MenuItem> ();

		public List<MenuItem> TotalMenu = new List<MenuItem>();

		

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

			bool itemInMenu = false;

			foreach (var i in TotalMenu)
            {
				
				if (i.Equals(item))
                {
                    Console.WriteLine("That item is already in this menu.");
					itemInMenu = true;
					//System.Environment.Exit(0);
                }
				
            }
			if (!itemInMenu)
			{
				if (item.Category == "Appetizer")
				{
					this.Appetizers.Add(item);
					this.TotalMenu.Add(item);

				}
				else if (item.Category == "MainCourse")
				{
					this.MainCourses.Add(item);
					this.TotalMenu.Add(item);

				}
				else
				{
					this.Desserts.Add(item);
					this.TotalMenu.Add(item);

				}

			}
		}

		public void RemoveItems(MenuItem item)
        {
			if (item.Category == "Appetizer")
			{
				this.Appetizers.Remove(item);

			}
			else if (item.Category == "MainCourse")
			{
				this.MainCourses.Remove(item);

			}
			else
			{
				this.Desserts.Remove(item);

			}

		}

		public static void LastMenuUpdate()
        {
            Console.WriteLine($"The menu was last updated on {LastUpdated}");
        }

		public void PrintItem(MenuItem item)
        {
			if (item.Category == "Appetizer")
			{
                foreach (var i in Appetizers)
                {
					if (i.Description == item.Description)
                    {
                        Console.WriteLine($"Description: {item.Description} \nPrice {item.Price} \nDate added to menu: {item.DateAdded}");
                    }
                }

			}
			else if (item.Category == "MainCourse")
			{
				foreach (var i in MainCourses)
				{
					if (i.Description == item.Description)
					{
						Console.WriteLine($"Description: {item.Description} \nPrice {item.Price} \nDate added to menu: {item.DateAdded}");
					}
				}

			}
			else if (item.Category == "Dessert")
			{
				foreach (var i in Desserts)
				{
					if (i.Description == item.Description)
					{
						Console.WriteLine($"Description: {item.Description} \nPrice {item.Price} \nDate added to menu: {item.DateAdded}");
					}
				}

			}
			else
			{
				Console.WriteLine("Invalid entry");
			}
		}

        
        public Menu()
		{
			

		}
	}
}