using System;
namespace RestaurantMenu
{ 
public class MenuItem
{
	public double Price { get; set; }
	public string Description { get; set; }
	public string Category { get; set; }

	public DateTime DateAdded { get; set; }

	public TimeSpan TimeOnMenu { get; set; }

        public TimeSpan timeOnMenu
        {
			get { return TimeOnMenu; }
			set { TimeOnMenu = DateTime.Today-DateAdded; }
        }

        public MenuItem(double price, string description, string category, DateTime dateAdded)
	{
			Price = price;
			Description = description;
			Category = category;
			DateAdded = dateAdded;
	}
}

}
