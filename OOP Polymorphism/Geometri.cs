using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal abstract class Geometri
    {
        public virtual double Area()
        {
            throw new NotImplementedException("Override This!");
        }
    }
}
