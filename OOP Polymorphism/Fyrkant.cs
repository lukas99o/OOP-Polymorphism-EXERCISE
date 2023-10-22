using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Fyrkant : Geometri
    {
        private double _base;
        private double _height;

        public Fyrkant()
        {
            _base = 20;
            _height = 20;
        }
        public override double Area()
        {
            return _base * _height;
        }
    }
}
