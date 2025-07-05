using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Full_Stack_Development_Internship_Challenge.Interfaces;

namespace Full_Stack_Development_Internship_Challenge.Classes
{
    public class Cheese : Product, IExpirable, IShippable
    {
        public DateTime ExpirationDate { get; set; }
        public double Weight { get; }

        public Cheese(string name, double price, int quantity, DateTime expirationDate, double weight)
            : base(name, price, quantity)
        {
            ExpirationDate = expirationDate;
            Weight = weight;
        }

        public bool IsExpired() => DateTime.Now > ExpirationDate;
        public string GetName() => $"2x {Name}    {Weight * 1000}g";
        public double GetWeight() => Weight;
    }

}
