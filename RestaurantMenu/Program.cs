using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //public MenuItem(double price, string description, string category, DateTime timeOnMenu)

            MenuItem pizza = new MenuItem(5.00, "cheese", "MainCourse", DateTime.Today);

            //DateTime iceCreamAdded = DateTime(6, 20, 2021, 12, 00);

            MenuItem iceCream = new MenuItem(4.00, "chocolate", "Dessert", DateTime.Today);


            Menu juneMenu = new Menu(pizza);

            juneMenu = new Menu(iceCream);
            






            Console.WriteLine(pizza.Price);

            Console.WriteLine(iceCream.Category);


        }
    }
}
