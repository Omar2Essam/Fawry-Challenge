using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Full_Stack_Development_Internship_Challenge.Interfaces;

namespace Full_Stack_Development_Internship_Challenge.Classes
{
    public class ShippingService
    {
        public static void Ship(List<IShippable> items)
        {
            Console.WriteLine("** Shipment notice **");
            double totalWeight = 0;

            foreach (var item in items)
            {
                Console.WriteLine(item.GetName());
                totalWeight += item.GetWeight();
            }

            Console.WriteLine($"Total package weight {totalWeight}kg\n");
        }

    }

}
