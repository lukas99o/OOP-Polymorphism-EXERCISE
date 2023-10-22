using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Cirkel : Geometri
    {
        private double _radius;

        public Cirkel()
        {
            _radius = 125;
        }
        public override double Area()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
