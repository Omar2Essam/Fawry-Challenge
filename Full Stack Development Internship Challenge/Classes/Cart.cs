using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Stack_Development_Internship_Challenge.Classes
{
    public class Cart
    {
        public List<CartItem> Items { get; } = new();

        public void Add(Product product, int quantity)
        {
            if (quantity > product.Quantity)
                throw new Exception($"Not enough stock for {product.Name}!");

            Items.Add(new CartItem(product, quantity));
            product.Quantity -= quantity;
        }

        public bool IsEmpty() => !Items.Any();
    }

}
