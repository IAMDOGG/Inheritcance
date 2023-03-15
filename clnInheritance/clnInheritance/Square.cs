using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clnInheritance
{
    internal class Square:Shape
    {
        private double side1;

        public Square() { }

        public Square(string name, int sides, double side1) {
            base.Name = name;
            base.Sides = sides;
            this.Side1 = side1;
        }


        public double Side1 { get => side1; set => side1 = value; }

        public override string ToString() { 
            return  "\nName: " + base.Name +
                "\nSides: " + this.side1 +
                "\nArea: " + this.ComputeArea() +
               "\nPerimeter: " + this.ComputePerimeter();
        }

        public override double ComputeArea()
        {
            return Math.Pow(this.side1,2);
        }

        public override double ComputePerimeter() {
            return this.side1 * 4;        
        }
    }
}
