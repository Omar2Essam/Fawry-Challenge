using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Full_Stack_Development_Internship_Challenge.Interfaces;

namespace Full_Stack_Development_Internship_Challenge.Classes
{

    public class TV : Product, IShippable
    {
        public double Weight { get; }

        public TV(string name, double price, int quantity, double weight)
            : base(name, price, quantity)
        {
            Weight = weight;
        }

        public string GetName() => Name;
        public double GetWeight() => Weight;

    }


}
