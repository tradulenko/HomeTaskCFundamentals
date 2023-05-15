

using HomeTaskCollections;
using System.Collections;

namespace HTCollections
{
    public class MainClass
    {
        public static void Main()
        {
            //Home task 1: Collections
            List<ShoppingItem> shoppingItems = new();
            shoppingItems.Add(new ShoppingItem() { price = 16.5, quantity = 5, name = "Tomato" });
            shoppingItems.Add(new ShoppingItem() { price = 10.5, quantity = 15, name = "Potato" });

            foreach (ShoppingItem item in shoppingItems)
            Console.WriteLine(item);
        }
    }
}