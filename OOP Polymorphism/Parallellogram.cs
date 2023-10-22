using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Parallellogram : Geometri
    {
        private double _base;
        private double _height;

        public Parallellogram()
        {
            _base = 2.5;
            _height = 5;
        }
        public override double Area()
        {
            return _base * _height;
        }
    }
}
