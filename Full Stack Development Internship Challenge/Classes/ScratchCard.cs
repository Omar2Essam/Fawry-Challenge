using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Stack_Development_Internship_Challenge.Classes
{
    public class ScratchCard : Product
    {
        public ScratchCard(string name, double price, int quantity)
             : base(name, price, quantity) { }
    }
}
