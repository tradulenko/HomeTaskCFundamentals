
using HomeTaskSimpleOrderApp.Discounts;
using HomeTaskSimpleOrderApp.Orders;
using HomeTaskSimpleOrderApp.Products;

namespace HomeTaskSimpleOrderApp
{
    class SimpleOrderApp
    {
        public static void Main(string[] args)
        {
            Book book = new("book", 6);
            Console.WriteLine(book);

            Food food = new("food", 8);
            Console.WriteLine(food);

            Electronics electronics = new("electronics", 10);
            Console.WriteLine(electronics);

            OrderItem item = new("OrdItem", 15, 5);
            Console.WriteLine(item);
            item.Discount = 5;
            Console.WriteLine(item);
            item.Quantity = 4;
            Console.WriteLine(item);

            // 7.c Create an Order without any Discount and add some items to it
            Order order = new();
            order.AddItem(book, 5);
            order.AddItem(book, 6);
            order.AddItem(food, 7);
            order.AddItem(electronics, 11);
            order.CalculateOrderTotal();
            order.PrintItems();
            order.DeleteAllItemsByName(nameof(book));
            order.CalculateOrderTotal();
            order.PrintItems();

            Order orderWithDiscount = new(new FixDiscount(7));
            orderWithDiscount.AddItem(book, 5);
            orderWithDiscount.AddItem(food, 15);
            orderWithDiscount.PrintItems();
        }
    }
}

