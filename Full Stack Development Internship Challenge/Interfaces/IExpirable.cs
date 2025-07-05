using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Stack_Development_Internship_Challenge.Interfaces
{
    public interface IExpirable
    { 
        DateTime ExpirationDate { get; set; }
        bool IsExpired();
    }
}
