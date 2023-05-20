using HomeTaskSimpleOrderApp.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTaskSimpleOrderApp.MyExceptions;
using System.ComponentModel.Design;
using HomeTaskSimpleOrderApp.Discounts;

namespace HomeTaskSimpleOrderApp.Orders
{
    internal class Order
    {   
        private List<OrderItem> orderByProduct;
        private readonly IDiscount? Discount;
        public Order() {
            orderByProduct = new List<OrderItem>();
        }

        public Order(IDiscount discount)
        {
            orderByProduct = new List<OrderItem>();
            Discount = discount;
        }
        public void AddItem(Product product, int quantity) {
            if (product == null) { throw new ArgumentNullException("Product can`t be null); "); }
            if (quantity < 0) { throw new NegativeArgumentException("Quantity can`t be less than zero"); }

            
            orderByProduct.Add(new OrderItem(
                product.Name, 
                (Discount == null) ? product.Price : Discount.GetDiscount(product.Price),
                quantity));
            
        }

        public bool DeleteAllItemsByName (string itemNameForDel)
        {
            if (itemNameForDel == null) { throw new ArgumentNullException("ItemName can`t be null"); }
            else
            {
                orderByProduct.RemoveAll(a => a.Name == itemNameForDel);
                return true;
            }

        }

        public decimal CalculateOrderTotal()
        {
            decimal totalAmount = 0;
            orderByProduct.ForEach(a => { totalAmount += a.Amount; });
            Console.WriteLine("The sum of the order item amounts is  " + totalAmount);
            return totalAmount;
        }

        public void PrintItems()
        {
            Console.WriteLine("Next items are in order:");
            orderByProduct.ForEach(Console.WriteLine);
        }

    }
}
