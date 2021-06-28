using System;
using System.Collections.Generic;
namespace RestaurantMenu
{
	public class Menu
	{

		public DateTime LastUpdated = DateTime.Today;

		public List<MenuItem> Appetizers;
		public List<MenuItem> MainCourses;
		public List<MenuItem> Desserts;

		public void PrintItems(string Category)
        {

        }
		public Menu(MenuItem item)
		{
			if (item.Category == "Appetizer")
            {
				Appetizers.Add(item);
            }
			else if (item.Category == "MainCourse")
            {
				MainCourses.Add(item);
            }
			else
            {
				Desserts.Add(item);
            }
			
		}
	}
}