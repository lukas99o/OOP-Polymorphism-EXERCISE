using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Ellips : Geometri
    {
        private double _radiusA;
        private double _radiusB;

        public Ellips()
        {
            _radiusA = 44;
            _radiusB = 56;
        }
        public override double Area()
        {
            return _radiusA * _radiusB * Math.PI;
        }
    }
}
