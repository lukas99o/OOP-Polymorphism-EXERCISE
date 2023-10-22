using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Rektangel : Geometri
    {
        private double _base;
        private double _height;

        public Rektangel()
        {
            _base = 5;
            _height = 10;
        }
        public override double Area()
        {
            return _base * _height;
        }
    }
}
