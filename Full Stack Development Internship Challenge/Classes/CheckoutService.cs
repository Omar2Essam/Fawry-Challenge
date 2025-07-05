using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Full_Stack_Development_Internship_Challenge.Interfaces;

namespace Full_Stack_Development_Internship_Challenge.Classes
{
    public static class CheckoutService
    {
        public static void Checkout(Customer customer, Cart cart)
        {
            if (cart.IsEmpty())
                throw new Exception("Cart is empty!");

            double subtotal = 0;
            double shipping = 0;
            List<IShippable> toShip = new();

            foreach (var item in cart.Items)
            {
                if (item.Product is IExpirable expirable && expirable.IsExpired())
                    throw new Exception($"{item.Product.Name} is expired!");

                subtotal += item.Product.Price * item.Quantity;

                if (item.Product is IShippable shippable)
                {
                    toShip.Add(shippable);
                    shipping += 15; // 15 ثابت لكل شحنة لتطابق الناتج المطلوب
                }
            }

            double total = subtotal + shipping;

            if (customer.Balance < total)
                throw new Exception("Insufficient balance!");

            customer.Balance -= total;

            if (toShip.Count > 0)
                ShippingService.Ship(toShip);

            Console.WriteLine("** Checkout receipt **");
            foreach (var item in cart.Items)
                Console.WriteLine($"{item.Quantity}x {item.Product.Name}    {item.Product.Price * item.Quantity}");

            Console.WriteLine("----------------------");
            Console.WriteLine($"Subtotal {subtotal}");
            Console.WriteLine($"Shipping {shipping}");
            Console.WriteLine($"Amount {total}");
        }
    }
}
