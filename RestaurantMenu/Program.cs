using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //public MenuItem(double price, string description, string category, DateTime timeOnMenu)
            MenuItem shrimp = new MenuItem(5.00, "shrimp", "Appetizer", new DateTime(2020,06,20));

            MenuItem chips = new MenuItem(2.00, "chips", "Appetizer");

            MenuItem pizza = new MenuItem(5.00, "cheese pizza", "MainCourse");

            //DateTime iceCreamAdded = DateTime(6, 20, 2021, 12, 00);

            MenuItem iceCream = new MenuItem(4.00, "chocolate ice cream", "Dessert");


            Menu currentMenu = new Menu();

            currentMenu.AddItems(pizza);
            currentMenu.AddItems(shrimp);
            currentMenu.AddItems(iceCream);
            currentMenu.AddItems(chips);

            
            currentMenu.PrintMenu("Appetizers");
            Console.WriteLine("--------------------");
            currentMenu.PrintMenu("MainCourses");
            Console.WriteLine("--------------------");
            currentMenu.RemoveItems(shrimp);
            currentMenu.PrintMenu("Desserts");
            Console.WriteLine("--------------------");
            currentMenu.PrintMenu("Appetizers");
            Console.WriteLine("--------------------");
            //Menu.LastMenuUpdate();
            Console.WriteLine("--------------------");
            //currentMenu.PrintItem(chips);

            currentMenu.AddItems(chips);
            currentMenu.PrintMenu("Appetizers");





            // Console.WriteLine(pizza.Equals(pizza));



            //Console.WriteLine(pizza.Price);

            //Console.WriteLine(iceCream.Category);


        }
    }
}
