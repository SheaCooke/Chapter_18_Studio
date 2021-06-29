using System;
namespace RestaurantMenu
{ 
public class MenuItem
{
	public double Price { get; set; }
	public string Description { get; set; }
	public string Category { get; set; }

	public DateTime DateAdded { get; set; } = DateTime.Today;



	public TimeSpan TimeOnMenu { get; set; }

        public TimeSpan timeOnMenu
        {
			get { return TimeOnMenu; }
			set { TimeOnMenu = DateTime.Today-DateAdded; }
        }

		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != this.GetType())
			{
				return false;
			}
			MenuItem m = obj as MenuItem;
			return m.Description == Description;
		}

		public MenuItem(double price, string description, string category, DateTime dateAdded)
	{
			
			Price = price;
			Description = description;
			Category = category;
			DateAdded = dateAdded;
	}
		public MenuItem(double price, string description, string category):this(price,  description,  category, DateTime.Today)
		{		
		}
	}

}
